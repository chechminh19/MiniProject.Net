using Service.Repository;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using Service.Models;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using Application = System.Windows.Forms.Application;

namespace Convenience_Store
{
    public partial class LoginForm : Form
    {
        RepoAccount RepoAccount = new RepoAccount();
        public LoginForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        public Boolean ValidateString(string s)
        {
            return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

        }
        public string formatString(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string user = txtUsername.Text.ToLower();
            string password = txtPassword.Text;



            if (ValidateString(txtUsername.Text) || Regex.IsMatch(formatString(txtUsername.Text), @"^[^a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a valid name", "Error");
                return;
            }
            if (ValidateString(txtPassword.Text) || txtPassword.Text.Length < 3)
            {
                MessageBox.Show("Please enter a password with at least 3 characters", "Error");
                return;
            }
            var check = RepoAccount.GetAll().Where(a => a.AccName.ToLower().Equals(user) && a.AccPass.Equals(password));
            if (check.Count() == 1)
            {
                var link = RepoAccount.GetAll().Where(a => a.AccName.ToLower().Equals(user));
                if (MessageBox.Show("Login success", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Hide();
                    // Truyền danh sách tài khoản cho form HomePage
                    Form homePage = new HomePage(link.ToList());
                    homePage.ShowDialog();
                }

                else
                {
                    return;
                }


            }
            else
            {
                MessageBox.Show("Login fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
