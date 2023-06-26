namespace Convenience_Store
{
    partial class AccountSetting
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
            label3 = new Label();
            btnExit = new Button();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtPassword = new TextBox();
            dtpDOB = new DateTimePicker();
            txtName1 = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            panel3 = new Panel();
            btnSave = new Button();
            label14 = new Label();
            btnLogout = new Button();
            txtRole = new TextBox();
            txtRole1 = new TextBox();
            txtId1 = new TextBox();
            label13 = new Label();
            txtName2 = new TextBox();
            label12 = new Label();
            txtId = new TextBox();
            panel1 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnExit1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 472);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 40);
            panel2.TabIndex = 3;
            panel2.MouseDown += label1_MouseDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(808, 11);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 20;
            label3.Text = "Setting Page";
            label3.MouseDown += label1_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(3, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(70, 47);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 4;
            label4.Text = "Id :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(322, 97);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Name :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(322, 143);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 4;
            label7.Text = "Password :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(322, 193);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 4;
            label8.Text = "Date of Birth :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(321, 239);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 4;
            label9.Text = "Phone :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(322, 285);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 4;
            label10.Text = "Role :";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(322, 330);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 4;
            label11.Text = "Address :";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(429, 141);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 5;
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.None;
            dtpDOB.Location = new Point(429, 187);
            dtpDOB.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(259, 27);
            dtpDOB.TabIndex = 6;
            // 
            // txtName1
            // 
            txtName1.Anchor = AnchorStyles.None;
            txtName1.Location = new Point(429, 94);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(125, 27);
            txtName1.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.Location = new Point(429, 327);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(429, 235);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(txtRole);
            panel3.Controls.Add(txtRole1);
            panel3.Controls.Add(txtId1);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dtpDOB);
            panel3.Controls.Add(txtName2);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtName1);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(916, 434);
            panel3.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(741, 341);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(70, 143);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 8;
            label14.Text = "Role :";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(610, 341);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 39);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.None;
            txtRole.Enabled = false;
            txtRole.Location = new Point(143, 141);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 7;
            // 
            // txtRole1
            // 
            txtRole1.Anchor = AnchorStyles.None;
            txtRole1.BackColor = SystemColors.MenuBar;
            txtRole1.BorderStyle = BorderStyle.FixedSingle;
            txtRole1.Location = new Point(429, 283);
            txtRole1.Name = "txtRole1";
            txtRole1.ReadOnly = true;
            txtRole1.Size = new Size(125, 27);
            txtRole1.TabIndex = 10;
            // 
            // txtId1
            // 
            txtId1.Anchor = AnchorStyles.None;
            txtId1.BackColor = SystemColors.MenuBar;
            txtId1.BorderStyle = BorderStyle.FixedSingle;
            txtId1.Location = new Point(429, 45);
            txtId1.Name = "txtId1";
            txtId1.ReadOnly = true;
            txtId1.Size = new Size(125, 27);
            txtId1.TabIndex = 9;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(322, 47);
            label13.Name = "label13";
            label13.Size = new Size(29, 20);
            label13.TabIndex = 8;
            label13.Text = "Id :";
            // 
            // txtName2
            // 
            txtName2.Anchor = AnchorStyles.None;
            txtName2.Enabled = false;
            txtName2.Location = new Point(143, 97);
            txtName2.Name = "txtName2";
            txtName2.ReadOnly = true;
            txtName2.Size = new Size(125, 27);
            txtName2.TabIndex = 7;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(70, 97);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 6;
            label12.Text = "Name :";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.BackColor = SystemColors.MenuBar;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(143, 45);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnExit1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 38);
            panel1.TabIndex = 13;
            panel1.MouseDown += label1_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.Screenshot_2023_06_24_182809_removebg_preview1;
            btnMinimize.Location = new Point(860, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 24);
            btnMinimize.TabIndex = 14;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.Screenshot_2023_06_24_182506_removebg_preview;
            btnMaximize.Location = new Point(890, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(24, 24);
            btnMaximize.TabIndex = 15;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit1
            // 
            btnExit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit1.FlatAppearance.BorderSize = 0;
            btnExit1.FlatStyle = FlatStyle.Flat;
            btnExit1.Image = Properties.Resources.png_clipart_power_symbol_computer_icons_button_button_computer_electrical_switches_removebg_preview1;
            btnExit1.Location = new Point(830, 3);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(24, 24);
            btnExit1.TabIndex = 13;
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(420, 3);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 12;
            label1.Text = "Setting";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            // 
            // AccountSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(916, 512);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(796, 507);
            Name = "AccountSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountSetting";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private Button btnExit;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtPassword;
        private DateTimePicker dtpDOB;
        private ComboBox cbRole;
        private TextBox txtName1;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Panel panel3;
        private Label label13;
        private Label label14;
        private TextBox txtRole;
        private TextBox txtName2;
        private TextBox txtId;
        private Label label12;
        private Button btnLogout;
        private Button btnSave;
        private TextBox txtId1;
        private TextBox txtRole1;
        private Panel panel1;
        private Label label1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit1;
    }
}