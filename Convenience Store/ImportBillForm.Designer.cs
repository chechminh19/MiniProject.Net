﻿namespace Convenience_Store
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
            label6 = new Label();
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
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 60);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(18, 21);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
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
            label1.Location = new Point(458, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 38);
            label1.TabIndex = 2;
            label1.Text = "Import Bill";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 693);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1186, 60);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(903, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 3;
            label2.Text = "Import Bill Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(18, 12);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 38);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(458, 72);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Bill Based On Merchandise Name";
            txtSearch.Size = new Size(566, 35);
            txtSearch.TabIndex = 0;
            // 
            // dgvImportBill
            // 
            dgvImportBill.AllowUserToAddRows = false;
            dgvImportBill.AllowUserToDeleteRows = false;
            dgvImportBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvImportBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvImportBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportBill.Location = new Point(459, 122);
            dgvImportBill.Margin = new Padding(4, 4, 4, 4);
            dgvImportBill.Name = "dgvImportBill";
            dgvImportBill.ReadOnly = true;
            dgvImportBill.RowHeadersWidth = 51;
            dgvImportBill.RowTemplate.Height = 29;
            dgvImportBill.Size = new Size(710, 501);
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
            btnSearch.Location = new Point(1035, 69);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 44);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new Point(1035, 632);
            btnExport.Margin = new Padding(4, 4, 4, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(132, 44);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(818, 632);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 44);
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
            panel2.Location = new Point(18, 72);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 234);
            panel2.TabIndex = 6;
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtRole.Location = new Point(165, 105);
            txtRole.Margin = new Padding(4, 4, 4, 4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(259, 35);
            txtRole.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtName.Location = new Point(165, 56);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(259, 35);
            txtName.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtId.Location = new Point(165, 6);
            txtId.Margin = new Padding(4, 4, 4, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(259, 35);
            txtId.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 6;
            label5.Text = "Role";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 66);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 5;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 30);
            label3.TabIndex = 4;
            label3.Text = "Account ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImport.Location = new Point(18, 632);
            btnImport.Margin = new Padding(4, 4, 4, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(180, 44);
            btnImport.TabIndex = 7;
            btnImport.Text = "New Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(316, 632);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 44);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ImportBillForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 753);
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
            Margin = new Padding(4, 4, 4, 4);
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
    }
}