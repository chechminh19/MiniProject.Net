﻿using Microsoft.EntityFrameworkCore;
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
using System.Windows.Forms.VisualStyles;

namespace Convenience_Store
{
    public partial class AddStaff : Form
    {
        private RepoAccount _context = new RepoAccount();
        public AddStaff()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult saveCreate = MessageBox.Show("Add new staff?", "Save",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (saveCreate == DialogResult.Yes)
                {
                    Account account = new Account();
                    {
                        account.AccName = txtName.Text;
                        account.AccPass = txtPassword.Text;
                        account.AccCreatedTime = DateTime.Now;
                        account.AccDob = DateTime.Parse(txtDob.Text);
                        account.AccPhone = txtPhone.Text;
                        account.AccRole = 1;
                        account.AccAddress = txtAddress.Text;
                    }

                    AccountValidator validator = new AccountValidator();
                    List<string> errors = validator.ValidateAccount(account);

                    if (errors.Count > 0)
                    {
                        string errorMessage = string.Join(Environment.NewLine, errors);
                        MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        _context.Create(account);
                        this.Close();
                    }
                }
                else
                {
                    // Handle "No" option if needed
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"An error occurred while updating the entries: {ex.InnerException?.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

