using Convenience_Store;
using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Convenience_Store
{
    public partial class HomePage : Form
    {



        private List<Account> Accounts;

        public HomePage(List<Account> accounts)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            this.Accounts = accounts;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HomePage_Load(object sender, EventArgs e)
        {
            //ẩn nút cho từng role
            var check = Accounts.FirstOrDefault(a => a.AccRole != 0); ;
            if (check != null)
            {
                btnMerchandiseorder.Visible = false;
                btnStaffManage.Visible = false;
            }
            else
            {
                btnMerchandiseorder.Visible = true;
                btnStaffManage.Visible = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form order = new Order(Accounts);
            order.ShowDialog();
            this.Close();
        }

        private void btnStaffManage_Click(object sender, EventArgs e)
        {
            Form importbill = new StaffManageForm(Accounts);
            importbill.ShowDialog();
            this.Close();
        }
        private void btnMerchandiseorder_Click(object sender, EventArgs e)
        {
            Form merchandiseorder = new MerchandiseOrder(Accounts);
            merchandiseorder.ShowDialog();
            this.Close();


        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            Form ebf = new ExportBillForm(Accounts);
            ebf.ShowDialog();
            this.Close();
        }

        private void btnImportBill_Click(object sender, EventArgs e)
        {
            Form importbill = new ImportBillForm(Accounts);
            importbill.ShowDialog();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form customer = new CustomerForm(Accounts);
            customer.ShowDialog();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form setting = new AccountSetting(Accounts);
            setting.ShowDialog();
            this.Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
