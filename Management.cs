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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeRecord record = new EmployeeRecord();
            record.Show();
            this.Hide();
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void managementBackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pmButton_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.Show();
            this.Hide();
        }

        private void lmButton_Click(object sender, EventArgs e)
        {
            LeaveRecord record = new LeaveRecord();
            record.Show();
            this.Hide();
        }
    }
}
