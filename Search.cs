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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }


        public bool SearchEmployeeById(int employeeId)
        {
            bool employeeExists = false;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                int searchId = employeeId;

                string query = "SELECT 1 FROM Employee WHERE Employee_ID = @Employee_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", searchId);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        
                        employeeExists = true;
                    }
                }
            }

            return employeeExists;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (SearchEmployeeById(Convert.ToInt32(searchId.Text)))
            {
                UpdateEmployee updateEmployee = new UpdateEmployee(searchId);
                updateEmployee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No employee found with the given ID.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeRecord record = new EmployeeRecord();
            record.Show();
            this.Hide();
        }

        private void updateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void searchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ViewEmployees employees = new ViewEmployees();
            employees.LoadEmployees(updateGrid);
        }
    }
}
