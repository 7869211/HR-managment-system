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

namespace HR_Management_System
{
    
    public partial class LeaveRecord : Form
    {
        
        public LeaveRecord()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Management payroll = new Management();
            payroll.Show();
            this.Hide();
        }

        public void InsertLeave(int employeeId, string leaveType, DateTime startDate, DateTime endDate)
        {
            if (employeeId > 0 && !string.IsNullOrEmpty(leaveType) && startDate <= endDate)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [dbo].[Leave] (EmployeeId, LeaveReason, StartDate, EndDate) VALUES (@EmployeeId, @LeaveType, @StartDate, @EndDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@LeaveType", leaveType);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Leave record saved successfully.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input values. Please check employee ID, leave type, and dates.");
            }
        }

        public DataTable SelectAllLeaves()
        {
            DataTable leaveData = new DataTable();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [dbo].[Leave]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(leaveData);
                    }
                }
            }

            return leaveData;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Search search = new Search();

            if (search.SearchEmployeeById(Convert.ToInt32(leaveId.Text)))
            {
                InsertLeave(Convert.ToInt32(leaveId.Text), Convert.ToString(leaveType.Text), Convert.ToDateTime(startDate.Text), Convert.ToDateTime(endDate.Text));
                DataTable dataTable = SelectAllLeaves();
                leaveGrid.DataSource = dataTable;
                leaveId.Text = null;
                leaveType.Text = null;
                startDate.Text = null;
                endDate.Text = null;

            }
            else
            {
                MessageBox.Show("No employee found with the given ID.");
            }
        }

        private void LeaveRecord_Load(object sender, EventArgs e)
        {
            DataTable dataTable = SelectAllLeaves();
            leaveGrid.DataSource = dataTable;
        }

        private void leaveGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
