using Microsoft.Identity.Client;
using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Convenience_Store
{

    public partial class AccountSetting : Form
    {
        private readonly Account _account;
        private RepoAccount _Account;
        private Account currAccount; //Khai báo currAccount là một trường của lớp AccountSetting
        public List<Account> Accounts { get; set; }


        public AccountSetting(List<Account> accounts)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            _Account = new RepoAccount();
            _account = accounts.FirstOrDefault(); // Get the first account in the list
            if (_account != null)
            {
                txtId.Text = _account.AccId.ToString();
                txtName2.Text = _account.AccName;
                txtRole.Text = _account.AccRole.ToString();
                txtId1.Text = _account.AccId.ToString();
                txtRole1.Text = _account.AccRole.ToString();
                var accRoles = _Account.GetAll().Select(a => a.AccRole).Distinct(); // Get AccRole values from the accounts list

                /*cbRole.DataSource = accRoles.ToList(); // Bind the accRoles list to the ComboBox
                cbRole.Refresh(); // Refresh the ComboBox*/

                // Populate the text boxes with the account data
                txtName1.Text = _account.AccName;
                txtPassword.Text = _account.AccPass;
                dtpDOB.Value = (DateTime)_account.AccDob;
                txtPhone.Text = _account.AccPhone;
                //cbRole.Text = _account.AccRole.ToString(); // Set the ComboBox value to the account's AccRole
                txtAddress.Text = _account.AccAddress;
            }
            else
            {
                MessageBox.Show("Please enter a valid name", "Error");
                return;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        public static Boolean ValidateString(string s)
        {
            return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

        }
        public static string formatString(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Find the account with matching ID
            var currAccount = _Account.GetAll().FirstOrDefault(a => a.AccId == _account.AccId);
            if (ValidateString(txtName1.Text) || Regex.IsMatch(formatString(txtName1.Text), @"^[^a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a valid name", "Error");
                return;
            }
            if (ValidateString(txtPassword.Text) || txtPassword.Text.Length < 3)
            {
                MessageBox.Show("Please enter a password with at least 3 characters", "Error");
                return;
            }
            if (dtpDOB.Value == null || dtpDOB.Value > DateTime.Today)
            {
                MessageBox.Show("Please enter a valid date of birth", "Error");
                return;
            }
            if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$") || ValidateString(txtPhone.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number", "Error");
                return;
            }

            if (currAccount != null)
            {
                // Update the account with the new values from the text boxes and ComboBox
                currAccount.AccId = int.Parse(txtId1.Text);
                currAccount.AccName = formatString(txtName1.Text);
                currAccount.AccPass = txtPassword.Text;
                currAccount.AccDob = dtpDOB.Value;
                currAccount.AccPhone = txtPhone.Text;
                currAccount.AccRole = int.Parse(txtRole1.Text);
                currAccount.AccAddress = txtAddress.Text;

                // Save the updated account to the database
                _Account.Update(currAccount);

                // Show a message box indicating that the account was updated
                MessageBox.Show("Account updated successfully", "Success");
                return;
            }
            else
            {
                // Account with matching ID not found, display an error message
                MessageBox.Show("Account not found", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            var link = _Account.GetAll().Where(a => a.AccId.Equals(_account.AccId));
            HomePage homePage = new HomePage(link.ToList());
            homePage.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Close the current form
                this.Close();

                // Create a new instance of the LoginForm and display it
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                return;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
