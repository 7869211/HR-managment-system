using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class UpdateEmployee : Form
    {
        public TextBox empID;
        public UpdateEmployee(TextBox id)
        {
            InitializeComponent();
            empID = id;
        }

        private void updateEmployee()
        {
            if (!string.IsNullOrEmpty(empNameUpdate.Text) && !string.IsNullOrEmpty(empCnicUpdate.Text)
                && !string.IsNullOrEmpty(empAddressUpdate.Text) && !string.IsNullOrEmpty(empContactUpdate.Text) && !string.IsNullOrEmpty(empEmailUpdate.Text)
                && !string.IsNullOrEmpty(empDesignationUpdate.Text) && !string.IsNullOrEmpty(empSalaryUpdate.Text))
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Employee SET Name = @Name, CNIC = @CNIC, Address = @Address, Contact = @Contact, Email = @Email, Designation = @Designation, BasicSalary = @BasicSalary, Allowances = @Allowances, NetSalary = @NetSalary WHERE Employee_ID = @Employee_ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Employee_ID", Convert.ToInt32(empID.Text));
                        command.Parameters.AddWithValue("@Name", empNameUpdate.Text);
                        command.Parameters.AddWithValue("@CNIC", empCnicUpdate.Text);
                        command.Parameters.AddWithValue("@Address", empAddressUpdate.Text);
                        command.Parameters.AddWithValue("@Contact", empContactUpdate.Text);
                        command.Parameters.AddWithValue("@Email", empEmailUpdate.Text);
                        command.Parameters.AddWithValue("@Designation", empDesignationUpdate.Text);
                        command.Parameters.AddWithValue("@BasicSalary", Convert.ToDecimal(empSalaryUpdate.Text));

                        // Assuming Allowances and NetSalary are decimal values. If not, adjust the data type accordingly.
                        command.Parameters.AddWithValue("@Allowances", Convert.ToDecimal(empSalaryUpdate.Text) / 10);
                        command.Parameters.AddWithValue("@NetSalary", (Convert.ToDecimal(empSalaryUpdate.Text) / 10) + Convert.ToDecimal(empSalaryUpdate.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Employee details updated successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields must be non-empty");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void backSaveEmployeeButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void empSaveButton_Click(object sender, EventArgs e)
        {
            updateEmployee();

            empNameUpdate.Text = null;
            empCnicUpdate.Text = null;
            empAddressUpdate.Text = null;
            empContactUpdate.Text = null;
            empEmailUpdate.Text = null;
            empDesignationUpdate.Text = null;
            empSalaryUpdate.Text = null;
        }

        private void empNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
