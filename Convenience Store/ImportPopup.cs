using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Convenience_Store
{
    public partial class ImportPopup : Form
    {
        private int f1index;
        private DataGridViewRow f1selectedRow;
        private DataGridView f1dgvImportBill;
        List<ImportBill> f1list;
        private readonly Account _account;



        public ImportPopup(DataGridView dgvImportBill, int index, DataGridViewRow SelectedRow, List<ImportBill> list, Account _account)
        {
            InitializeComponent();
            this.f1index = index;
            this.f1selectedRow = SelectedRow;
            this.f1dgvImportBill = dgvImportBill;
            this.f1list = list;
            if (_account != null)
            {
                txtAccId.Text = _account.AccId.ToString();
                txtAccName.Text = _account.AccName;
                txtRoleId.Text = _account.AccRole.ToString();

            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ImportPopup_Load(object sender, EventArgs e)
        {
            txtBillId.Text = ImportBillForm.SelectedRow.Cells[0].Value.ToString();
            txtBillName.Text = ImportBillForm.SelectedRow.Cells[1].Value.ToString();
            dtpBillDate.Value = (DateTime)ImportBillForm.SelectedRow.Cells[2].Value;
            txtProviderID.Text = ImportBillForm.SelectedRow.Cells[3].Value.ToString();
            txtProName.Text = ImportBillForm.SelectedRow.Cells[4].Value.ToString();
            txtProviderPhone.Text = ImportBillForm.SelectedRow.Cells[5].Value.ToString();
            txtMerId.Text = ImportBillForm.SelectedRow.Cells[6].Value.ToString();
            txtMerName.Text = ImportBillForm.SelectedRow.Cells[7].Value.ToString();
            txtMerPrice.Text = ImportBillForm.SelectedRow.Cells[8].Value.ToString();
            txtMerQuantity.Text = ImportBillForm.SelectedRow.Cells[9].Value.ToString();
            cbbMerUnit.SelectedValue = ImportBillForm.SelectedRow.Cells[10].Value.ToString();
            txtBillTotal.Text = ImportBillForm.SelectedRow.Cells[11].Value.ToString();
            cbbMerUnit.Items.AddRange(new object[] { "Pack", "Box", "Pcs", "Dozen", "Each" });
            cbbMerUnit.SelectedIndex = 0;

        }

        private void refresh()
        {
            using (var context1 = new ConvenienceStoreContext())
            {
                var updated = from ib in context1.ImportBills
                              join p in context1.Providers on ib.ProId equals p.ProId
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ConvenienceStoreContext())
                {
                    int billId = int.Parse(txtBillId.Text);
                    int MerId = int.Parse(txtMerId.Text);
                    int ProId = int.Parse(txtProviderID.Text);
                    string MerUnit = cbbMerUnit.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(MerUnit)) throw new Exception("Merchandise Unit can not be empty!");
                    if (MerId < 0 || MerId.ToString().Length == 0) throw new Exception("Merchandise ID must greater than 0 and can not be null");
                    string imName = txtBillName.Text;
                    if (string.IsNullOrEmpty(imName)) throw new Exception("Bill Name can not be empty!");
                    DateTime billDate = dtpBillDate.Value;
                    string ProName = txtProName.Text;
                    if (string.IsNullOrEmpty(ProName)) throw new Exception("Provider Name can not be empty!");
                    string ProPhone = txtProviderPhone.Text;
                    if (string.IsNullOrEmpty(ProPhone)) throw new Exception("Provider Phone can not be empty!");
                    string merName = txtMerName.Text;
                    if (string.IsNullOrEmpty(merName)) throw new Exception("Merchandise Name can not be empty!");
                    double merPrice = double.Parse(txtMerPrice.Text);
                    if (merPrice < 0 || merPrice.ToString().Length == 0) throw new Exception("Merchandise Price can not be smaller than 0 or empty!");
                    int merQuantity = int.Parse(txtMerQuantity.Text);
                    if (merQuantity <= 0 || merQuantity.ToString().Length == 0) throw new Exception("Merchandise Quanity can not be smaller than 0 or empty!");

                    var result = from ib in context.ImportBills
                                 join p in context.Providers on ib.ProId equals p.ProId
                                 join m in context.Merchandises on ib.MerId equals m.MerId
                                 where ib.ImId == billId
                                 select new
                                 {
                                     T1 = ib,
                                     T2 = p,
                                     T3 = m,
                                 };
                    foreach (var item in result)
                    {
                        item.T1.MerId = MerId;
                        item.T1.ImName = imName;
                        item.T1.ImDate = billDate;
                        item.T2.ProName = ProName;
                        /*item.T2.ProId = ProId;*/
                        item.T2.ProPhone = ProPhone;
                        /*item.T3.MerId = MerId;*/
                        item.T3.MerName = merName;
                        item.T3.MerPrice = merPrice;
                        item.T3.MerUnit = MerUnit;
                        item.T3.MerQuantity = merQuantity;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Updated successfully!", "Notification", MessageBoxButtons.OK);
                    refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("Error: " + error, "Notification", MessageBoxButtons.OK);
            }

        }

        private void txtBillTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void cbbMerUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtMerQuantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void txtMerName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMerPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMerId_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void dtpBillDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtProviderPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtProName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBillName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtBillId_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtAccId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAccName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRoleId_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }
    }

}

