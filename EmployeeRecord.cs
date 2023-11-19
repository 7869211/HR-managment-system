using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class EmployeeRecord : Form
    {
        public EmployeeRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveEmployee employee = new SaveEmployee();
            employee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search employee = new Search();
            employee.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveEmployee employee = new RemoveEmployee();
            employee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEmployees employee = new ViewEmployees();
            employee.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Management employee = new Management();
            employee.Show();
            this.Hide();
        }

        private void EmployeeRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
