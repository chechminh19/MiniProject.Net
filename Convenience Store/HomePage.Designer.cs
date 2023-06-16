﻿namespace Convenience_Store
{
    partial class HomePage
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnExit = new Button();
            btnOrder = new Button();
            btnMerchandise = new Button();
            btnExportBill = new Button();
            btnImportBill = new Button();
            btnCustomer = new Button();
            btnSetting = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 105);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(323, 16);
            label2.Name = "label2";
            label2.Size = new Size(282, 62);
            label2.TabIndex = 19;
            label2.Text = "Main Home";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 510);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 40);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(797, 41);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 20;
            label3.Text = "Home Page";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(9, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 25);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(55, 178);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(201, 54);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "New Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnMerchandise
            // 
            btnMerchandise.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMerchandise.Location = new Point(351, 178);
            btnMerchandise.Name = "btnMerchandise";
            btnMerchandise.Size = new Size(221, 54);
            btnMerchandise.TabIndex = 4;
            btnMerchandise.Text = "Merchandise";
            btnMerchandise.UseVisualStyleBackColor = true;
            btnMerchandise.Click += btnMerchandise_Click;
            // 
            // btnExportBill
            // 
            btnExportBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportBill.Location = new Point(674, 178);
            btnExportBill.Name = "btnExportBill";
            btnExportBill.Size = new Size(201, 54);
            btnExportBill.TabIndex = 4;
            btnExportBill.Text = "Export Bill";
            btnExportBill.UseVisualStyleBackColor = true;
            btnExportBill.Click += btnExportBill_Click;
            // 
            // btnImportBill
            // 
            btnImportBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImportBill.Location = new Point(55, 338);
            btnImportBill.Name = "btnImportBill";
            btnImportBill.Size = new Size(201, 54);
            btnImportBill.TabIndex = 4;
            btnImportBill.Text = "Import Bill";
            btnImportBill.UseVisualStyleBackColor = true;
            btnImportBill.Click += btnImportBill_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.Location = new Point(360, 338);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(201, 54);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnSetting
            // 
            btnSetting.DialogResult = DialogResult.OK;
            btnSetting.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.Location = new Point(674, 338);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(201, 54);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 550);
            Controls.Add(btnSetting);
            Controls.Add(btnCustomer);
            Controls.Add(btnImportBill);
            Controls.Add(btnExportBill);
            Controls.Add(btnMerchandise);
            Controls.Add(btnOrder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Button btnExit;
        private Button btnOrder;
        private Button btnMerchandise;
        private Button btnExportBill;
        private Button btnImportBill;
        private Button btnCustomer;
        private Button btnSetting;
        private TextBox textBox1;
    }
}