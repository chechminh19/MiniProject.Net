using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store
{
    public partial class ExportPopup : Form
    {
        RepoAccount ra = new RepoAccount();
        List<Account> accounts = null;
        public ExportPopup(List<Account> accounts, int eid)
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
            if (eid == null && eid <= 0)
            {
                ExportBillForm ebf = new ExportBillForm(accounts);
                ebf.Show();
                this.Close();
                return;
            }
            this.accounts = accounts;
            var _account = accounts.FirstOrDefault();
            txtAccId.Text = _account.AccId.ToString();
            txtAccName.Text = _account.AccName;
            txtAccRole.Text = _account.AccRole.ToString();
            loadPopup(eid);


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void loadPopup(int eid)
        {
            try
            {

                using (var context = new ConvenienceStoreContext())
                {
                    var result = from eb in context.ExportBills
                                 join c in context.Customers on eb.CusId equals c.CusId
                                 where eb.ExId == eid
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
                    if (result != null && result.Count() == 1 && result.FirstOrDefault() != null)
                    {
                        var ebr = result.FirstOrDefault();
                        txtEBID.Text = ebr.Customer_ID.ToString();
                        txtMngName.Text = ebr.Manager_Name;
                        txtCusName.Text = ebr.Customer_Name;
                        txtCusPhone.Text = ebr.Customer_Phone;
                        dtpEBDate.Value = ebr.Export_Bill_Date;
                        dtpCusDOB.Value = ebr.Customer_DOB;
                        if (cbbCusGender.Items.Count == 0)
                        {
                            cbbCusGender.Items.Add("Male");
                            cbbCusGender.Items.Add("Female");
                        }
                        if (ebr.Customer_Gender.Equals("Male")) { cbbCusGender.SelectedItem = "Male"; }
                        else cbbCusGender.SelectedItem = "Female";
                        loadCustomerCBB(ebr.Customer_ID);
                        loadManagerCBB(ebr.Manager_ID);


                    }
                }
            }
            catch (Exception excep)
            {

            }
        }

        private void loadCustomerCBB(int cid)
        {
            using (var context1 = new ConvenienceStoreContext())
            {
                var result1 = from c in context1.Customers
                              select new
                              {
                                  c.CusId
                              };
                if (result1.Any() && result1.FirstOrDefault() != null)
                {
                    var a = result1.ToList();
                    for (int i = 0; i < a.Count(); i++)
                    {
                        cbbCusID.Items.Add(a[i].CusId);
                        if (a[i].CusId == cid) cbbCusID.SelectedItem = a[i].CusId;
                    }
                }

            }
        }

        private void loadManagerCBB(int mid)
        {
            using (var context1 = new ConvenienceStoreContext())
            {
                var result1 = from a in context1.Accounts
                              select new
                              {
                                  a.AccId
                              };
                if (result1.Any() && result1.FirstOrDefault() != null)
                {
                    var b = result1.ToList();
                    for (int i = 0; i < b.Count(); i++)
                    {
                        cbbMngID.Items.Add(b[i].AccId);
                        if (b[i].AccId == mid) cbbMngID.SelectedItem = b[i].AccId;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ConvenienceStoreContext())
                {

                    if (AccountSetting.ValidateString(txtEBID.Text) || !Regex.IsMatch(Regex.Replace(txtEBID.Text, " ", ""), "^0*[1-9][0-9]*$"))
                        throw new Exception("The ID of the Export Bill is not valid!");

                    if (cbbCusID.SelectedItem == null && !Regex.IsMatch(cbbCusID.SelectedItem.ToString(), "^0*[1-9][0-9]*$"))
                        throw new Exception("There is no valid Customer ID!");

                    if (cbbMngID.SelectedItem == null && !Regex.IsMatch(cbbMngID.SelectedItem.ToString(), "^0*[1-9][0-9]*$"))
                        throw new Exception("There is no valid Manager ID!");

                    if (cbbCusGender.SelectedItem == null || Regex.IsMatch(cbbCusGender.SelectedItem.ToString(), @"^[^a-zA-Z]+$"))
                        throw new Exception("There is no valid selected item for the Customer's Gender!");


                    if (AccountSetting.ValidateString(txtCusName.Text) || Regex.IsMatch(AccountSetting.formatString(txtCusName.Text), @"^[^a-zA-Z]+$"))
                        throw new Exception("The Customer's Name is not valid!");


                    if (AccountSetting.ValidateString(txtMngName.Text) || Regex.IsMatch(AccountSetting.formatString(txtMngName.Text), @"^[^a-zA-Z]+$"))
                        throw new Exception("The Manager's Name is not valid!");


                    if (AccountSetting.ValidateString(txtCusPhone.Text) || !Regex.IsMatch(Regex.Replace(txtCusPhone.Text, " ", ""), @"^\d{10}$"))
                        throw new Exception("The Customer's Phone is not valid!");

                    if (dtpCusDOB.Value == null || dtpCusDOB.Value > DateTime.Today)
                        throw new Exception("The Customer's Date of Birth is not valid!");

                    if (dtpEBDate.Value == null || dtpEBDate.Value > DateTime.Today)
                        throw new Exception("The Date of the Export Bill is not valid!");
                    int eid = int.Parse(AccountSetting.formatString(txtEBID.Text));
                    int CusId = (int)cbbCusID.SelectedItem;
                    int MngId = (int)cbbMngID.SelectedItem;
                    int CusGender = cbbCusGender.SelectedItem.Equals("Male") ? 1 : 2;
                    String CusName = AccountSetting.formatString(txtCusName.Text);
                    String MngName = AccountSetting.formatString(txtMngName.Text);
                    String CusPhone = Regex.Replace(txtCusPhone.Text, " ", "");
                    DateTime CusDob = dtpCusDOB.Value;
                    DateTime eDate = dtpEBDate.Value;


                    var result = from eb in context.ExportBills
                                 join c in context.Customers on eb.CusId equals c.CusId
                                 where eb.ExId == eid

                                 select new
                                 {
                                     T1 = eb,
                                     T2 = c
                                 };
                    if (result != null && result.Count() == 1 && result.FirstOrDefault() != null)
                    {
                        var check = result.FirstOrDefault();
                        //check.T1.ExId = eid;
                        check.T1.AccId = MngId;
                        check.T1.ExDate = eDate;
                        check.T1.CusId = CusId;
                        //check.T1.ExManager = MngName;
                        check.T2.CusGender = CusGender;
                        check.T2.CusPhone = CusPhone;
                        check.T2.CusDob = CusDob;
                        check.T2.CusName = CusName;

                    }
                    context.SaveChanges();
                    MessageBox.Show("Updated successfully!", "Notification", MessageBoxButtons.OK);
                    loadPopup(eid);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("Error: " + error, "Notification", MessageBoxButtons.OK);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (accounts == null || accounts.Count != 1 || accounts.FirstOrDefault() == null)
            {
                accounts = null;
                LoginForm form = new LoginForm();
                this.Close();
                return;
            }
            /*Form ebf = new ExportBillForm(accounts);
            ebf.ShowDialog();*/
            this.Close();
        }

        private void cbbMngID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (e.Equals(null) || cbbMngID.SelectedItem == null && !Regex.IsMatch(cbbMngID.SelectedItem.ToString(), "^0*[1-9][0-9]*$"))
            {
                return;
            }
            ra = new RepoAccount();
            var accl = ra.GetById((int)cbbMngID.SelectedItem);
            if (accl != null)
            {
                txtMngName.Text = accl.AccName;
            }

        }

        private void cbbCusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (e.Equals(null) || cbbCusID.SelectedItem == null && !Regex.IsMatch(cbbCusID.SelectedItem.ToString(), "^0*[1-9][0-9]*$"))
            {
                return;
            }
            using (var context = new ConvenienceStoreContext())
            {
                var result = from a in context.Customers
                             where a.CusId == (int)cbbCusID.SelectedItem
                             select new
                             {
                                 a.CusName,
                                 a.CusGender,
                                 a.CusDob,
                                 a.CusPhone
                             };
                if (result != null && result.Count() == 1 && result.FirstOrDefault() != null)
                {
                    var a = result.FirstOrDefault();
                    txtCusName.Text = a.CusName;
                    if (a.CusGender == 1) cbbCusGender.SelectedItem = "Male";
                    else cbbCusGender.SelectedItem = "Female";
                    dtpCusDOB.Value = a.CusDob;
                    txtCusPhone.Text = a.CusPhone;
                }
            }
        }

        private void cbbCusGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
