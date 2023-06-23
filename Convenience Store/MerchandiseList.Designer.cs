namespace Convenience_Store
{
    partial class MerchandiseList
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnFinish = new Button();
            btnRemove = new Button();
            label1 = new Label();
            dgvCurrentlyAdd = new DataGridView();
            dgvMerchandise = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentlyAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMerchandise).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.Location = new Point(1042, 75);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 44);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(478, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Box";
            txtSearch.Size = new Size(557, 35);
            txtSearch.TabIndex = 40;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.Location = new Point(475, 641);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 44);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add Into Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.Location = new Point(1042, 641);
            btnFinish.Margin = new Padding(4, 4, 4, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(132, 44);
            btnFinish.TabIndex = 38;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemove.FlatAppearance.BorderSize = 2;
            btnRemove.Location = new Point(13, 641);
            btnRemove.Margin = new Padding(4, 4, 4, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(132, 44);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(71, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 50);
            label1.TabIndex = 32;
            label1.Text = "Currently Added";
            // 
            // dgvCurrentlyAdd
            // 
            dgvCurrentlyAdd.AllowUserToAddRows = false;
            dgvCurrentlyAdd.AllowUserToDeleteRows = false;
            dgvCurrentlyAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCurrentlyAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentlyAdd.Location = new Point(13, 126);
            dgvCurrentlyAdd.Name = "dgvCurrentlyAdd";
            dgvCurrentlyAdd.ReadOnly = true;
            dgvCurrentlyAdd.RowHeadersWidth = 62;
            dgvCurrentlyAdd.RowTemplate.Height = 33;
            dgvCurrentlyAdd.Size = new Size(441, 508);
            dgvCurrentlyAdd.TabIndex = 37;
            dgvCurrentlyAdd.CellClick += dgvCurrentlyAdd_CellClick;
            // 
            // dgvMerchandise
            // 
            dgvMerchandise.AllowUserToAddRows = false;
            dgvMerchandise.AllowUserToDeleteRows = false;
            dgvMerchandise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvMerchandise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMerchandise.Location = new Point(475, 126);
            dgvMerchandise.Name = "dgvMerchandise";
            dgvMerchandise.ReadOnly = true;
            dgvMerchandise.RowHeadersWidth = 62;
            dgvMerchandise.RowTemplate.Height = 33;
            dgvMerchandise.Size = new Size(699, 508);
            dgvMerchandise.TabIndex = 36;
            dgvMerchandise.CellClick += dgvMerchandise_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 693);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 60);
            panel2.TabIndex = 34;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(983, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 1;
            label4.Text = "Merchandise Popup";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.Location = new Point(15, 8);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 44);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 60);
            panel1.TabIndex = 33;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(-14, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 0);
            label6.TabIndex = 17;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(427, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(238, 38);
            label3.TabIndex = 0;
            label3.Text = "Merchandise List";
            // 
            // MerchandiseList
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 753);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnFinish);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(dgvCurrentlyAdd);
            Controls.Add(dgvMerchandise);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MerchandiseList";
            Text = "MerchandiseList";
            ((System.ComponentModel.ISupportInitialize)dgvCurrentlyAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMerchandise).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnFinish;
        private Button btnRemove;
        private Label label1;
        private DataGridView dgvCurrentlyAdd;
        private DataGridView dgvMerchandise;
        private Panel panel2;
        private Label label4;
        private Button btnExit;
        private Panel panel1;
        private Label label6;
        private Label label3;
    }
}