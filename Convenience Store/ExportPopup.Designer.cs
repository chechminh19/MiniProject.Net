namespace Convenience_Store
{
    partial class ExportPopup
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
            txtAccName = new TextBox();
            txtAccId = new TextBox();
            label5 = new Label();
            cbbCusGender = new ComboBox();
            cbbCusID = new ComboBox();
            cbbMngID = new ComboBox();
            panel3 = new Panel();
            txtAccRole = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtProviderID = new TextBox();
            label1 = new Label();
            dtpEBDate = new DateTimePicker();
            txtCusPhone = new ComboBox();
            txtCusName = new TextBox();
            txtMngName = new TextBox();
            txtEBID = new TextBox();
            btnUpdate = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            dtpCusDOB = new DateTimePicker();
            label12 = new Label();
            btnCancel = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            button1 = new Button();
            btnExit = new Button();
            label3 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtAccName
            // 
            txtAccName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAccName.Enabled = false;
            txtAccName.Location = new Point(110, 37);
            txtAccName.Name = "txtAccName";
            txtAccName.ReadOnly = true;
            txtAccName.Size = new Size(345, 27);
            txtAccName.TabIndex = 8;
            // 
            // txtAccId
            // 
            txtAccId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAccId.Enabled = false;
            txtAccId.Location = new Point(110, 4);
            txtAccId.Name = "txtAccId";
            txtAccId.ReadOnly = true;
            txtAccId.Size = new Size(345, 27);
            txtAccId.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 77);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 6;
            label5.Text = "Role";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbCusGender
            // 
            cbbCusGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCusGender.Location = new Point(157, 195);
            cbbCusGender.Name = "cbbCusGender";
            cbbCusGender.Size = new Size(441, 28);
            cbbCusGender.TabIndex = 35;
            cbbCusGender.SelectedIndexChanged += cbbCusGender_SelectedIndexChanged;
            // 
            // cbbCusID
            // 
            cbbCusID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCusID.Location = new Point(157, 135);
            cbbCusID.Name = "cbbCusID";
            cbbCusID.Size = new Size(441, 28);
            cbbCusID.TabIndex = 34;
            cbbCusID.SelectedIndexChanged += cbbCusID_SelectedIndexChanged;
            // 
            // cbbMngID
            // 
            cbbMngID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMngID.Location = new Point(157, 72);
            cbbMngID.Name = "cbbMngID";
            cbbMngID.Size = new Size(441, 28);
            cbbMngID.TabIndex = 33;
            cbbMngID.SelectedIndexChanged += cbbMngID_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(txtAccRole);
            panel3.Controls.Add(txtAccName);
            panel3.Controls.Add(txtAccId);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(12, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 134);
            panel3.TabIndex = 35;
            // 
            // txtAccRole
            // 
            txtAccRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAccRole.Enabled = false;
            txtAccRole.Location = new Point(110, 70);
            txtAccRole.Name = "txtAccRole";
            txtAccRole.ReadOnly = true;
            txtAccRole.Size = new Size(345, 27);
            txtAccRole.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 44);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 11);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 4;
            label6.Text = "Account ID";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProviderID
            // 
            txtProviderID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtProviderID.Enabled = false;
            txtProviderID.Location = new Point(1327, 104);
            txtProviderID.Name = "txtProviderID";
            txtProviderID.Size = new Size(61, 27);
            txtProviderID.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1289, 107);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 31;
            label1.Text = "Provider ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpEBDate
            // 
            dtpEBDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpEBDate.Location = new Point(157, 104);
            dtpEBDate.Name = "dtpEBDate";
            dtpEBDate.Size = new Size(438, 27);
            dtpEBDate.TabIndex = 28;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusPhone.FormattingEnabled = true;
            txtCusPhone.Location = new Point(157, 259);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(1126, 28);
            txtCusPhone.TabIndex = 27;
            // 
            // txtCusName
            // 
            txtCusName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusName.Location = new Point(157, 165);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(1235, 27);
            txtCusName.TabIndex = 23;
            // 
            // txtMngName
            // 
            txtMngName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMngName.Location = new Point(157, 41);
            txtMngName.Name = "txtMngName";
            txtMngName.ReadOnly = true;
            txtMngName.Size = new Size(1235, 27);
            txtMngName.TabIndex = 20;
            // 
            // txtEBID
            // 
            txtEBID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEBID.Enabled = false;
            txtEBID.Location = new Point(157, 8);
            txtEBID.Name = "txtEBID";
            txtEBID.ReadOnly = true;
            txtEBID.Size = new Size(1235, 27);
            txtEBID.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.Location = new Point(435, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 32);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(9, 262);
            label15.Name = "label15";
            label15.Size = new Size(122, 20);
            label15.TabIndex = 18;
            label15.Text = "Customer Phone";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(9, 228);
            label14.Name = "label14";
            label14.Size = new Size(109, 20);
            label14.TabIndex = 17;
            label14.Text = "Customer DOB";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(9, 198);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 16;
            label13.Text = "Customer Gender";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 138);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 14;
            label11.Text = "Customer ID";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(9, 109);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 13;
            label10.Text = "Export Bill Date";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(9, 77);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 12;
            label9.Text = "Manager ID";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 44);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 11;
            label8.Text = "Manager Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 11);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 10;
            label7.Text = "Export Bill ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(dtpCusDOB);
            panel4.Controls.Add(cbbCusGender);
            panel4.Controls.Add(cbbCusID);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(cbbMngID);
            panel4.Controls.Add(txtProviderID);
            panel4.Controls.Add(btnCancel);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dtpEBDate);
            panel4.Controls.Add(txtCusPhone);
            panel4.Controls.Add(txtCusName);
            panel4.Controls.Add(txtMngName);
            panel4.Controls.Add(txtEBID);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(308, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(598, 365);
            panel4.TabIndex = 36;
            // 
            // dtpCusDOB
            // 
            dtpCusDOB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpCusDOB.Location = new Point(157, 229);
            dtpCusDOB.Name = "dtpCusDOB";
            dtpCusDOB.Size = new Size(438, 27);
            dtpCusDOB.TabIndex = 36;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(9, 168);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 15;
            label12.Text = "Customer Name";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(0, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 32);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 40);
            panel1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(371, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 3;
            label2.Text = "Export Bill Tool";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 40);
            panel2.TabIndex = 40;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(800, 15);
            label16.Name = "label16";
            label16.Size = new Size(115, 20);
            label16.TabIndex = 7;
            label16.Text = "Edit Export Tool";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 25);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(12, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 0);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1454, 20);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 4;
            label3.Text = "New/Update Import Tool";
            // 
            // ExportPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 456);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "ExportPopup";
            Text = "Export Bill - Popup";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAccName;
        private TextBox txtAccId;
        private Label label5;
        private ComboBox cbbCusGender;
        private ComboBox cbbCusID;
        private ComboBox cbbMngID;
        private Panel panel3;
        private TextBox txtAccRole;
        private Label label4;
        private Label label6;
        private TextBox txtProviderID;
        private Label label1;
        private DateTimePicker dtpEBDate;
        private ComboBox txtCusPhone;
        private TextBox txtCusName;
        private TextBox txtMngName;
        private TextBox txtEBID;
        private Button btnUpdate;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private Label label12;
        private Button btnCancel;
        private DateTimePicker dtpCusDOB;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btnExit;
        private Label label3;
        private Button button1;
        private Label label16;
    }
}