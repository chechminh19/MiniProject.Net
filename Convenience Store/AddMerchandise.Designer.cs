namespace Convenience_Store
{
    partial class AddMerchandise
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
            panel2 = new Panel();
            btnAdd = new Button();
            btnClear = new Button();
            label2 = new Label();
            txtName = new TextBox();
            cbCategory = new ComboBox();
            label3 = new Label();
            txtUnit = new TextBox();
            txtDes = new TextBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            btnExit = new Button();
            ExitButton = new Button();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUnit);
            panel2.Controls.Add(txtDes);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 292);
            panel2.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(270, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 25);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(10, 263);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 25);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, -1);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 9;
            label2.Text = "Name ";
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 15;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(153, 213);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(209, 28);
            cbCategory.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 10;
            label3.Text = "Description ";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(153, 174);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(209, 27);
            txtUnit.TabIndex = 19;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(153, 45);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(209, 27);
            txtDes.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(153, 134);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(209, 27);
            txtQuantity.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 11;
            label4.Text = "Price ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(153, 87);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 12;
            label5.Text = "Quantity ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 209);
            label7.Name = "label7";
            label7.Size = new Size(97, 28);
            label7.TabIndex = 14;
            label7.Text = "Category ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 170);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 13;
            label6.Text = "Unit ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 40);
            panel1.TabIndex = 24;
            panel1.MouseDown += label8_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(128, 128, 255);
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(119, 4);
            label8.Name = "label8";
            label8.Size = new Size(173, 28);
            label8.TabIndex = 2;
            label8.Text = "Add Merchandise";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.MouseDown += label8_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(ExitButton);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 366);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(393, 39);
            panel3.TabIndex = 25;
            panel3.MouseDown += label8_MouseDown;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(261, 19);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 26;
            label10.Text = "Add Merchandise";
            label10.MouseDown += label8_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(3, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 25);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.Location = new Point(9, -50);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 25);
            ExitButton.TabIndex = 24;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(497, 19);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 12;
            label9.Text = "Staff Manager";
            // 
            // AddMerchandise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 405);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMerchandise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMerchandise";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TextBox txtName;
        private ComboBox cbCategory;
        private Label label3;
        private TextBox txtUnit;
        private TextBox txtDes;
        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private Panel panel3;
        private Button ExitButton;
        private Label label9;
        private Button btnExit;
        private Label label10;
        private Button btnAdd;
        private Button btnClear;
    }
}