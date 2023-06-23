namespace Convenience_Store
{
    partial class ImportPopup
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
            btnExit = new Button();
            label3 = new Label();
            panel3 = new Panel();
            txtRoleId = new TextBox();
            txtAccName = new TextBox();
            txtAccId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            txtProviderID = new TextBox();
            label1 = new Label();
            txtProviderPhone = new TextBox();
            label17 = new Label();
            dtpBillDate = new DateTimePicker();
            cbbMerUnit = new ComboBox();
            txtBillTotal = new TextBox();
            txtMerQuantity = new TextBox();
            txtMerPrice = new TextBox();
            txtMerName = new TextBox();
            txtMerId = new TextBox();
            txtProName = new TextBox();
            txtBillName = new TextBox();
            txtBillId = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 40);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(354, 9);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 3;
            label2.Text = "Import Bill Tool";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 40);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(12, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 25);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(709, 20);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 4;
            label3.Text = "New/Update Import Tool";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(txtRoleId);
            panel3.Controls.Add(txtAccName);
            panel3.Controls.Add(txtAccId);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(12, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 223);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // txtRoleId
            // 
            txtRoleId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRoleId.Enabled = false;
            txtRoleId.Location = new Point(110, 70);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(173, 27);
            txtRoleId.TabIndex = 9;
            txtRoleId.TextChanged += txtRoleId_TextChanged;
            // 
            // txtAccName
            // 
            txtAccName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAccName.Enabled = false;
            txtAccName.Location = new Point(110, 37);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(173, 27);
            txtAccName.TabIndex = 8;
            txtAccName.TextChanged += txtAccName_TextChanged;
            // 
            // txtAccId
            // 
            txtAccId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAccId.Enabled = false;
            txtAccId.Location = new Point(110, 4);
            txtAccId.Name = "txtAccId";
            txtAccId.Size = new Size(173, 27);
            txtAccId.TabIndex = 7;
            txtAccId.TextChanged += txtAccId_TextChanged;
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
            label5.Click += label5_Click;
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
            label4.Click += label4_Click;
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
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 11);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 10;
            label7.Text = "Bill ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(btnCancel);
            panel4.Controls.Add(txtProviderID);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtProviderPhone);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(dtpBillDate);
            panel4.Controls.Add(cbbMerUnit);
            panel4.Controls.Add(txtBillTotal);
            panel4.Controls.Add(txtMerQuantity);
            panel4.Controls.Add(txtMerPrice);
            panel4.Controls.Add(txtMerName);
            panel4.Controls.Add(txtMerId);
            panel4.Controls.Add(txtProName);
            panel4.Controls.Add(txtBillName);
            panel4.Controls.Add(txtBillId);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(308, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(571, 453);
            panel4.TabIndex = 11;
            panel4.Paint += panel4_Paint;
            // 
            // txtProviderID
            // 
            txtProviderID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtProviderID.Enabled = false;
            txtProviderID.Location = new Point(504, 104);
            txtProviderID.Name = "txtProviderID";
            txtProviderID.Size = new Size(61, 27);
            txtProviderID.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(466, 107);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 31;
            label1.Text = "Provider ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProviderPhone
            // 
            txtProviderPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProviderPhone.Location = new Point(157, 104);
            txtProviderPhone.Name = "txtProviderPhone";
            txtProviderPhone.Size = new Size(301, 27);
            txtProviderPhone.TabIndex = 30;
            txtProviderPhone.TextChanged += txtProviderPhone_TextChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(9, 107);
            label17.Name = "label17";
            label17.Size = new Size(116, 20);
            label17.TabIndex = 29;
            label17.Text = "Provider Phone";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            label17.Click += label17_Click;
            // 
            // dtpBillDate
            // 
            dtpBillDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpBillDate.Location = new Point(157, 135);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(379, 27);
            dtpBillDate.TabIndex = 28;
            dtpBillDate.ValueChanged += dtpBillDate_ValueChanged;
            // 
            // cbbMerUnit
            // 
            cbbMerUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbMerUnit.FormattingEnabled = true;
            cbbMerUnit.Location = new Point(157, 290);
            cbbMerUnit.Name = "cbbMerUnit";
            cbbMerUnit.Size = new Size(303, 28);
            cbbMerUnit.TabIndex = 27;
            cbbMerUnit.SelectedIndexChanged += cbbMerUnit_SelectedIndexChanged;
            // 
            // txtBillTotal
            // 
            txtBillTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBillTotal.Location = new Point(157, 320);
            txtBillTotal.Name = "txtBillTotal";
            txtBillTotal.Size = new Size(303, 27);
            txtBillTotal.TabIndex = 26;
            txtBillTotal.TextChanged += txtBillTotal_TextChanged;
            // 
            // txtMerQuantity
            // 
            txtMerQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMerQuantity.Location = new Point(157, 256);
            txtMerQuantity.Name = "txtMerQuantity";
            txtMerQuantity.Size = new Size(303, 27);
            txtMerQuantity.TabIndex = 25;
            txtMerQuantity.TextChanged += txtMerQuantity_TextChanged;
            // 
            // txtMerPrice
            // 
            txtMerPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMerPrice.Location = new Point(157, 226);
            txtMerPrice.Name = "txtMerPrice";
            txtMerPrice.Size = new Size(303, 27);
            txtMerPrice.TabIndex = 24;
            txtMerPrice.TextChanged += txtMerPrice_TextChanged;
            // 
            // txtMerName
            // 
            txtMerName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMerName.Location = new Point(157, 196);
            txtMerName.Name = "txtMerName";
            txtMerName.Size = new Size(412, 27);
            txtMerName.TabIndex = 23;
            txtMerName.TextChanged += txtMerName_TextChanged;
            // 
            // txtMerId
            // 
            txtMerId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMerId.Enabled = false;
            txtMerId.Location = new Point(157, 166);
            txtMerId.Name = "txtMerId";
            txtMerId.Size = new Size(412, 27);
            txtMerId.TabIndex = 22;
            txtMerId.TextChanged += txtMerId_TextChanged;
            // 
            // txtProName
            // 
            txtProName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProName.Location = new Point(157, 74);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(412, 27);
            txtProName.TabIndex = 21;
            txtProName.TextChanged += txtProName_TextChanged;
            // 
            // txtBillName
            // 
            txtBillName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBillName.Location = new Point(157, 41);
            txtBillName.Name = "txtBillName";
            txtBillName.Size = new Size(412, 27);
            txtBillName.TabIndex = 20;
            txtBillName.TextChanged += txtBillName_TextChanged;
            // 
            // txtBillId
            // 
            txtBillId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBillId.Enabled = false;
            txtBillId.Location = new Point(157, 8);
            txtBillId.Name = "txtBillId";
            txtBillId.Size = new Size(412, 27);
            txtBillId.TabIndex = 10;
            txtBillId.TextChanged += txtBillId_TextChanged;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(9, 323);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 19;
            label16.Text = "Bill Total";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(9, 293);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 18;
            label15.Text = "Unit";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(9, 259);
            label14.Name = "label14";
            label14.Size = new Size(118, 20);
            label14.TabIndex = 17;
            label14.Text = "Import Quantity";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(9, 229);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 16;
            label13.Text = "Price";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(9, 199);
            label12.Name = "label12";
            label12.Size = new Size(142, 20);
            label12.TabIndex = 15;
            label12.Text = "Merchandise Name";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 169);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 14;
            label11.Text = "Merchandise ID";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(9, 140);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 13;
            label10.Text = "Bill Date";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(9, 77);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 12;
            label9.Text = "Provider Name";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 44);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 11;
            label8.Text = "Bill Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.Location = new Point(414, 418);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 32);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(0, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 32);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ImportPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 545);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ImportPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImportPopup";
            Load += ImportPopup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Button btnExit;
        private Panel panel3;
        private TextBox txtRoleId;
        private TextBox txtAccName;
        private TextBox txtAccId;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpBillDate;
        private ComboBox cbbMerUnit;
        private TextBox txtBillTotal;
        private TextBox txtMerQuantity;
        private TextBox txtMerPrice;
        private TextBox txtMerName;
        private TextBox txtMerId;
        private TextBox txtProName;
        private TextBox txtBillName;
        private TextBox txtBillId;
        private Label label16;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtProviderPhone;
        private Label label17;
        private TextBox txtProviderID;
        private Label label1;
    }
}