namespace Convenience_Store
{
    partial class ImportBillForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            label6 = new Label();
            btnExit1 = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            btnExit = new Button();
            txtSearch = new TextBox();
            dgvImportBill = new DataGridView();
            importBillBindingSource = new BindingSource(components);
            btnSearch = new Button();
            btnExport = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            txtRole = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnImport = new Button();
            btnEdit = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)importBillBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnExit1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 40);
            panel1.TabIndex = 0;
            panel1.MouseDown += label2_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.Screenshot_2023_06_24_182809_removebg_preview1;
            btnMinimize.Location = new Point(740, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 24);
            btnMinimize.TabIndex = 17;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.Screenshot_2023_06_24_182506_removebg_preview;
            btnMaximize.Location = new Point(770, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(24, 24);
            btnMaximize.TabIndex = 18;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
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
            // btnExit1
            // 
            btnExit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit1.FlatAppearance.BorderSize = 0;
            btnExit1.FlatStyle = FlatStyle.Flat;
            btnExit1.Image = Properties.Resources.png_clipart_power_symbol_computer_icons_button_button_computer_electrical_switches_removebg_preview1;
            btnExit1.Location = new Point(710, 6);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(24, 24);
            btnExit1.TabIndex = 16;
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(343, 6);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 2;
            label1.Text = "Import Bill";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label2_MouseDown;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 451);
            panel4.Name = "panel4";
            panel4.Size = new Size(801, 40);
            panel4.TabIndex = 1;
            panel4.MouseDown += label2_MouseDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(680, 20);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 3;
            label2.Text = "Import Bill Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.MouseDown += label2_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(12, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 25);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(305, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Bill Based On Merchandise Name";
            txtSearch.Size = new Size(389, 27);
            txtSearch.TabIndex = 0;
            // 
            // dgvImportBill
            // 
            dgvImportBill.AllowUserToAddRows = false;
            dgvImportBill.AllowUserToDeleteRows = false;
            dgvImportBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvImportBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvImportBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportBill.Location = new Point(306, 81);
            dgvImportBill.Name = "dgvImportBill";
            dgvImportBill.ReadOnly = true;
            dgvImportBill.RowHeadersWidth = 51;
            dgvImportBill.RowTemplate.Height = 29;
            dgvImportBill.Size = new Size(483, 323);
            dgvImportBill.TabIndex = 2;
            dgvImportBill.CellClick += dgvImportBill_CellClick;
            // 
            // importBillBindingSource
            // 
            importBillBindingSource.DataSource = typeof(Service.Models.ImportBill);
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(700, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new Point(700, 410);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(88, 29);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(555, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtRole);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 156);
            panel2.TabIndex = 6;
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtRole.Location = new Point(110, 70);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(174, 27);
            txtRole.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtName.Location = new Point(110, 37);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtId.Location = new Point(110, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(174, 27);
            txtId.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 77);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 6;
            label5.Text = "Role";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 44);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 11);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Account ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImport.Location = new Point(12, 410);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(120, 29);
            btnImport.TabIndex = 7;
            btnImport.Text = "New Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(211, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ImportBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 491);
            Controls.Add(btnEdit);
            Controls.Add(btnImport);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnExport);
            Controls.Add(btnSearch);
            Controls.Add(dgvImportBill);
            Controls.Add(txtSearch);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MinimumSize = new Size(579, 335);
            Name = "ImportBillForm";
            Text = "ImportBill";
            Load += ImportBill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)importBillBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvImportBill;
        private Button btnSearch;
        private Button btnExport;
        private Button btnDelete;
        private Panel panel2;
        private Button btnImport;
        private Button btnEdit;
        private Button btnExit;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtRole;
        private TextBox txtName;
        private TextBox txtId;
        private BindingSource importBillBindingSource;
        private Label label6;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit1;
    }
}