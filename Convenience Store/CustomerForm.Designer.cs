namespace Convenience_Store
{
    partial class CustomerForm
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
            label9 = new Label();
            btnExit1 = new Button();
            label6 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            txtRole = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            dgvCustomer = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            btnExit = new Button();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            ExitButton = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnExit1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 40);
            panel1.TabIndex = 3;
            panel1.MouseDown += label9_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.Screenshot_2023_06_24_182809_removebg_preview1;
            btnMinimize.Location = new Point(742, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 24);
            btnMinimize.TabIndex = 32;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.Screenshot_2023_06_24_182506_removebg_preview;
            btnMaximize.Location = new Point(772, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(24, 24);
            btnMaximize.TabIndex = 33;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(128, 128, 255);
            label9.FlatStyle = FlatStyle.System;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(350, 6);
            label9.Name = "label9";
            label9.Size = new Size(102, 28);
            label9.TabIndex = 11;
            label9.Text = "Customer";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.MouseDown += label9_MouseDown;
            // 
            // btnExit1
            // 
            btnExit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit1.FlatAppearance.BorderSize = 0;
            btnExit1.FlatStyle = FlatStyle.Flat;
            btnExit1.Image = Properties.Resources.png_clipart_power_symbol_computer_icons_button_button_computer_electrical_switches_removebg_preview1;
            btnExit1.Location = new Point(712, 6);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(24, 24);
            btnExit1.TabIndex = 31;
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
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
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(625, -24);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 2;
            label1.Text = "Customer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.Controls.Add(txtRole);
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(0, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 156);
            panel4.TabIndex = 29;
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
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 11);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 4;
            label7.Text = "Account ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(331, 45);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(472, 362);
            dgvCustomer.TabIndex = 28;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ExitButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 443);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 40);
            panel2.TabIndex = 30;
            panel2.MouseDown += label9_MouseDown;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(690, 17);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 28;
            label8.Text = "Customer Page";
            label8.MouseDown += label9_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(0, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 25);
            btnExit.TabIndex = 27;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1252, -43);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 26;
            label3.Text = "Customer Page";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(0, -48);
            button1.Name = "button1";
            button1.Size = new Size(95, 25);
            button1.TabIndex = 24;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1956, 20);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 11;
            label2.Text = "Staff Manager";
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.Location = new Point(9, -108);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 25);
            ExitButton.TabIndex = 23;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(715, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 29);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Location = new Point(331, 413);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 29);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(0, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 29);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "New Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 483);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(dgvCustomer);
            Controls.Add(panel1);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Panel panel4;
        private TextBox txtRole;
        private TextBox txtName;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label7;
        private DataGridView dgvCustomer;
        private Panel panel2;
        private Label label3;
        private Button button1;
        private Label label2;
        private Button ExitButton;
        private Button btnExit;
        private Label label8;
        private Label label9;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}