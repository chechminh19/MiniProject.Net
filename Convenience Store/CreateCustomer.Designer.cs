namespace Convenience_Store
{
    partial class CreateCustomer
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
            btnSave = new Button();
            label4 = new Label();
            dtpDOB = new DateTimePicker();
            txtCusPhone = new TextBox();
            label17 = new Label();
            txtcusGender = new TextBox();
            txtCusName = new TextBox();
            txtCusId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            ExitButton = new Button();
            label5 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(422, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 145);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 34;
            label4.Text = "Date Of Birth";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(176, 140);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(351, 27);
            dtpDOB.TabIndex = 33;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusPhone.Location = new Point(176, 178);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(351, 27);
            txtCusPhone.TabIndex = 30;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(28, 181);
            label17.Name = "label17";
            label17.Size = new Size(131, 20);
            label17.TabIndex = 29;
            label17.Text = "Customer's Phone";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtcusGender
            // 
            txtcusGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtcusGender.Location = new Point(176, 101);
            txtcusGender.Name = "txtcusGender";
            txtcusGender.Size = new Size(351, 27);
            txtcusGender.TabIndex = 21;
            // 
            // txtCusName
            // 
            txtCusName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusName.Location = new Point(176, 58);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(351, 27);
            txtCusName.TabIndex = 20;
            // 
            // txtCusId
            // 
            txtCusId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusId.Enabled = false;
            txtCusId.Location = new Point(176, 16);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(351, 27);
            txtCusId.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 104);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 12;
            label9.Text = "Customer's Gender";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 61);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 11;
            label8.Text = "Customer's Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 19);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 10;
            label7.Text = "Customer ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpDOB);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtCusPhone);
            panel2.Controls.Add(txtCusId);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txtCusName);
            panel2.Controls.Add(txtcusGender);
            panel2.Location = new Point(-5, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 231);
            panel2.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 40);
            panel1.TabIndex = 35;
            panel1.MouseDown += label1_MouseDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(188, 7);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 2;
            label1.Text = "Customer Creation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(ExitButton);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(522, 40);
            panel3.TabIndex = 36;
            panel3.MouseDown += label1_MouseDown;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(3, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 25);
            ExitButton.TabIndex = 37;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(12, 14);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 128, 255);
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(460, 17);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 2;
            label6.Text = "Create";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.MouseDown += label1_MouseDown;
            // 
            // CreateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 408);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnSave);
            MinimumSize = new Size(540, 401);
            Name = "CreateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCustomer";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnSave;
        private Label label4;
        private DateTimePicker dtpDOB;
        private TextBox txtCusPhone;
        private Label label17;
        private TextBox txtcusGender;
        private TextBox txtCusName;
        private TextBox txtCusId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Button ExitButton;
    }
}