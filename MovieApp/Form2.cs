using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Form2 : Form
    {
        private NewMovieDBEntities context;
        private bool isAdmin;

        public Form2(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            context = new NewMovieDBEntities();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void LoadAllUsers()
        {
            var users = context.Users.Select(u => new { u.UserID, u.Username, u.IsAdmin, u.AccountBalance, u.ExpirationDate }).ToList();
            dataGridViewUsers.DataSource = users;
        }

        private void buttonSearchByID_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(textBoxUserID.Text, out userId))
            {
                var user = context.Users
                    .Where(u => u.UserID == userId)
                    .Select(u => new { u.UserID, u.Username, u.IsAdmin, u.AccountBalance, u.ExpirationDate })
                    .ToList();
                dataGridViewUsers.DataSource = user;
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID.");
            }
        }

        private void buttonLoadAllUsers_Click(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void buttonSwitchToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(isAdmin);
            form1.Show();
            this.Hide();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
