using PasswordManager.Desktop.Views;

namespace PasswordManager.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Az aktuális form elrejti magát
            Login lf = new Login(); // Az új formot létrehozzuk
            lf.Show(); // Az új form megjelenik
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Az aktuális form elrejti magát
            Registration rf = new Registration(); // Az új formot létrehozzuk
            rf.Show(); // Az új form megjelenik
        }
    }
}