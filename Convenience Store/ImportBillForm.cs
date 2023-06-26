using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Service.Repository;
using Service.Models;
using System.Runtime.InteropServices;

namespace Convenience_Store
{
    public partial class ImportBillForm : Form
    {
        RepoImportBill repoBill = new RepoImportBill();
        RepoAccount repoAccount = new RepoAccount();
        List<ImportBill> list = new List<ImportBill>();
        private readonly Account _account;
        public static DataGridViewRow SelectedRow { get; set; }
        int index;
        public ImportBillForm(List<Account> accounts)
        {

            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            _account = accounts.FirstOrDefault();
            if (_account != null)
            {
                txtId.Text = _account.AccId.ToString();
                txtName.Text = _account.AccName;
                txtRole.Text = _account.AccRole.ToString();

            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnImport_Click(object sender, EventArgs e)
        {
            Form billPopup = new ImportPopup_Create(dgvImportBill, _account);
            billPopup.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            index = dgvImportBill.CurrentCell.RowIndex;
            SelectedRow = dgvImportBill.Rows[index];
            var currentBill = repoBill.GetAll()[dgvImportBill.CurrentCell.RowIndex];
            Form billPopup = new ImportPopup(dgvImportBill, index, SelectedRow, list, _account);
            billPopup.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            var link = repoAccount.GetAll().Where(a => a.AccId.Equals(_account.AccId));
            HomePage homePage = new HomePage(link.ToList());
            homePage.Show();
            this.Close();
        }

        private void ImportBill_Load(object sender, EventArgs e)
        {
            using (var context = new ConvenienceStoreContext())
            {
                var result = from ib in context.ImportBills
                             join p in context.Providers on ib.ProId equals p.txtProviderID
                             join m in context.Merchandises on ib.MerId equals m.MerId
                             select new
                             {
                                 Bill_ID = ib.ImId,
                                 Bill_Name = ib.ImName,
                                 Bill_Date = ib.ImDate,
                                 Provider_ID = ib.ProId,
                                 Provider_Name = p.ProName,
                                 Provider_Phone = p.ProPhone,
                                 Merchandise_ID = m.MerId,
                                 Merchandise_Name = m.MerName,
                                 Price = m.MerPrice,
                                 Quantity = m.MerQuantity,
                                 Unit = m.MerUnit,
                                 Total = (m.MerPrice * m.MerQuantity)
                             };
                dgvImportBill.DataSource = new BindingSource() { DataSource = result.ToList() };

            }
        }

        private void refresh()
        {
            using (var context = new ConvenienceStoreContext())
            {
                var result = from ib in context.ImportBills
                             join p in context.Providers on ib.ProId equals p.txtProviderID
                             join m in context.Merchandises on ib.MerId equals m.MerId
                             select new
                             {
                                 Bill_ID = ib.ImId,
                                 Bill_Name = ib.ImName,
                                 Bill_Date = ib.ImDate,
                                 Provider_ID = ib.ProId,
                                 Provider_Name = p.ProName,
                                 Provider_Phone = p.ProPhone,
                                 Merchandise_ID = m.MerId,
                                 Merchandise_Name = m.MerName,
                                 Price = m.MerPrice,
                                 Quantity = m.MerQuantity,
                                 Unit = m.MerUnit,
                                 Total = (m.MerPrice * m.MerQuantity)
                             };
                dgvImportBill.DataSource = new BindingSource() { DataSource = result.ToList() };
            }
        }


        private void dgvImportBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentBill = repoBill.GetAll()[dgvImportBill.CurrentCell.RowIndex];
            list.Add(currentBill);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this bill?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var currentBill = repoBill.GetAll()[dgvImportBill.CurrentCell.RowIndex];
                using (var context = new ConvenienceStoreContext())
                {
                    var bill = context.ImportBills.Find(currentBill.ImId);
                    if (bill != null)
                    {
                        context.ImportBills.Remove(bill);
                        context.SaveChanges();
                        refresh();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (String.IsNullOrEmpty(search))
                search = "";
            using (var context = new ConvenienceStoreContext())
            {
                var result = from ib in context.ImportBills
                             join p in context.Providers on ib.ProId equals p.txtProviderID
                             join m in context.Merchandises on ib.MerId equals m.MerId
                             where m.MerName.Contains(search)
                             select new
                             {
                                 Bill_ID = ib.ImId,
                                 Bill_Name = ib.ImName,
                                 Bill_Date = ib.ImDate,
                                 Provider_ID = ib.ProId,
                                 Provider_Name = p.ProName,
                                 Provider_Phone = p.ProPhone,
                                 Merchandise_ID = m.MerId,
                                 Merchandise_Name = m.MerName,
                                 Price = m.MerPrice,
                                 Quantity = m.MerQuantity,
                                 Unit = m.MerUnit,
                                 Total = (m.MerPrice * m.MerQuantity)
                             };
                dgvImportBill.DataSource = new BindingSource() { DataSource = result.ToList() };
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The Bill is being exported. Thank You !", "Notification", MessageBoxButtons.OK);
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

