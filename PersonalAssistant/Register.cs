﻿using EmailClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAssistant
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Welcome();
            newform.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)
                || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                const string message = "You have to fill the required fields (*) in order to Register.";
                const string caption = "Unsigned Fields";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else if (textBox1.Text == "User")
            {
                const string message = "The User with Username 'User' Already Exists.";
                const string caption = "Username Exists";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else if (textBox3.Text != textBox5.Text)
            {
                const string message = "The Passwords on both fields aren't match. ";
                const string caption = "Passwords doesn't match";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                Close();
                const string message = "Congratulations! You have been registered. Now you can Log In with your Credentials. ";
                const string caption = "New User Registered";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }
    }
}
