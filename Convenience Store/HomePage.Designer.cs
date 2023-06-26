namespace Convenience_Store
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
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnExit1 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnExit = new Button();
            btnOrder = new Button();
            btnExportBill = new Button();
            btnImportBill = new Button();
            btnCustomer = new Button();
            btnSetting = new Button();
            btnStaffManage = new Button();
            btnMerchandiseorder = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnExit1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 38);
            panel1.TabIndex = 1;
            panel1.MouseDown += label2_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.Screenshot_2023_06_24_182809_removebg_preview1;
            btnMinimize.Location = new Point(776, 5);
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
            btnMaximize.Location = new Point(806, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(24, 24);
            btnMaximize.TabIndex = 18;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit1
            // 
            btnExit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit1.FlatAppearance.BorderSize = 0;
            btnExit1.FlatStyle = FlatStyle.Flat;
            btnExit1.Image = Properties.Resources.png_clipart_power_symbol_computer_icons_button_button_computer_electrical_switches_removebg_preview1;
            btnExit1.Location = new Point(746, 5);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(24, 24);
            btnExit1.TabIndex = 16;
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(369, 5);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 4;
            label2.Text = "Main Home";
            label2.MouseDown += label2_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 40);
            panel2.TabIndex = 2;
            panel2.MouseDown += label2_MouseDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(724, 20);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 20;
            label3.Text = "Home Page";
            label3.MouseDown += label2_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 33);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnOrder
            // 
            btnOrder.AutoSize = true;
            btnOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(17, 52);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(201, 54);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "New Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnExportBill
            // 
            btnExportBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportBill.AutoSize = true;
            btnExportBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportBill.Location = new Point(623, 51);
            btnExportBill.Name = "btnExportBill";
            btnExportBill.Size = new Size(201, 54);
            btnExportBill.TabIndex = 4;
            btnExportBill.Text = "Export Bill";
            btnExportBill.UseVisualStyleBackColor = true;
            btnExportBill.Click += btnExportBill_Click;
            // 
            // btnImportBill
            // 
            btnImportBill.Anchor = AnchorStyles.Left;
            btnImportBill.AutoSize = true;
            btnImportBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImportBill.Location = new Point(17, 174);
            btnImportBill.Name = "btnImportBill";
            btnImportBill.Size = new Size(201, 54);
            btnImportBill.TabIndex = 4;
            btnImportBill.Text = "Import Bill";
            btnImportBill.UseVisualStyleBackColor = true;
            btnImportBill.Click += btnImportBill_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.None;
            btnCustomer.AutoSize = true;
            btnCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.Location = new Point(309, 173);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(221, 54);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnSetting
            // 
            btnSetting.Anchor = AnchorStyles.Right;
            btnSetting.AutoSize = true;
            btnSetting.DialogResult = DialogResult.OK;
            btnSetting.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.Location = new Point(623, 173);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(201, 54);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnStaffManage
            // 
            btnStaffManage.Anchor = AnchorStyles.Bottom;
            btnStaffManage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStaffManage.Location = new Point(309, 296);
            btnStaffManage.Margin = new Padding(2);
            btnStaffManage.Name = "btnStaffManage";
            btnStaffManage.Size = new Size(221, 54);
            btnStaffManage.TabIndex = 5;
            btnStaffManage.Text = "Staff Manage";
            btnStaffManage.UseVisualStyleBackColor = true;
            btnStaffManage.Click += btnStaffManage_Click;
            // 
            // btnMerchandiseorder
            // 
            btnMerchandiseorder.Anchor = AnchorStyles.Top;
            btnMerchandiseorder.AutoSize = true;
            btnMerchandiseorder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMerchandiseorder.Location = new Point(309, 51);
            btnMerchandiseorder.Name = "btnMerchandiseorder";
            btnMerchandiseorder.Size = new Size(221, 54);
            btnMerchandiseorder.TabIndex = 5;
            btnMerchandiseorder.Text = "Merchandise Order";
            btnMerchandiseorder.UseVisualStyleBackColor = true;
            btnMerchandiseorder.Click += btnMerchandiseorder_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 421);
            Controls.Add(btnStaffManage);
            Controls.Add(btnMerchandiseorder);
            Controls.Add(btnSetting);
            Controls.Add(btnCustomer);
            Controls.Add(btnImportBill);
            Controls.Add(btnExportBill);
            Controls.Add(btnOrder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(728, 350);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Button btnExit;
        private Button btnOrder;
        private Button btnExportBill;
        private Button btnImportBill;
        private Button btnCustomer;
        private Button btnSetting;
        private TextBox textBox1;
        private Button btnStaffManage;
        private Button btnMerchandiseorder;
        private Label label2;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit1;
    }
}