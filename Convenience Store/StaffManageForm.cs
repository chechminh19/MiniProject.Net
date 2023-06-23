using Service.Models;
using Service.Repository;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Convenience_Store
{
    public partial class StaffManageForm : Form
    {
        int indexRow;
        RepoAccount _context = new RepoAccount();

        private readonly Account _account;
        RepoAccount repoAccount = new RepoAccount();
        public StaffManageForm(List<Account> accounts)
        {
            InitializeComponent();
            _account = accounts.FirstOrDefault();


            var listAllStaff = _context.GetAll()
        .Select(x => new
        {
            x.AccId,
            x.AccName,
            x.AccPass,
            x.AccCreatedTime,
            x.AccDob,
            x.AccPhone,
            x.AccRole,
            x.AccAddress
        })
        .Where(x => x.AccRole == 1)
        .ToList();

            AllStaffDataGridView.DataSource = new BindingSource() { DataSource = listAllStaff };
            reset();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                indexRow = AllStaffDataGridView.CurrentCell.RowIndex;
                var accountId = (int)AllStaffDataGridView.Rows[indexRow].Cells[0].Value;
                var accountToDelete = _context.GetById(accountId);

                if (accountToDelete != null)
                {
                    _context.Delete(accountToDelete);

                    // Remove the row from the DataGridView
                    AllStaffDataGridView.Rows.RemoveAt(indexRow);

                    refreshData();
                    reset();
                }
            }
            else
            {
                return;
            }
        }






        private void AllStaffDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                var staff = AllStaffDataGridView.Rows[indexRow];
                if (e.RowIndex >= 0)
                {
                    txtID.Text = staff.Cells[0].Value.ToString();
                    txtID.ReadOnly = true;
                    txtName.Text = staff.Cells[1].Value.ToString();
                    txtPassword.Text = staff.Cells[2].Value.ToString();
                    txtDob.Text = staff.Cells[4].Value.ToString();
                    txtPhone.Text = staff.Cells[5].Value.ToString();
                    txtAddress.Text = staff.Cells[7].Value.ToString();
                }

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaff add = new AddStaff();
            add.ShowDialog();
            refreshData();
            reset();
        }
        private void refreshData()
        {
            var listAllStaff = _context.GetAll()
           .Select(x => new
           {
               x.AccId,
               x.AccName,
               x.AccPass,
               x.AccCreatedTime,
               x.AccDob,
               x.AccPhone,
               x.AccRole,
               x.AccAddress
           })
           .Where(x => x.AccRole == 1)
           .ToList();

            AllStaffDataGridView.DataSource = new BindingSource() { DataSource = listAllStaff };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = AllStaffDataGridView.Rows[indexRow];
            selectedRow.Cells[1].Value = txtName.Text;
            selectedRow.Cells[2].Value = txtPassword.Text;
            selectedRow.Cells[4].Value = txtDob.Text;
            selectedRow.Cells[5].Value = txtPhone.Text;
            selectedRow.Cells[7].Value = txtAddress.Text;

            // Update the corresponding account entity in the database
            var accountId = (int)selectedRow.Cells[0].Value;
            var accountToUpdate = _context.GetById(accountId);

            if (accountToUpdate != null)
            {
                // Update the account properties
                accountToUpdate.AccName = txtName.Text;
                accountToUpdate.AccPass = txtPassword.Text;
                accountToUpdate.AccDob = DateTime.Parse(txtDob.Text);
                accountToUpdate.AccPhone = txtPhone.Text;
                accountToUpdate.AccAddress = txtAddress.Text;

                // Validate the account before updating
                AccountValidator validator = new AccountValidator();
                List<string> validationErrors = validator.ValidateAccount(accountToUpdate);

                if (validationErrors.Count == 0)
                {
                    _context.Update(accountToUpdate);
                }
                else
                {
                    // Display the validation errors to the user
                    string errorMessage = string.Join("\n", validationErrors);
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Reset the form or perform other necessary actions
            refreshData();
            reset();
        }


        private void reset()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            txtID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtDob.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            String branchName = nametTxt.Text;
            loadByName(branchName);






        }
        public void loadByName(String name = "")
        {
            var account = _context.GetAll().Where(x => x.AccName.Contains(name));
            AllStaffDataGridView.DataSource = new BindingSource() { DataSource = account };

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var link = repoAccount.GetAll().Where(a => a.AccId.Equals(_account.AccId));
            HomePage homePage = new HomePage(link.ToList());
            homePage.Show();
            this.Close();
        }
    }
}
