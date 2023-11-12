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
    public partial class UpdatePassword : Form
    {
        private Vault _vaultToUpdate;
        Core.Models.User loggedUser;
        private readonly PasswordManagerDbContext _context;
        public UpdatePassword(Core.Models.User loggedUser, Vault vaultToUpdate)
        {
            _context = Program.GetDbContext();
            this.loggedUser = loggedUser;
            _vaultToUpdate = vaultToUpdate;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Encrypt the new password
            EncryptedType encryptedData = new EncryptedType(loggedUser.Email, textBoxPassword.Text);
            EncryptedType encryptedResult = encryptedData.Encrypt();

            // Update the Vault object

            _vaultToUpdate.Username = textBoxUsername.Text;
            _vaultToUpdate.Website = textBoxWebsite.Text;
            _vaultToUpdate.Password = encryptedResult.Secret;

            // Save changes to the database
            _context.Vault.Update(_vaultToUpdate);
            _context.SaveChanges();

            this.Close();
        }

        private void button2_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = _vaultToUpdate.Username;
            textBoxWebsite.Text = _vaultToUpdate.Website;
        }

        
    }
}
