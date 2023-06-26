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

namespace Convenience_Store
{
    public partial class ExportBillForm : Form
    {
        List<Account> accounts = null;
        int index = -1;
        RepoExportBill reb = new RepoExportBill();
        private readonly Account _account;
        RepoAccount repoAccount = new RepoAccount();
        public ExportBillForm(List<Account> accounts)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            if (accounts == null || accounts.Count != 1 || accounts.FirstOrDefault() == null)
            {
                accounts = null;
                LoginForm form = new LoginForm();
                this.Close();
                return;
            }
            this.accounts = accounts;
            _account = accounts.FirstOrDefault();
            txtAccId.Text = _account.AccId.ToString();
            txtAccName.Text = _account.AccName;
            txtAccRole.Text = _account.AccRole.ToString();
            loadGrid();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void loadGrid()
        {
            using (var context = new ConvenienceStoreContext())
            {
                var result = from eb in context.ExportBills
                             join c in context.Customers on eb.CusId equals c.CusId
                             select new
                             {
                                 Export_Bill_ID = eb.ExId,
                                 Manager_ID = eb.AccId,
                                 Manager_Name = eb.ExManager,
                                 Export_Bill_Date = eb.ExDate,
                                 Customer_ID = eb.CusId,
                                 Customer_Name = c.CusName,
                                 Customer_Gender = (c.CusGender == 1) ? "Male" : "Female",
                                 Customer_DOB = c.CusDob,
                                 Customer_Phone = c.CusPhone
                             };
                dgvExportBill.DataSource = new BindingSource() { DataSource = result.ToList() };

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                if (MessageBox.Show("Are you sure about deleting export bill #" + index + " ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var check = reb.GetAll().Where(a => a.ExId == index).ToList();
                    if (check.Count == 1)
                    {
                        var ex1 = check.FirstOrDefault();
                        reb.Delete(ex1);
                    }
                    index = -1;
                }
            }
            loadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = AccountSetting.formatString(txtSearch.Text.ToLower());
            if (!String.IsNullOrEmpty(search))
            {
                using (var context = new ConvenienceStoreContext())
                {
                    var result = from eb in context.ExportBills
                                 join c in context.Customers on eb.CusId equals c.CusId
                                 where eb.ExManager.ToLower().Contains(search)
                                 select new
                                 {
                                     Export_Bill_ID = eb.ExId,
                                     Manager_ID = eb.AccId,
                                     Manager_Name = eb.ExManager,
                                     Export_Bill_Date = eb.ExDate,
                                     Customer_ID = eb.CusId,
                                     Customer_Name = c.CusName,
                                     Customer_Gender = (c.CusGender == 1) ? "Male" : "Female",
                                     Customer_DOB = c.CusDob,
                                     Customer_Phone = c.CusPhone
                                 };
                    dgvExportBill.DataSource = new BindingSource() { DataSource = result.ToList() };
                }
            }

        }



        private void dgvExportBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e != null && e.RowIndex >= 0)
                index = (int)dgvExportBill.Rows[e.RowIndex].Cells[0].Value;
            if (dgvExportBill.CurrentCell != null && dgvExportBill.CurrentCell.RowIndex >= 0)
                index = (int)dgvExportBill.Rows[dgvExportBill.CurrentCell.RowIndex].Cells[0].Value;

            if (index != -1)
            {
                using (var context = new ConvenienceStoreContext())
                {
                    var find = from eb in context.ExportBills
                               join c in context.Customers on eb.CusId equals c.CusId
                               where eb.CusId == index
                               select new
                               {
                                   c.CusId,
                                   c.CusName,
                                   c.CusGender,
                                   c.CusDob,
                                   c.CusPhone
                               };
                    if (find != null && find.Count() == 1)
                    {
                        var numberone = find.FirstOrDefault();
                        txtCusId.Text = numberone.CusId.ToString();
                        txtCusName.Text = numberone.CusName;
                        txtCusGender.Text = (numberone.CusGender == 1) ? "Male" : "Female";
                        dtpCusDOB.Value = numberone.CusDob;
                        txtCusPhone.Text = numberone.CusPhone;

                    }
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (accounts == null || accounts.Count != 1 || accounts.FirstOrDefault() == null)
            {
                accounts = null;
                LoginForm form = new LoginForm();
                this.Close();
                return;
            }
            if (index != -1)
            {
                ExportPopup ep = new ExportPopup(accounts, index);
                ep.ShowDialog();
                loadGrid();
                return;
            }
            else
            {
                MessageBox.Show("Please properly choose an export bill to edit.", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            var link = repoAccount.GetAll().Where(a => a.AccId.Equals(_account.AccId));
            HomePage homePage = new HomePage(link.ToList());
            homePage.Show();
            this.Close();
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
