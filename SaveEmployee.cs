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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HR_Management_System
{
    public partial class SaveEmployee : Form
    {
        public SaveEmployee()
        {
            InitializeComponent();
        }

        public void saveEmployee()
        {
            if (!string.IsNullOrEmpty(empId.Text) && !string.IsNullOrEmpty(empName.Text) && !string.IsNullOrEmpty(empCnic.Text) && !string.IsNullOrEmpty(empAddress.Text)
                && !string.IsNullOrEmpty(empContact.Text) && !string.IsNullOrEmpty(empEmail.Text) && !string.IsNullOrEmpty(empDesignation.Text) && !string.IsNullOrEmpty(empSalary.Text))
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Employee (Employee_ID, Name, CNIC, Address, Contact, Email, Designation, BasicSalary, Allowances, NetSalary) VALUES (@Employee_ID, @Name, @CNIC, @Address, @Contact, @Email, @Designation, @BasicSalary, @Allowances, @NetSalary)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Employee_ID", Convert.ToInt32(empId.Text));
                        command.Parameters.AddWithValue("@Name", empName.Text);
                        command.Parameters.AddWithValue("@CNIC", empCnic.Text);
                        command.Parameters.AddWithValue("@Address", empAddress.Text);
                        command.Parameters.AddWithValue("@Contact", empContact.Text);
                        command.Parameters.AddWithValue("@Email", empEmail.Text);
                        command.Parameters.AddWithValue("@Designation", empDesignation.Text);
                        command.Parameters.AddWithValue("@BasicSalary", Convert.ToDecimal(empSalary.Text));
                        command.Parameters.AddWithValue("@Allowances", Convert.ToDecimal(empSalary.Text) / 10);
                        command.Parameters.AddWithValue("@NetSalary", (Convert.ToDecimal(empSalary.Text) / 10) + Convert.ToDecimal(empSalary.Text));

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Employee Saved Successfully");
                }
            }
            else
            {
                MessageBox.Show("All fields must be non-empty");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backSaveEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeRecord record = new EmployeeRecord();
            record.Show();
            this.Hide();
        }

        private void empSaveButton_Click(object sender, EventArgs e)
        {
            saveEmployee();
            empId.Text = null;
            empName.Text = null;
            empCnic.Text = null;
            empAddress.Text = null;
            empContact.Text = null;
            empEmail.Text = null;
            empDesignation.Text = null;
            empSalary.Text = null;

        }

        private void SaveEmployee_Load(object sender, EventArgs e)
        {

        }

        private void empId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
