﻿using Service.Models;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Convenience_Store;

public partial class Order : Form
{
    List<Account> accounts = new List<Account>();
    List<BillDetail> billDetails = null;
    List<Merchandise> orderlist = new List<Merchandise>();
    double total = 0;
    int index = -1;
    public Order(List<Account> accounts)
    {
        InitializeComponent();
        if (accounts == null || accounts.Count != 1 || accounts.FirstOrDefault() == null)
        {
            accounts = null;
            LoginForm form = new LoginForm();
            this.Close();
            return;
        }
        this.accounts = accounts;
        var _account = accounts.FirstOrDefault();
        txtId.Text = _account.AccId.ToString();
        txtName.Text = _account.AccName;
        txtRole.Text = _account.AccRole.ToString();
        txtPhone.Text = _account.AccPhone;
        txtAddress.Text = _account.AccAddress;
        loadGrid();
    }

    private void loadGrid()
    {

        if (billDetails != null)
        {

            total = 0;
            foreach (BillDetail bd in billDetails)
            {
                total += bd.BillMerPrice * bd.BillMerQuanity;
            }
            txtTotal.Text = total.ToString();
            
            /*dgvOrder.AutoGenerateColumns = false;
            var newColumn = new DataGridViewTextBoxColumn();
            newColumn.HeaderText = "MerName";
            newColumn.Name = "MerName";
            newColumn.DataPropertyName = "Mer.MerName";*/
            /*newColumn.DataPropertyName = "Mer.MerName";*/
            /*dgvOrder.Columns.Add(newColumn);
            dgvOrder.Columns[newColumn.Index].ValueType = typeof(string);
            for (int i = 0; i < orderlist.Count; i++)
            {
                // set the value of the new column for the current row
                dgvOrder.Rows[i].Cells[newColumn.Index].Value = orderlist[i].MerName.ToString();
            }*/
            dgvOrder.DataSource = new BindingSource() { DataSource = billDetails };

            /* dgvOrder.ReadOnly = true;*/
            dgvOrder.Columns[0].Visible = false;
            dgvOrder.Columns[1].Visible = false;
            /*dgvOrder.Columns["MerId"].ReadOnly = true;
            dgvOrder.Columns[3].ReadOnly = true;
            dgvOrder.Columns["BillMerPrice"].ReadOnly = true;*/
            dgvOrder.Columns[5].Visible = false;
            dgvOrder.Columns[6].Visible = false;


        }

    }
    public Order(List<Account> accounts, List<Merchandise> list)
    {
        InitializeComponent();
        if (accounts == null || accounts.Count != 1 || accounts.FirstOrDefault() == null)
        {
            accounts = null;
            LoginForm form = new LoginForm();
            this.Close();
            return;
        }
        if (list == null)
        {
            list = new List<Merchandise>();
            MerchandiseList merchandiseList = new MerchandiseList(accounts, list);
            this.Close();
            return;
        }
        this.orderlist = list;
        orderToBill();
        this.accounts = accounts;
        var _account = accounts.FirstOrDefault();
        txtId.Text = _account.AccId.ToString();
        txtName.Text = _account.AccName;
        txtRole.Text = _account.AccRole.ToString();
        txtPhone.Text = _account.AccPhone;
        txtAddress.Text = _account.AccAddress;

        loadGrid();

    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        /*loadGrid();*/
        /* if (btnEdit.Text.Equals("Edit") && index != -1)
         {
             *//*dgvOrder.Columns[3].ReadOnly = false;*//*
             dgvOrder.ReadOnly = false;
             btnEdit.Text = "Save";
             *//*dgvOrder.Columns[3].DefaultCellStyle.NullValue = "0";
             dgvOrder.Columns[3].ValueType = typeof(int);*//*
             dgvOrder.DataSource = new BindingSource() { DataSource = billDetails };

         }
         if (btnEdit.Text.Equals("Save"))
         {
             loadGrid();
             btnEdit.Text = "Edit";
         }*/
        int newValue;
        String temp = Regex.Replace(txtQuantity.Text, " ", "").Trim();
        if (!int.TryParse(temp, out newValue))
        {
            // If the value is not a valid integer, cancel the edit operation
            MessageBox.Show("Please enter a positive non-zero integer.");
            return;
        }
        if (newValue <= 0)
        {
            // If the value is not a valid integer, cancel the edit operation
            MessageBox.Show("Please enter a positive non-zero integer.");
            return;
        }
        else
        {
            billDetails[index].BillMerQuanity = newValue;
            loadGrid();
        }

    }

    private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name == "BillMerQuanity")
            {
                // Parse the entered value as an integer
                int newValue;
                String temp = Regex.Replace(dgvOrder[e.ColumnIndex, e.RowIndex].FormattedValue.ToString(), " ", "").Trim();
                if (!int.TryParse(temp, out newValue))
                {
                    // If the value is not a valid integer, cancel the edit operation
                    MessageBox.Show("Please enter a positive non-zero integer.");
                    return;
                }

                // Check if the value is positive and non-zero
                if (newValue <= 0)
                {
                    // If the value is not positive and non-zero, cancel the edit operation
                    MessageBox.Show("Please enter a positive non-zero integer.");
                    return;
                }
                billDetails[e.RowIndex].BillMerQuanity = newValue;
                dgvOrder.DataSource = new BindingSource() { DataSource = billDetails };
            }
        }
        catch (Exception excep)
        {

        }
    }

    private void orderToBill()
    {
        if (orderlist == null || orderlist.Count < 1)
            orderlist = new List<Merchandise>();
        else
        {
            billDetails = new List<BillDetail>();
            foreach (Merchandise mer in orderlist)
            {
                BillDetail bd = new BillDetail();
                bd.MerId = mer.MerId;
                bd.BillMerQuanity = 1;
                bd.BillMerPrice = mer.MerPrice;
                bd.Mer = mer;
                billDetails.Add(bd);
            }
        }
    }

    private void btnMerchandise_Click(object sender, EventArgs e)
    {
        try
        {
            MerchandiseList ml = new MerchandiseList(accounts, orderlist);
            /*if (ml.ShowDialog() == DialogResult.OK)
            {
                if (ml.orderlist != null)
                {
                    this.orderlist = ml.orderlist;
                    orderToBill();
                    loadGrid();
                }
            }*/
            ml.ShowDialog();
            this.Close();
        }
        catch (Exception excep) { MessageBox.Show("Something is wrong with MerchandiseList."); }
    }

    private void txtId_TextChanged(object sender, EventArgs e)
    {

    }

    private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        index = e.RowIndex;
        if (index >= 0)
        {
            txtMerId.Text = dgvOrder["MerId", index].FormattedValue.ToString();
            txtQuantity.Text = dgvOrder[3, index].FormattedValue.ToString();
            txtQuantity.ReadOnly = false;
        }
        else index = -1;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (index == -1)
            {
                MessageBox.Show("Please choose a merchandise from the data grid to delete.");
            }
            else
            {
                billDetails.RemoveAt(index);
                orderlist.RemoveAt(index);
                loadGrid();
            }
            index = -1;
            lblMerId.Text = "";
        }
        catch (Exception excep)
        {

        }

    }
}
