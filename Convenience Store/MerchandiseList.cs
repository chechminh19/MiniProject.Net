using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convenience_Store;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Runtime.InteropServices;

namespace Convenience_Store
{
    public partial class MerchandiseList : Form
    {
        private Merchandise merchandise = new Merchandise();

        private RepoMerchandise repoMerchandise = new RepoMerchandise();
        List<Account> accounts = new List<Account>();
        List<Merchandise> searchlist = new List<Merchandise>();
        public List<Merchandise> orderlist { get; set; }
        public static DataGridViewRow SelectedRow { get; set; }
        int index = -1;
        public MerchandiseList(List<Account> accounts, List<Merchandise> list)
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
            if (list == null)
            {
                this.Close();
                return;
            }
            this.accounts = accounts;
            this.orderlist = list;
            searchlist = repoMerchandise.GetAll().ToList();
            dgvMerchandise.DataSource = new BindingSource() { DataSource = searchlist };
            dgvCurrentlyAdd.DataSource = new BindingSource() { DataSource = orderlist };
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String search = AccountSetting.formatString(txtSearch.Text.ToLower());
            if (search.Equals(null))
                return;

            searchlist = repoMerchandise.GetAll().Where(a => a.MerName.ToLower().Contains(AccountSetting.formatString(search))).ToList();
            dgvMerchandise.DataSource = new BindingSource() { DataSource = searchlist };

            dgvMerchandise.DataSource = new BindingSource() { DataSource = searchlist };
            dgvCurrentlyAdd.DataSource = new BindingSource() { DataSource = orderlist };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*this.Close();
            Form homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();*/
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            /*this.DialogResult = DialogResult.OK;*/
            Order order = new Order(accounts, orderlist);
            order.Show();
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                var gay = repoMerchandise.GetAll().Where(a => a.MerId == index).ToList();
                if (gay.Count == 1)
                {
                    var merfirst = gay.FirstOrDefault();
                    if (!orderlist.Contains(merfirst))
                        orderlist.Add(gay.FirstOrDefault());
                }

                /*if (searchlist[index - 1] != null)
                {
                    orderlist.Add(searchlist[index  - 1]);
                }*/
            }
            index = -1;
            dgvCurrentlyAdd.DataSource = new BindingSource() { DataSource = orderlist };
        }


        /* private void dgvMerchandise_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e != null && e.RowIndex >= 0 && e.RowIndex < searchlist.Count)
             {
                 index = (int)dgvMerchandise.Rows[e.RowIndex].Cells[0].Value;
             }
         }*/

        private void dgvMerchandise_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e != null && e.RowIndex >= 0 && e.RowIndex < searchlist.Count)
            {
                index = (int)dgvMerchandise.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void dgvCurrentlyAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e != null && e.RowIndex >= 0 && e.RowIndex < orderlist.Count)
            {
                index = (int)dgvCurrentlyAdd.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                var gay = repoMerchandise.GetAll().Where(a => a.MerId == index).ToList();
                if (gay != null && gay.Count == 1)
                {
                    var merfirst = gay.FirstOrDefault();
                    if (orderlist.Contains(merfirst))
                        orderlist.Remove(gay.FirstOrDefault());
                }
            }
            index = -1;
            dgvCurrentlyAdd.DataSource = new BindingSource() { DataSource = orderlist };
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
