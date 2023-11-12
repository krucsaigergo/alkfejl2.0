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
    public partial class Dashboard : Form
    {
        private PasswordManagerDbContext _context;
        Core.Models.User loggedUser;


        public Dashboard(Core.Models.User newUser)
        {
            _context = Program.GetDbContext();
            this.loggedUser = newUser;
            InitializeComponent();

            InitializeDataGridView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddNewPassword anpw = new AddNewPassword(loggedUser);
            anpw.FormClosed += (s, args) => RefreshDataGridView();
            anpw.ShowDialog(); // Changed from Show() to ShowDialog()
        }

        private void addVaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPassword anpw = new AddNewPassword(loggedUser);
            anpw.FormClosed += (s, args) => RefreshDataGridView();
            anpw.Show();

        }

        public void InitializeDataGridView()
        {
            // Állítsd be a DataGridView oszlopait
            dataGridViewVault.Columns.Add("Username", "Username");
            dataGridViewVault.Columns.Add("Password", "Password");
            dataGridViewVault.Columns.Add("Website", "Website");

            // Töltsd fel a DataGridView-t a Vault adataival
            List<Vault> vaultList = _context.Vault.Where(v => v.User == loggedUser)
                                                  .OrderBy(v => v.Website) // Sorting added here
                                                  .ToList();

            foreach (var vault in vaultList)
            {
                EncryptedType encryptedData = new EncryptedType(loggedUser.Email, vault.Password);
                EncryptedType decryptedResult = encryptedData.Decrypt();

                dataGridViewVault.Rows.Add(vault.Username, decryptedResult.Secret, vault.Website);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewVault.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int selectedIndex = dataGridViewVault.SelectedRows[0].Index;

                // Assuming the first cell contains the username
                string selectedUsername = dataGridViewVault.SelectedRows[0].Cells[0].Value.ToString();

                // Find the Vault instance in the database
                Vault vaultToDelete = _context.Vault.FirstOrDefault(v => v.Username == selectedUsername && v.User == loggedUser);

                if (vaultToDelete != null)
                {
                    // Delete the Vault instance from the database
                    _context.Vault.Remove(vaultToDelete);
                    _context.SaveChanges();

                    // Remove the row from DataGridView
                    dataGridViewVault.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewVault.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int selectedIndex = dataGridViewVault.SelectedRows[0].Index;

                // Assuming the first cell contains the username
                string selectedUsername = dataGridViewVault.SelectedRows[0].Cells[0].Value.ToString();

                // Find the Vault instance in the database
                Vault vaultToUpdate = _context.Vault.FirstOrDefault(v => v.Username == selectedUsername && v.User == loggedUser);

                if (vaultToUpdate != null)
                {
                    UpdatePassword anpw = new UpdatePassword(loggedUser, vaultToUpdate);
                    anpw.FormClosed += (s, args) => RefreshDataGridView();
                    anpw.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }

        public void RefreshDataGridView()
        {

            try
            {
                // Clear existing data
                dataGridViewVault.Rows.Clear();
                _context.Dispose(); // Dispose the old context
                _context = Program.GetDbContext(); // Create a new context

                // Reload data from the database
                List<Vault> vaultList = _context.Vault.Where(v => v.User == loggedUser)
                                                      .OrderBy(v => v.Website) // Sorting added here
                                                      .ToList();
                foreach (var vault in vaultList)
                {
                    EncryptedType encryptedData = new EncryptedType(loggedUser.Email, vault.Password);
                    EncryptedType decryptedResult = encryptedData.Decrypt();

                    dataGridViewVault.Rows.Add(vault.Username, decryptedResult.Secret, vault.Website);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void dataGridViewVault_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
