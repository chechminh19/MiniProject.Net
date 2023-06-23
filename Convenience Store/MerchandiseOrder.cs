using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Service.Repository;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Globalization;
using System.Security.AccessControl;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using System.Diagnostics;


namespace Convenience_Store
{

    public partial class MerchandiseOrder : Form
    {
        RepoMerchandise _repoMer = new RepoMerchandise();
        RepoCategory repoCategory = new RepoCategory();
        ConvenienceStoreContext _context;
        DbSet<Merchandise> dbSet;
        Merchandise merchandises = new Merchandise();
        private SqlConnection connection;
        int selectedMerchaId;

        private readonly Account _account;
        RepoAccount repoAccount = new RepoAccount();

        public MerchandiseOrder(List<Account> accounts)
        {
            InitializeComponent();
            _account = accounts.FirstOrDefault();
            if (_account != null)
            {
                txtId.Text = _account.AccId.ToString();
                txtName1.Text = _account.AccName;
                txtRole.Text = _account.AccRole.ToString();

            }

        }
        private void LoadDataFromDatabase()
        {
            string query = "SELECT * FROM Merchandise"; // Thay đổi câu truy vấn tùy thuộc vào cấu trúc của bảng sản phẩm của bạn
            GetDataAndRefreshDataGridView(query);


        }
        private void GetDataAndRefreshDataGridView(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            dataAdapter.Fill(dataTable);

            dgvKho.DataSource = dataTable;
            dgvKho.Refresh();
        }
        int indexOfContent;

        private void resetState()
        {
            txtSearchKho.Text = "";
            txtName.Text = "";
            txtDes.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
            cbCategory.SelectedValue = 0;


            Add.Enabled = true;
            Delete.Enabled = false;
            Edit.Enabled = false;
        }
        private void btnSnack_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 1";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnAlcoho_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 2";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 3";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnInstant_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 4";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 5";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 6";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 7";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnSpices_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 8";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnCigarette_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 9";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 10";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnTissue_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 11";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnFrozen_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 12";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnCanned_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 13";
            GetDataAndRefreshDataGridView(query);
        }

        private void btnChemicals_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Merchandise WHERE merIdCategory = 14";
            GetDataAndRefreshDataGridView(query);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MerchandiseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát hả? buồn vậy !", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            AddMerchandise addMer = new AddMerchandise();
            addMer.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("You want to update ?", "Notification", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    if (!UtilsMerchandise.CheckValidString(txtName.Text))
                    {
                        MessageBox.Show("Name must be not special character, not only number and have at least 1 letter !", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    if (!UtilsMerchandise.CheckValidString(txtDes.Text))
                    {
                        MessageBox.Show("Description must be not special character, not only number and have at least 1 letter !", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    double price;
                    if (!UtilsMerchandise.CheckValidDouble(txtPrice.Text, out price))
                    {
                        MessageBox.Show("Price must be double !", "Notification", MessageBoxButtons.OK);
                        return;
                    }


                    if (!UtilsMerchandise.CheckNumberOnly(txtQuantity.Text))
                    {
                        MessageBox.Show("Quantity must be integer !", "Notification", MessageBoxButtons.OK);
                        return;
                    }

                    if (!UtilsMerchandise.CheckValidString(txtUnit.Text))
                    {
                        MessageBox.Show("Unit must not be special characters, not only number and at least 1 letter !", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    Merchandise mer = new Merchandise
                    {

                        MerId = selectedMerchaId,
                        MerName = txtName.Text,
                        MerDescription = txtDes.Text,
                        MerPrice = Convert.ToDouble(txtPrice.Text),
                        MerQuantity = Convert.ToInt32(txtQuantity.Text),
                        MerUnit = txtUnit.Text,
                        MerIdCategory = Convert.ToInt32(cbCategory.SelectedValue.ToString())
                    };
                    _repoMer.Update(mer);
                    MessageBox.Show("Edit Success!", "Notification", MessageBoxButtons.OK);
                    resetState();
                    LoadDataFromDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
            resetState();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearchKho.Text;
            var data = _repoMer.GetAll();

            if (!string.IsNullOrEmpty(strSearch.Trim()))
            {
                string searchValue = strSearch.Trim();
                //data = data.Where(m => m.MerName.Contains(strSearch)).ToList();
                data = data.Where(m => m.MerName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                dgvKho.DataSource = data;
            }

        }



        private void Delete_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKho.Rows[dgvKho.SelectedCells[0].RowIndex];

            if (row != null)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chưa?", "Xóa sản phẩm này", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                    Merchandise mer = _repoMer.GetAll().SingleOrDefault(m => m.MerId == id);

                    if (mer != null) _repoMer.Delete(mer);
                    MessageBox.Show("Delete Success!", "Notification", MessageBoxButtons.OK);
                    resetState();
                    LoadDataFromDatabase();
                }

            };

        }

        private void MerchandiseOrder_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=(local);uid=sa;pwd=12345;database=ConvenienceStore;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);
            dgvKho.Font = new Font("Arial Unicode MS", 12);
            LoadDataFromDatabase();

            _repoMer = new RepoMerchandise();
            _context = new ConvenienceStoreContext();
            dgvKho.DataSource = new BindingSource() { DataSource = _repoMer.GetAll() };
            resetState();
            cbCategory.DataSource = repoCategory.GetAll();
            cbCategory.DisplayMember = "nameCategory";
            cbCategory.ValueMember = "idCategory";

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            AddMerchandise addMerchandise = new AddMerchandise();
            addMerchandise.ShowDialog();
        }

        private void dgvKho_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Add.Enabled = false;
            Edit.Enabled = true;
            Delete.Enabled = true;
            DataGridViewRow row = dgvKho.Rows[e.RowIndex];

            txtName.Text = row.Cells[1].Value.ToString();

            txtDes.Text = row.Cells[2].Value.ToString();

            txtPrice.Text = row.Cells[3].Value.ToString();

            txtQuantity.Text = row.Cells[4].Value.ToString();

            txtUnit.Text = row.Cells[5].Value.ToString();

            cbCategory.SelectedValue = Convert.ToInt32(row.Cells[6].Value.ToString());

            selectedMerchaId = Convert.ToInt32(row.Cells[0].Value.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            var link = repoAccount.GetAll().Where(a => a.AccId.Equals(_account.AccId));
            HomePage homePage = new HomePage(link.ToList());
            homePage.Show();
            this.Close();
        }
    }
}
