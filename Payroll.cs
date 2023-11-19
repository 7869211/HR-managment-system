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
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Management payroll = new Management();
            payroll.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IndividualPay payroll = new IndividualPay();
            payroll.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateReport payroll = new GenerateReport();
            payroll.Show();
            this.Hide();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {

        }
    }
}
