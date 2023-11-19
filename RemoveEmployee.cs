using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        public void removeEmployee()
        {
            Search search = new Search();
            if (search.SearchEmployeeById(Convert.ToInt32(removeId.Text)))
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"Delete from Employee where Employee_ID = '{Convert.ToInt32(removeId.Text)}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                   
                }
                MessageBox.Show("Employee removed successfully.");
                ViewEmployees employees = new ViewEmployees();
                employees.LoadEmployees(removeGrid);

            }
            else
            {
                MessageBox.Show("No employee found with the given ID.");
            }
        }
        



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ViewEmployees employees = new ViewEmployees();
            employees.LoadEmployees(removeGrid);
        }

        private void removeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeRecord record = new EmployeeRecord();
            record.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeEmployee();
        }
    }
}
