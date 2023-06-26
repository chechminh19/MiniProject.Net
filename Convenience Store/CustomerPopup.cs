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
    public partial class CustomerPopup : Form
    {
        private DataGridView cdgvCustomer;
        private int cindex;
        private DataGridViewRow selectedRow;
        private List<Customer> clist;
        RepoCustomer customer = new RepoCustomer();

        public CustomerPopup(DataGridView dgvCustomer, int index, DataGridViewRow SelectedRow, List<Customer> list)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.cdgvCustomer = dgvCustomer;
            this.cindex = index;
            this.selectedRow = selectedRow;
            this.clist = list;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void CustomerPopup_Load(object sender, EventArgs e)
        {
            txtCusId.Text = CustomerForm.SelectedRow.Cells[0].Value.ToString();
            txtCusName.Text = CustomerForm.SelectedRow.Cells[1].Value.ToString();
            txtcusGender.Text = CustomerForm.SelectedRow.Cells[2].Value.ToString();
            dtpDOB.Value = (DateTime)CustomerForm.SelectedRow.Cells[3].Value;
            txtCusPhone.Text = CustomerForm.SelectedRow.Cells[4].Value.ToString();

        }
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

            cdgvCustomer.DataSource = new BindingSource() { DataSource = listAllStaff };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save button clicked!");
            int cusId = int.Parse(txtCusId.Text);
            string cusName = txtCusName.Text;
            int cusGender = int.Parse(txtcusGender.Text);
            DateTime cusDob = dtpDOB.Value;
            string cusPhone = txtCusPhone.Text;

            // find the customer object to be updated from the list
            Customer customerToUpdate = customer.GetAll().FirstOrDefault(c => c.CusId == cusId);

            if (customerToUpdate != null)
            {
                // update the customer object with new values
                customerToUpdate.CusName = cusName;
                customerToUpdate.CusGender = cusGender;
                customerToUpdate.CusDob = cusDob;
                customerToUpdate.CusPhone = cusPhone;

                // update the customer object in the database
                customer.Update(customerToUpdate);

                // refresh the data grid view with updated data
                refreshData();

                // close the pop-up form
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Customer ID. Please select a valid customer.");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
