using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Form1 : Form
    {
        private NewMovieDBEntities context;
        private bool isAdmin;
        private decimal accountBalance;
        private DateTime? expirationDate;

        public Form1(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            context = new NewMovieDBEntities();

            if (!isAdmin)
            {
                buttonSwitchToForm2.Visible = false;
            }
        }

        public Form1(bool isAdmin, decimal accountBalance, DateTime? expirationDate)
            : this(isAdmin)
        {
            this.accountBalance = accountBalance;
            this.expirationDate = expirationDate;

            // Update labels for account balance and expiration date
            labelAccountBalance.Text = $"Account Balance: ${accountBalance}";
            labelExpirationDate.Text = $"Expiration Date: {expirationDate?.ToString("d")}";
        }

        private void buttonAllMovies_Click(object sender, EventArgs e)
        {
            var movies = context.Movies
                .Select(m => new
                {
                    m.MovieID,
                    m.Title,
                    m.ReleaseDate,
                    Language = m.Language.LanguageName,
                    m.BoxOffices,
                    m.MoviesDirectedBies
                })
                .ToList();
            dataGridView.DataSource = movies;
        }

        private void buttonUnreleased2017_Click(object sender, EventArgs e)
        {
            var unreleasedMovies = context.Movies
                .Where(m => m.ReleaseDate.HasValue && m.ReleaseDate.Value.Year == 2017)
                .ToList();
            dataGridView.DataSource = unreleasedMovies;
        }

        private void buttonNonEnglishLanguages_Click(object sender, EventArgs e)
        {
            var nonEnglishMovies = context.Movies
                .Where(m => m.Language.LanguageName != "English")
                .Select(m => new
                {
                    m.MovieID,
                    m.Title,
                    m.ReleaseDate,
                    Language = m.Language.LanguageName,
                    m.BoxOffices,
                    m.MoviesDirectedBies
                })
                .ToList();
            dataGridView.DataSource = nonEnglishMovies;
        }

        private void buttonToyStoryDirectors_Click(object sender, EventArgs e)
        {
            var directors = context.MoviesDirectedBies
                .Where(mdb => mdb.Movy.Title.Contains("Toy Story"))
                .OrderBy(mdb => mdb.Movy.ReleaseDate)
                .Select(mdb => new
                {
                    mdb.Movy.Title,
                    mdb.Director.DirectorName,
                    mdb.Movy.ReleaseDate
                })
                .ToList();
            dataGridView.DataSource = directors;
        }

        private void buttonEmployeesByBuilding_Click(object sender, EventArgs e)
        {
            var employeesByBuilding = context.Buildings
                .GroupJoin(
                    context.Employees,
                    b => b.BuildingID,
                    emp => emp.BuildingID,
                    (b, es) => new
                    {
                        b.BuildingName,
                        Employees = es.Select(emp => emp.EmployeeName).DefaultIfEmpty("No Employees")
                    })
                .ToList();
            dataGridView.DataSource = employeesByBuilding.SelectMany(b => b.Employees.Select(emp => new { b.BuildingName, EmployeeName = emp })).ToList();
        }

        private void buttonMoviesWithMultipleDirectors_Click(object sender, EventArgs e)
        {
            var moviesWithMultipleDirectors = context.MoviesDirectedBies
                .GroupBy(mdb => mdb.MovieID)
                .Where(g => g.Count() > 1)
                .AsEnumerable()
                .Select(g => new
                {
                    MovieTitle = g.FirstOrDefault()?.Movy.Title,
                    MainDirector = g.FirstOrDefault(d => d.IsMainDirector == true)?.Director.DirectorName ?? "N/A",
                    AssistantDirector = g.FirstOrDefault(d => d.IsMainDirector == false)?.Director.DirectorName ?? "N/A"
                })
                .ToList();
            dataGridView.DataSource = moviesWithMultipleDirectors;
        }

        private void buttonTotalSales_Click(object sender, EventArgs e)
        {
            var totalSales = context.Movies
                .Join(
                    context.BoxOffices,
                    m => m.MovieID,
                    b => b.MovieID,
                    (m, b) => new { m.Title, b.TotalSales }
                )
                .ToList();
            dataGridView.DataSource = totalSales;
        }

        private void buttonEmployeeCountInBuilding2w_Click(object sender, EventArgs e)
        {
            var employeeCount = context.Employees
                .Count(emp => emp.BuildingID == 2); // Assuming BuildingID 2 corresponds to Building 2w
            MessageBox.Show($"Number of employees in Building 2w: {employeeCount}");
        }

        private void buttonExtendExpiration_Click(object sender, EventArgs e)
        {
            if (accountBalance >= 5)
            {
                accountBalance -= 5;
                expirationDate = expirationDate?.AddMonths(1);

                var user = context.Users.FirstOrDefault(u => u.Username == "currentUsername" && u.Password == "currentPassword");
                if (user != null)
                {
                    user.AccountBalance = accountBalance;
                    user.ExpirationDate = expirationDate;
                    context.SaveChanges();

                    // Update labels
                    labelAccountBalance.Text = $"Account Balance: ${accountBalance}";
                    labelExpirationDate.Text = $"Expiration Date: {expirationDate?.ToString("d")}";

                    MessageBox.Show("Expiration date extended by 1 month.");
                }
            }
            else
            {
                MessageBox.Show("Not enough balance.");
            }
        }

        private void buttonSwitchToForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(isAdmin);
            form2.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
