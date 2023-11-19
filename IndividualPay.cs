using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class IndividualPay : Form
    {
        public IndividualPay()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.Show();
            this.Hide();
        }

        public decimal GetBasicSalaryByEmployeeId(int employeeId)
        {
            decimal basicSalary = 0;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT BasicSalary FROM Employee WHERE Employee_ID = @Employee_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", employeeId);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        basicSalary = Convert.ToDecimal(result);
                    }
                }
            }

            return basicSalary;
        }

        public string GetNameByEmployeeId(int employeeId)
        {
            string employeeName = null;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Employee WHERE Employee_ID = @Employee_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", employeeId);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        employeeName = result.ToString();
                    }
                }
            }

            return employeeName;
        }

        public DataTable ConvertStringArrayToDataTable(string[] stringArray)
        {
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Employee_ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("BasicSalary", typeof(string));
            dataTable.Columns.Add("Allowances", typeof(string));
            dataTable.Columns.Add("TotalLeaves", typeof(string));
            dataTable.Columns.Add("Deductions", typeof(string));
            dataTable.Columns.Add("NetSalary", typeof(string));


            DataRow row = dataTable.NewRow();
            for (int i = 0; i < stringArray.Length; i++)
            {
                row[i] = stringArray[i];
            }
            dataTable.Rows.Add(row);

            return dataTable;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            if (search.SearchEmployeeById(Convert.ToInt32(empIdSalary.Text)))
            {
                string name = GetNameByEmployeeId(Convert.ToInt32(empIdSalary.Text));
                int noOfLeaves = GetTotalLeaveDaysForOctober2023(Convert.ToInt32(empIdSalary.Text));
                int basicPay = Convert.ToInt32(GetBasicSalaryByEmployeeId(Convert.ToInt32(empIdSalary.Text)));
                int allowance = basicPay / 10;
                int deductions = (basicPay / 30) * noOfLeaves;
                int netPay = basicPay + allowance - deductions;

                string[] individualPay = { Convert.ToString(empIdSalary.Text) , name, Convert.ToString(basicPay), Convert.ToString(allowance), Convert.ToString(noOfLeaves), Convert.ToString(deductions), Convert.ToString(netPay) };
                DataTable dataTable = ConvertStringArrayToDataTable(individualPay);
                payGrid.DataSource = dataTable;


            }
            else
            {
                MessageBox.Show("No employee found with the given ID.");
            }
        }

        public int GetTotalLeaveDaysForOctober2023(int employeeId)
        {
            int totalLeaveDays = 0;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DATEDIFF(DAY, StartDate, EndDate) + 1 AS LeaveDays " +
                               "FROM [dbo].[Leave] " +
                               "WHERE EmployeeId = @EmployeeId " +
                               "AND YEAR(StartDate) = 2023 " +
                               "AND MONTH(StartDate) = 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            totalLeaveDays += Convert.ToInt32(reader["LeaveDays"]);
                        }
                    }
                }
            }

            return totalLeaveDays;
        }

        private void IndividualPay_Load(object sender, EventArgs e)
        {
            
        }

        private void payGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
