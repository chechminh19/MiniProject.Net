namespace Convenience_Store
{
    partial class StaffManageForm
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
            label6 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            AllStaffDataGridView = new DataGridView();
            nametTxt = new TextBox();
            searchButton = new Button();
            label3 = new Label();
            txtName = new TextBox();
            txt = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtDob = new DateTimePicker();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            ExitButton = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllStaffDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnExit1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 40);
            panel1.TabIndex = 1;
            panel1.MouseDown += label1_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.Screenshot_2023_06_24_182809_removebg_preview1;
            btnMinimize.Location = new Point(864, 0);
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
            btnMaximize.Location = new Point(894, 0);
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
            btnExit1.Location = new Point(834, 0);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(24, 24);
            btnExit1.TabIndex = 16;
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(380, 6);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 2;
            label1.Text = "Staff Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(9, 468);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "New Staff";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Location = new Point(415, 468);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(821, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AllStaffDataGridView
            // 
            AllStaffDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllStaffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllStaffDataGridView.Location = new Point(415, 79);
            AllStaffDataGridView.Name = "AllStaffDataGridView";
            AllStaffDataGridView.RowHeadersWidth = 51;
            AllStaffDataGridView.RowTemplate.Height = 29;
            AllStaffDataGridView.Size = new Size(495, 384);
            AllStaffDataGridView.TabIndex = 7;
            AllStaffDataGridView.CellDoubleClick += AllStaffDataGridView_CellDoubleClick;
            // 
            // nametTxt
            // 
            nametTxt.Location = new Point(415, 45);
            nametTxt.Name = "nametTxt";
            nametTxt.Size = new Size(405, 27);
            nametTxt.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(817, 45);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(92, 28);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 37);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 11;
            label3.Text = "Account Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 12;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(10, 65);
            txt.Name = "txt";
            txt.Size = new Size(128, 20);
            txt.TabIndex = 13;
            txt.Text = "Account Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 95);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Staff DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 123);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 15;
            label4.Text = "Staff Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 152);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 16;
            label7.Text = "Staff Address";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(144, 63);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 27);
            txtPassword.TabIndex = 17;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(144, 92);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(234, 27);
            txtDob.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(144, 121);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(234, 27);
            txtPhone.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(144, 149);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(234, 27);
            txtAddress.TabIndex = 20;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(144, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(234, 27);
            txtID.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 8);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 22;
            label8.Text = "Account ID";
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.Location = new Point(9, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 25);
            ExitButton.TabIndex = 23;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ExitButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 502);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 40);
            panel2.TabIndex = 24;
            panel2.MouseDown += label1_MouseDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(791, 20);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 11;
            label2.Text = "Staff Manager";
            label2.MouseDown += label1_MouseDown;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(txtDob);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txt);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(9, 79);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 186);
            panel3.TabIndex = 25;
            // 
            // StaffManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 542);
            Controls.Add(panel2);
            Controls.Add(searchButton);
            Controls.Add(nametTxt);
            Controls.Add(AllStaffDataGridView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "StaffManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffManageForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllStaffDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView AllStaffDataGridView;
        private TextBox nametTxt;
        private Button searchButton;
        private Label label3;
        private TextBox txtName;
        private Label txt;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox txtPassword;
        private DateTimePicker txtDob;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtID;
        private Label label8;
        private Button ExitButton;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit1;
    }
}