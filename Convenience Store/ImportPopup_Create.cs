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
using System.Xml.Linq;

namespace Convenience_Store
{
    public partial class ImportPopup_Create : Form
    {
        private DataGridView f1dgvImportBill;
        private readonly Account _account;

        public ImportPopup_Create(DataGridView dgvImportBill, Account _account)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            this.f1dgvImportBill = dgvImportBill;
            if (_account != null)
            {
                txtAccId.Text = _account.AccId.ToString();
                txtAccName.Text = _account.AccName;
                txtRoleId.Text = _account.AccRole.ToString();

            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var context = new ConvenienceStoreContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        string merUnit = cbbMerUnit.SelectedItem.ToString();
                        if (string.IsNullOrEmpty(merUnit)) throw new Exception("Merchandise Unit can not be empty!");
                        string imName = txtBillName.Text;
                        if (string.IsNullOrEmpty(imName)) throw new Exception("Bill Name can not be empty!");
                        DateTime billDate = dtpBillDate.Value;
                        string ProName = txtProName.Text;
                        if (string.IsNullOrEmpty(ProName)) throw new Exception("Provider Name can not be empty!");
                        string ProPhone = txtProviderPhone.Text;
                        if (string.IsNullOrEmpty(ProPhone) || ProPhone.Length > 11 || ProPhone.Length < 10) throw new Exception("Provider Phone can not be empty and smaller than 10 units!");
                        string merName = txtMerName.Text;
                        if (string.IsNullOrEmpty(merName)) throw new Exception("Merchandise Name can not be empty!");
                        double merPrice = double.Parse(txtMerPrice.Text);
                        if (merPrice < 0 || merPrice.ToString().Length == 0) throw new Exception("Merchandise Price can not be smaller than 0 or empty!");
                        int merQuantity = int.Parse(txtMerQuantity.Text);
                        if (merQuantity <= 0 || merQuantity.ToString().Length == 0) throw new Exception("Merchandise Quanity can not be smaller than 0 or empty!");
                        string merDes = txtMerDescrip.Text;
                        if (string.IsNullOrEmpty(merDes)) throw new Exception("Merchandise description can not be empty!!!");
                        var newMer = new Merchandise()
                        {
                            MerName = txtMerName.Text,
                            MerDescription = txtMerDescrip.Text,
                            MerPrice = Double.Parse(txtMerPrice.Text),
                            MerQuantity = int.Parse(txtMerQuantity.Text),
                            MerUnit = cbbMerUnit.SelectedItem.ToString(),

                        };
                        context.Merchandises.Add(newMer);
                        context.SaveChanges();

                        var newPro = new Provider()
                        {
                            ProName = txtProName.Text,
                            ProPhone = txtProviderPhone.Text,
                            ProGender = 1,
                            ProDob = DateTime.Now,
                        };
                        context.Providers.Add(newPro);
                        context.SaveChanges();

                        var newBill = new ImportBill()
                        {
                            ImName = txtBillName.Text,
                            ImDate = dtpBillDate.Value,
                            MerId = newMer.MerId,
                            ImProvider = newPro.ProName,
                            ProId = newPro.txtProviderID,

                        };
                        context.ImportBills.Add(newBill);
                        context.SaveChanges();
                        transaction.Commit();
                        MessageBox.Show("Created successfully!", "Notification", MessageBoxButtons.OK);
                        loadData();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        // Roll back the transaction if there is an exception
                        transaction.Rollback();
                        string error = ex.Message;
                        MessageBox.Show("Error: " + error, "Notification", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ImportPopup_Create_Load(object sender, EventArgs e)
        {

            txtBillId.Text = "Auto Fill";
            txtProviderID.Text = "Auto Fill";
            cbbMerUnit.Items.AddRange(new object[] { "Pack", "Box", "Pcs", "Dozen", "Each" });
            cbbMerUnit.SelectedIndex = 0;
        }

        public void refresh()
        {
            txtBillName.Clear();
            txtProName.Clear();
            txtProviderPhone.Clear();
            txtMerPrice.Clear();
            txtMerName.Clear();
            txtProName.Clear();
            txtMerQuantity.Clear();
            _ = cbbMerUnit.SelectedIndex == 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void loadData()
        {
            using (var context1 = new ConvenienceStoreContext())
            {
                var updated = from ib in context1.ImportBills
                              join p in context1.Providers on ib.ProId equals p.txtProviderID
                              join m in context1.Merchandises on ib.MerId equals m.MerId
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
                f1dgvImportBill.DataSource = new BindingSource() { DataSource = updated.ToList() };
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
