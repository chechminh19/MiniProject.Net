using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Convenience_Store
{
    public partial class AddMerchandise : Form
    {
        private RepoCategory _repoCat;
        private RepoMerchandise _repoMer;
        public AddMerchandise()
        {
            InitializeComponent();
            _repoCat = new RepoCategory();
            _repoMer = new RepoMerchandise();
            PrepareCategoryComboBox();

        }
        private void PrepareCategoryComboBox()
        {
            List<Category> categories = _repoCat.GetAll();

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "nameCategory";
            cbCategory.ValueMember = "idCategory";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult saveCreate = MessageBox.Show("Xac nhan them ?", "Save",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (saveCreate == DialogResult.Yes)
                {
                    string name = txtName.Text;
                    string description = txtDes.Text;
                    double price;
                    string quantity = txtQuantity.Text;
                    string unit = txtUnit.Text;
                    int categoryId = (int)cbCategory.SelectedValue;


                    if (!UtilsMerchandise.CheckValidString(name))
                    {
                        MessageBox.Show("Name must benot special character, not only number and have at least 1 letter !", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    if (!UtilsMerchandise.CheckValidString(description))
                    {
                        MessageBox.Show("Description mustnot special character, not only number and have at least 1 letter !", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    if (!UtilsMerchandise.CheckValidDouble(txtPrice.Text, out price))
                    {
                        MessageBox.Show("Price must be double value!", "Notification", MessageBoxButtons.OK);
                        return;
                    }

                    if (!UtilsMerchandise.CheckNumberOnly(quantity))
                    {
                        MessageBox.Show("Quantity must be integer !", "Notification", MessageBoxButtons.OK);
                        return;
                    }

                    if (!UtilsMerchandise.CheckValidString(unit))
                    {
                        MessageBox.Show("Unit must not be special characters, not only number and at least 1 letter !", "Notification", MessageBoxButtons.OK);
                        return;
                    }


                    Merchandise merchandise = new Merchandise();
                    merchandise.MerName = name;
                    merchandise.MerDescription = description;
                    merchandise.MerPrice = Convert.ToDouble(txtPrice.Text);
                    merchandise.MerQuantity = int.Parse(quantity);
                    merchandise.MerUnit = unit;
                    merchandise.MerIdCategory = categoryId;

                    _repoMer.Create(merchandise);

                    MessageBox.Show("Add Successfully!", "Notification", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed at: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDes.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
        }
    }

}




