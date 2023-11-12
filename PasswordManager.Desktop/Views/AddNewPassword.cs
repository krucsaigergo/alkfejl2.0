using Microsoft.VisualBasic.ApplicationServices;
using passwordManager;
using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Desktop.Views
{
    public partial class AddNewPassword : Form
    {
        Core.Models.User loggedUser;
        private readonly PasswordManagerDbContext _context;
        public AddNewPassword(Core.Models.User loggedUser)
        {
            _context = Program.GetDbContext();
            this.loggedUser = loggedUser;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EncryptedType encryptedData = new EncryptedType(loggedUser.Email, textBox_pw.Text);
            EncryptedType encryptedResult = encryptedData.Encrypt();

            var newVault = new Vault
            {
                Username = textBox_username.Text,
                Password = encryptedResult.Secret,
                Website = textBox_website.Text,
                UserId = loggedUser.Id,
            };

            _context.Vault.Add(newVault);
            _context.SaveChanges();

            Dashboard dashboard = new Dashboard(loggedUser);
            dashboard.InitializeDataGridView();

            this.Close();
        }

        private void AddNewPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
