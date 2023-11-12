using passwordManager;
using PasswordManager.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordManager.Desktop.Views
{
    public partial class Login : Form
    {
        private readonly PasswordManagerDbContext _context;
        public Login()
        {
            _context = Program.GetDbContext();
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm(); 
            mf.Show(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            

            var user = _context.User.FirstOrDefault(u => u.Username == username);


            EncryptedType encryptedData = new EncryptedType(user.Email, user.Password);
            EncryptedType decryptedResult = encryptedData.Decrypt();


            string pw = textBox_pw.Text;

            if (user != null)
            {

                // Ellenőrizd a jelszót (ez csak egy példa, itt valódi jelszóellenőrzést kell végrehajtani)
                if (decryptedResult.Secret == pw)
                {
                    // Sikeres bejelentkezés
                    this.Hide();
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Hibás jelszó.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Felhasználó nem található.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
