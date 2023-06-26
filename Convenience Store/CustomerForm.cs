using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class CustomerForm : Form
    {
        int indexRow;
        int index;
        private readonly Account _account;
        RepoAccount repoAccount = new RepoAccount();
        RepoCustomer customer = new RepoCustomer();
        List<Customer> list = new List<Customer>();
        public static DataGridViewRow SelectedRow { get; set; }
        public CustomerForm(List<Account> _accounts)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            _account = _accounts.FirstOrDefault();
            if (_account != null)
            {
                txtId.Text = _account.AccId.ToString();
                txtName.Text = _account.AccName.ToString();
                txtRole.Text = _account.AccRole.ToString();
            }
            var listAllStaff = customer.GetAll()
             .Select(x => new
             {
                 x.CusId,
                 x.CusName,
                 x.CusGender,
                 x.CusDob,
                 x.CusPhone

             })
             .ToList();

            dgvCustomer.DataSource = new BindingSource() { DataSource = listAllStaff };
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void refreshData()
        {
            var listAllStaff = customer.GetAll()
           .Select(x => new
           {
               x.CusId,
               x.CusName,
               x.CusGender,
               x.CusDob,
               x.CusPhone
           })
           .ToList();

            dgvCustomer.DataSource = new BindingSource() { DataSource = listAllStaff };
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

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var listAllStaff = customer.GetAll()
        .Select(x => new
        {
            x.CusId,
            x.CusName,
            x.CusGender,
            x.CusDob,
            x.CusPhone
        })
        .ToList();
            dgvCustomer.DataSource = new BindingSource() { DataSource = listAllStaff };
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var customers = customer.GetAll()[dgvCustomer.CurrentCell.RowIndex];
            list.Add(customers);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this customer?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selectedCustomer = customer.GetAll()[dgvCustomer.CurrentCell.RowIndex];
                    customer.Delete(selectedCustomer);
                    refreshData();

                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"An error occurred while updating the entries: {ex.InnerException?.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            index = dgvCustomer.CurrentCell.RowIndex;
            SelectedRow = dgvCustomer.Rows[index];
            var currentBill = customer.GetAll()[dgvCustomer.CurrentCell.RowIndex];
            Form billPopup = new CustomerPopup(dgvCustomer, index, SelectedRow, list);
            billPopup.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form createcustomer = new CreateCustomer(dgvCustomer, _account);
            createcustomer.ShowDialog();
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
