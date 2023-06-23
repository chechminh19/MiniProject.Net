namespace Convenience_Store
{
    partial class ExportBillForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnEdit = new Button();
            btnExport = new Button();
            txtAccName = new TextBox();
            txtAccId = new TextBox();
            lblAccRole = new Label();
            lblAccName = new Label();
            lblAccId = new Label();
            pnlAcc = new Panel();
            txtAccRole = new TextBox();
            btnDelete = new Button();
            dtpCusDOB = new DateTimePicker();
            txtMerPrice = new TextBox();
            lblMerPrice = new Label();
            txtMerName = new TextBox();
            lblMerId = new Label();
            pnlCusMer = new Panel();
            lblMerName = new Label();
            lblCusDOB = new Label();
            txtMerId = new TextBox();
            txtCusGender = new TextBox();
            txtCusPhone = new TextBox();
            lblCusGender = new Label();
            lblCusPhone = new Label();
            txtCusName = new TextBox();
            txtCusId = new TextBox();
            lblCusName = new Label();
            lblCusId = new Label();
            dgvExportBill = new DataGridView();
            btnExit = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            pnlAcc.SuspendLayout();
            pnlCusMer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExportBill).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(344, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Bill Based On Manager Name";
            txtSearch.Size = new Size(382, 27);
            txtSearch.TabIndex = 30;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(732, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 29);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(343, 450);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 29);
            btnEdit.TabIndex = 35;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new Point(732, 450);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(88, 29);
            btnExport.TabIndex = 32;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // txtAccName
            // 
            txtAccName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAccName.Enabled = false;
            txtAccName.Location = new Point(119, 37);
            txtAccName.Name = "txtAccName";
            txtAccName.ReadOnly = true;
            txtAccName.Size = new Size(190, 27);
            txtAccName.TabIndex = 8;
            // 
            // txtAccId
            // 
            txtAccId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAccId.Enabled = false;
            txtAccId.Location = new Point(119, 4);
            txtAccId.Name = "txtAccId";
            txtAccId.ReadOnly = true;
            txtAccId.Size = new Size(190, 27);
            txtAccId.TabIndex = 7;
            // 
            // lblAccRole
            // 
            lblAccRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAccRole.AutoSize = true;
            lblAccRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccRole.Location = new Point(10, 77);
            lblAccRole.Name = "lblAccRole";
            lblAccRole.Size = new Size(39, 20);
            lblAccRole.TabIndex = 6;
            lblAccRole.Text = "Role";
            lblAccRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccName
            // 
            lblAccName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAccName.AutoSize = true;
            lblAccName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccName.Location = new Point(10, 44);
            lblAccName.Name = "lblAccName";
            lblAccName.Size = new Size(50, 20);
            lblAccName.TabIndex = 5;
            lblAccName.Text = "Name";
            lblAccName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccId
            // 
            lblAccId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAccId.AutoSize = true;
            lblAccId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccId.Location = new Point(10, 11);
            lblAccId.Name = "lblAccId";
            lblAccId.Size = new Size(84, 20);
            lblAccId.TabIndex = 4;
            lblAccId.Text = "Account ID";
            lblAccId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAcc
            // 
            pnlAcc.Controls.Add(txtAccRole);
            pnlAcc.Controls.Add(txtAccName);
            pnlAcc.Controls.Add(txtAccId);
            pnlAcc.Controls.Add(lblAccRole);
            pnlAcc.Controls.Add(lblAccName);
            pnlAcc.Controls.Add(lblAccId);
            pnlAcc.Location = new Point(12, 50);
            pnlAcc.Name = "pnlAcc";
            pnlAcc.Size = new Size(326, 101);
            pnlAcc.TabIndex = 34;
            // 
            // txtAccRole
            // 
            txtAccRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAccRole.Enabled = false;
            txtAccRole.Location = new Point(119, 70);
            txtAccRole.Name = "txtAccRole";
            txtAccRole.ReadOnly = true;
            txtAccRole.Size = new Size(190, 27);
            txtAccRole.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(542, 450);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 29);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpCusDOB
            // 
            dtpCusDOB.Enabled = false;
            dtpCusDOB.Location = new Point(72, 142);
            dtpCusDOB.Name = "dtpCusDOB";
            dtpCusDOB.Size = new Size(240, 27);
            dtpCusDOB.TabIndex = 20;
            // 
            // txtMerPrice
            // 
            txtMerPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtMerPrice.Enabled = false;
            txtMerPrice.Location = new Point(119, 253);
            txtMerPrice.Name = "txtMerPrice";
            txtMerPrice.ReadOnly = true;
            txtMerPrice.Size = new Size(193, 27);
            txtMerPrice.TabIndex = 27;
            // 
            // lblMerPrice
            // 
            lblMerPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMerPrice.AutoSize = true;
            lblMerPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMerPrice.Location = new Point(10, 256);
            lblMerPrice.Name = "lblMerPrice";
            lblMerPrice.Size = new Size(91, 20);
            lblMerPrice.TabIndex = 26;
            lblMerPrice.Text = "Merch Price";
            lblMerPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMerName
            // 
            txtMerName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtMerName.Enabled = false;
            txtMerName.Location = new Point(119, 219);
            txtMerName.Name = "txtMerName";
            txtMerName.ReadOnly = true;
            txtMerName.Size = new Size(193, 27);
            txtMerName.TabIndex = 25;
            // 
            // lblMerId
            // 
            lblMerId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMerId.AutoSize = true;
            lblMerId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMerId.Location = new Point(10, 189);
            lblMerId.Name = "lblMerId";
            lblMerId.Size = new Size(72, 20);
            lblMerId.TabIndex = 18;
            lblMerId.Text = "Merch ID";
            lblMerId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCusMer
            // 
            pnlCusMer.Controls.Add(dtpCusDOB);
            pnlCusMer.Controls.Add(txtMerPrice);
            pnlCusMer.Controls.Add(lblMerPrice);
            pnlCusMer.Controls.Add(txtMerName);
            pnlCusMer.Controls.Add(lblMerName);
            pnlCusMer.Controls.Add(lblCusDOB);
            pnlCusMer.Controls.Add(txtMerId);
            pnlCusMer.Controls.Add(txtCusGender);
            pnlCusMer.Controls.Add(txtCusPhone);
            pnlCusMer.Controls.Add(lblMerId);
            pnlCusMer.Controls.Add(lblCusGender);
            pnlCusMer.Controls.Add(lblCusPhone);
            pnlCusMer.Controls.Add(txtCusName);
            pnlCusMer.Controls.Add(txtCusId);
            pnlCusMer.Controls.Add(lblCusName);
            pnlCusMer.Controls.Add(lblCusId);
            pnlCusMer.Location = new Point(12, 157);
            pnlCusMer.Name = "pnlCusMer";
            pnlCusMer.Size = new Size(326, 284);
            pnlCusMer.TabIndex = 36;
            // 
            // lblMerName
            // 
            lblMerName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMerName.AutoSize = true;
            lblMerName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMerName.Location = new Point(10, 222);
            lblMerName.Name = "lblMerName";
            lblMerName.Size = new Size(98, 20);
            lblMerName.TabIndex = 24;
            lblMerName.Text = "Merch Name";
            lblMerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCusDOB
            // 
            lblCusDOB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCusDOB.AutoSize = true;
            lblCusDOB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCusDOB.Location = new Point(10, 147);
            lblCusDOB.Name = "lblCusDOB";
            lblCusDOB.Size = new Size(40, 20);
            lblCusDOB.TabIndex = 22;
            lblCusDOB.Text = "DOB";
            lblCusDOB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMerId
            // 
            txtMerId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtMerId.Enabled = false;
            txtMerId.Location = new Point(119, 186);
            txtMerId.Name = "txtMerId";
            txtMerId.ReadOnly = true;
            txtMerId.Size = new Size(193, 27);
            txtMerId.TabIndex = 21;
            // 
            // txtCusGender
            // 
            txtCusGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCusGender.Enabled = false;
            txtCusGender.Location = new Point(119, 74);
            txtCusGender.Name = "txtCusGender";
            txtCusGender.ReadOnly = true;
            txtCusGender.Size = new Size(193, 27);
            txtCusGender.TabIndex = 23;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCusPhone.Enabled = false;
            txtCusPhone.Location = new Point(119, 107);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.ReadOnly = true;
            txtCusPhone.Size = new Size(193, 27);
            txtCusPhone.TabIndex = 19;
            // 
            // lblCusGender
            // 
            lblCusGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCusGender.AutoSize = true;
            lblCusGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCusGender.Location = new Point(10, 81);
            lblCusGender.Name = "lblCusGender";
            lblCusGender.Size = new Size(59, 20);
            lblCusGender.TabIndex = 17;
            lblCusGender.Text = "Gender";
            lblCusGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCusPhone
            // 
            lblCusPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCusPhone.AutoSize = true;
            lblCusPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCusPhone.Location = new Point(10, 114);
            lblCusPhone.Name = "lblCusPhone";
            lblCusPhone.Size = new Size(53, 20);
            lblCusPhone.TabIndex = 16;
            lblCusPhone.Text = "Phone";
            lblCusPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCusName
            // 
            txtCusName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCusName.Enabled = false;
            txtCusName.Location = new Point(119, 41);
            txtCusName.Name = "txtCusName";
            txtCusName.ReadOnly = true;
            txtCusName.Size = new Size(193, 27);
            txtCusName.TabIndex = 14;
            // 
            // txtCusId
            // 
            txtCusId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCusId.Enabled = false;
            txtCusId.Location = new Point(119, 8);
            txtCusId.Name = "txtCusId";
            txtCusId.ReadOnly = true;
            txtCusId.Size = new Size(190, 27);
            txtCusId.TabIndex = 13;
            // 
            // lblCusName
            // 
            lblCusName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCusName.Location = new Point(10, 48);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(50, 20);
            lblCusName.TabIndex = 11;
            lblCusName.Text = "Name";
            lblCusName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCusId
            // 
            lblCusId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCusId.AutoSize = true;
            lblCusId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCusId.Location = new Point(10, 15);
            lblCusId.Name = "lblCusId";
            lblCusId.Size = new Size(93, 20);
            lblCusId.TabIndex = 10;
            lblCusId.Text = "Customer ID";
            lblCusId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvExportBill
            // 
            dgvExportBill.AllowUserToAddRows = false;
            dgvExportBill.AllowUserToDeleteRows = false;
            dgvExportBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExportBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExportBill.Location = new Point(343, 83);
            dgvExportBill.Name = "dgvExportBill";
            dgvExportBill.ReadOnly = true;
            dgvExportBill.RowHeadersWidth = 51;
            dgvExportBill.RowTemplate.Height = 29;
            dgvExportBill.Size = new Size(477, 358);
            dgvExportBill.TabIndex = 37;
            dgvExportBill.CellClick += dgvExportBill_CellClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(22, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 38;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 40);
            panel1.TabIndex = 39;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(12, 14);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(367, 6);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 2;
            label1.Text = "Export Bill";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 487);
            panel4.Name = "panel4";
            panel4.Size = new Size(833, 40);
            panel4.TabIndex = 40;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1235, 20);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 3;
            label2.Text = "Import Bill Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 8);
            button1.Name = "button1";
            button1.Size = new Size(92, 0);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(715, 17);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 11;
            label3.Text = "Export Bill Page";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExportBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 527);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(dgvExportBill);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnExport);
            Controls.Add(pnlAcc);
            Controls.Add(btnDelete);
            Controls.Add(pnlCusMer);
            Name = "ExportBillForm";
            Text = "Export Bill";
            pnlAcc.ResumeLayout(false);
            pnlAcc.PerformLayout();
            pnlCusMer.ResumeLayout(false);
            pnlCusMer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExportBill).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnExport;
        private TextBox txtAccName;
        private TextBox txtAccId;
        private Label lblAccRole;
        private Label lblAccName;
        private Label lblAccId;
        private Panel pnlAcc;
        private TextBox txtAccRole;
        private Button btnDelete;
        private DateTimePicker dtpCusDOB;
        private TextBox txtMerPrice;
        private Label lblMerPrice;
        private TextBox txtMerName;
        private Label lblMerId;
        private Panel pnlCusMer;
        private Label lblMerName;
        private Label lblCusDOB;
        private TextBox txtMerId;
        private TextBox txtCusGender;
        private TextBox txtCusPhone;
        private Label lblCusGender;
        private Label lblCusPhone;
        private TextBox txtCusName;
        private TextBox txtCusId;
        private Label lblCusName;
        private Label lblCusId;
        private DataGridView dgvExportBill;
        private Button btnExit;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}