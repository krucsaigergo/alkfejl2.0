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
            this.Hide(); // Az aktu�lis form elrejti mag�t
            Login lf = new Login(); // Az �j formot l�trehozzuk
            lf.Show(); // Az �j form megjelenik
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Az aktu�lis form elrejti mag�t
            Registration rf = new Registration(); // Az �j formot l�trehozzuk
            rf.Show(); // Az �j form megjelenik
        }
    }
}