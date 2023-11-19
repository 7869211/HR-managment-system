using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HR_Management_System
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int[] GetAllEmployeeIds()
        {
            List<int> employeeIds = new List<int>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Employee_ID FROM Employee";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeId = reader.GetInt32(reader.GetOrdinal("Employee_ID"));
                            employeeIds.Add(employeeId);
                        }
                    }
                }
            }

            return employeeIds.ToArray();
        }


        private void GenerateReport_Load(object sender, EventArgs e)
        {
            int[] empIDS = GetAllEmployeeIds(); 
            IndividualPay individualPay = new IndividualPay();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Employee_ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("BasicSalary", typeof(string));
            dataTable.Columns.Add("Allowances", typeof(string));
            dataTable.Columns.Add("TotalLeaves", typeof(string));
            dataTable.Columns.Add("Deductions", typeof(string));
            dataTable.Columns.Add("NetSalary", typeof(string));

            foreach (int empID in empIDS)
            {

                int noOfLeaves = individualPay.GetTotalLeaveDaysForOctober2023(empID);
                int basicPay = Convert.ToInt32(individualPay.GetBasicSalaryByEmployeeId(empID));
                int allowance = basicPay / 10;
                int deductions = (basicPay / 30) * noOfLeaves;
                int netPay = basicPay + allowance - deductions;

                string[] individualPayString = { Convert.ToString(empID), individualPay.GetNameByEmployeeId(empID), Convert.ToString(basicPay), Convert.ToString(allowance), Convert.ToString(noOfLeaves), Convert.ToString(deductions), Convert.ToString(netPay) };



                DataRow row = dataTable.NewRow();
                for (int i = 0; i < individualPayString.Length; i++)
                {
                    row[i] = individualPayString[i];
                }
                dataTable.Rows.Add(row);
            }
            reportGrid.DataSource = dataTable;
        }
    }
}
