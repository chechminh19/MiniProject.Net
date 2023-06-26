namespace Convenience_Store
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOrder = new DataGridView();
            lblTotal = new Label();
            pnlHeader = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            lblOrderTitle = new Label();
            btnExit1 = new Button();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            pnlFooter = new Panel();
            lblOrderFooter = new Label();
            btnExit = new Button();
            txtTotal = new TextBox();
            lblDollarSign = new Label();
            btnExport = new Button();
            btnFinish = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMerchandise = new Button();
            pnlCurrentEm = new Panel();
            lblMerId = new Label();
            txtMerId = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            lblRole = new Label();
            txtRole = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblName = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlCurrentEm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(450, 45);
            dgvOrder.Margin = new Padding(2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(455, 345);
            dgvOrder.TabIndex = 13;
            dgvOrder.CellClick += dgvOrder_CellClick;
            dgvOrder.CellValueChanged += dgvOrder_CellValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(381, 397);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(128, 128, 255);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnMaximize);
            pnlHeader.Controls.Add(lblOrderTitle);
            pnlHeader.Controls.Add(btnExit1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = SystemColors.MenuText;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(916, 40);
            pnlHeader.TabIndex = 20;
            pnlHeader.MouseDown += lblOrderTitle_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.Screenshot_2023_06_24_182809_removebg_preview1;
            btnMinimize.Location = new Point(859, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 24);
            btnMinimize.TabIndex = 33;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.Screenshot_2023_06_24_182506_removebg_preview;
            btnMaximize.Location = new Point(889, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(24, 24);
            btnMaximize.TabIndex = 34;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrderTitle.Location = new Point(414, 6);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(65, 28);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Order";
            lblOrderTitle.MouseDown += lblOrderTitle_MouseDown;
            // 
            // btnExit1
            // 
            btnExit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit1.FlatAppearance.BorderSize = 0;
            btnExit1.FlatStyle = FlatStyle.Flat;
            btnExit1.Image = Properties.Resources.png_clipart_power_symbol_computer_icons_button_button_computer_electrical_switches_removebg_preview1;
            btnExit1.Location = new Point(829, 3);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(24, 24);
            btnExit1.TabIndex = 32;
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(251, 94);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.MenuBar;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(251, 128);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(146, 27);
            txtQuantity.TabIndex = 16;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(128, 128, 255);
            pnlFooter.Controls.Add(lblOrderFooter);
            pnlFooter.Controls.Add(btnExit);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 433);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(916, 40);
            pnlFooter.TabIndex = 24;
            pnlFooter.MouseDown += lblOrderTitle_MouseDown;
            // 
            // lblOrderFooter
            // 
            lblOrderFooter.AutoSize = true;
            lblOrderFooter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrderFooter.Location = new Point(825, 20);
            lblOrderFooter.Name = "lblOrderFooter";
            lblOrderFooter.Size = new Size(88, 20);
            lblOrderFooter.TabIndex = 1;
            lblOrderFooter.Text = "Order Page";
            lblOrderFooter.MouseDown += lblOrderTitle_MouseDown;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.Location = new Point(9, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTotal.BackColor = SystemColors.Menu;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(439, 395);
            txtTotal.Margin = new Padding(2);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(164, 33);
            txtTotal.TabIndex = 25;
            // 
            // lblDollarSign
            // 
            lblDollarSign.AutoSize = true;
            lblDollarSign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDollarSign.Location = new Point(607, 397);
            lblDollarSign.Margin = new Padding(2, 0, 2, 0);
            lblDollarSign.Name = "lblDollarSign";
            lblDollarSign.Size = new Size(23, 28);
            lblDollarSign.TabIndex = 26;
            lblDollarSign.Text = "$";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.Location = new Point(665, 395);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(117, 33);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Bill";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.Location = new Point(788, 395);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(117, 33);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.Location = new Point(9, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 33);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.Location = new Point(131, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 33);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMerchandise
            // 
            btnMerchandise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnMerchandise.FlatAppearance.BorderSize = 2;
            btnMerchandise.Location = new Point(254, 395);
            btnMerchandise.Name = "btnMerchandise";
            btnMerchandise.Size = new Size(117, 33);
            btnMerchandise.TabIndex = 30;
            btnMerchandise.Text = "Merchandise";
            btnMerchandise.UseVisualStyleBackColor = true;
            btnMerchandise.Click += btnMerchandise_Click;
            // 
            // pnlCurrentEm
            // 
            pnlCurrentEm.Controls.Add(lblQuantity);
            pnlCurrentEm.Controls.Add(txtQuantity);
            pnlCurrentEm.Controls.Add(lblMerId);
            pnlCurrentEm.Controls.Add(txtMerId);
            pnlCurrentEm.Controls.Add(txtAddress);
            pnlCurrentEm.Controls.Add(lblAddress);
            pnlCurrentEm.Controls.Add(txtPhone);
            pnlCurrentEm.Controls.Add(lblPhone);
            pnlCurrentEm.Controls.Add(lblRole);
            pnlCurrentEm.Controls.Add(txtRole);
            pnlCurrentEm.Controls.Add(txtName);
            pnlCurrentEm.Controls.Add(txtId);
            pnlCurrentEm.Controls.Add(lblName);
            pnlCurrentEm.Controls.Add(lblId);
            pnlCurrentEm.Location = new Point(9, 45);
            pnlCurrentEm.Name = "pnlCurrentEm";
            pnlCurrentEm.Size = new Size(426, 345);
            pnlCurrentEm.TabIndex = 31;
            // 
            // lblMerId
            // 
            lblMerId.AutoSize = true;
            lblMerId.Location = new Point(251, 12);
            lblMerId.Name = "lblMerId";
            lblMerId.Size = new Size(117, 20);
            lblMerId.TabIndex = 13;
            lblMerId.Text = "Merchandise Id :";
            // 
            // txtMerId
            // 
            txtMerId.BackColor = SystemColors.MenuBar;
            txtMerId.BorderStyle = BorderStyle.FixedSingle;
            txtMerId.Enabled = false;
            txtMerId.Location = new Point(251, 46);
            txtMerId.Name = "txtMerId";
            txtMerId.ReadOnly = true;
            txtMerId.Size = new Size(146, 27);
            txtMerId.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(97, 166);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(300, 57);
            txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(11, 165);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(99, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(13, 135);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(57, 20);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone :";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(11, 94);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 20);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role :";
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(97, 91);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(97, 50);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.MenuBar;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(99, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(13, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 20);
            lblId.TabIndex = 4;
            lblId.Text = "Id :";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 473);
            Controls.Add(pnlCurrentEm);
            Controls.Add(btnMerchandise);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnFinish);
            Controls.Add(btnExport);
            Controls.Add(lblDollarSign);
            Controls.Add(txtTotal);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Controls.Add(lblTotal);
            Controls.Add(dgvOrder);
            Margin = new Padding(2);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            pnlCurrentEm.ResumeLayout(false);
            pnlCurrentEm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOrder;
        private Label lblTotal;
        private Panel pnlHeader;
        private Label lblOrderTitle;
        private Panel pnlFooter;
        private Label lblOrderFooter;
        private Button btnExit;
        private TextBox txtTotal;
        private Label lblDollarSign;
        private Button btnExport;
        private Button btnFinish;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMerchandise;
        private Panel pnlCurrentEm;
        private Label lblRole;
        private TextBox txtRole;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblName;
        private Label lblId;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblMerId;
        private TextBox txtMerId;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit1;
    }
}