using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness.Tracker
{
    public partial class Form2 : Form
    {
        private static Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (registeredUsers.ContainsKey(username) && registeredUsers[username] == password)
            {
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Redirect to Dashboard or Main Form
                this.Hide();
                Form3 mainForm = new Form3();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
