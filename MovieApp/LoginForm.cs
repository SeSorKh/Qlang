﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class LoginForm : Form
    {
        private NewMovieDBEntities context;

        public LoginForm()
        {
            InitializeComponent();
            context = new NewMovieDBEntities();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                var isAdmin = user.IsAdmin;
                var accountBalance = user.AccountBalance;
                var expirationDate = user.ExpirationDate;

                Form1 form1;

                if (isAdmin)
                {
                    form1 = new Form1(isAdmin);
                }
                else
                {
                    form1 = new Form1(isAdmin, accountBalance ?? 0m, expirationDate);
                }

                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
