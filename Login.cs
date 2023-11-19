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
    public partial class Login : Form
    {
        private String username;
        private String password;
        public Login()
        {
            username = null;
            password = null;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //username= loginUsername.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginUsername.Text == "noman" && loginPassword.Text == "123")
            {
                Management management = new Management();  
                management.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            //password= loginPassword.Text;
        }


    }
}
