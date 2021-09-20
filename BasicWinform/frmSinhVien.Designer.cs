
namespace BisicWinform
{
    partial class frmSinhVien
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdKhac = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDay = new System.Windows.Forms.DateTimePicker();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girdHistory = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tenCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhKiemToStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(239, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin cá nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(290, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 26);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính:";
            // 
            // rdNam
            // 
            this.rdNam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(286, 154);
            this.rdNam.Margin = new System.Windows.Forms.Padding(2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(60, 24);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(356, 154);
            this.rdNu.Margin = new System.Windows.Forms.Padding(2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 24);
            this.rdNu.TabIndex = 5;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdKhac
            // 
            this.rdKhac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdKhac.AutoSize = true;
            this.rdKhac.Location = new System.Drawing.Point(417, 154);
            this.rdKhac.Margin = new System.Windows.Forms.Padding(2);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(63, 24);
            this.rdKhac.TabIndex = 6;
            this.rdKhac.Text = "Khác";
            this.rdKhac.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // birthDay
            // 
            this.birthDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDay.CustomFormat = "dd/MM/yyyy";
            this.birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDay.Location = new System.Drawing.Point(290, 112);
            this.birthDay.Margin = new System.Windows.Forms.Padding(2);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(357, 26);
            this.birthDay.TabIndex = 3;
            this.birthDay.Value = new System.DateTime(2000, 7, 2, 0, 0, 0, 0);
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomeTown.Location = new System.Drawing.Point(286, 191);
            this.txtHomeTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomeTown.Multiline = true;
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHomeTown.Size = new System.Drawing.Size(361, 89);
            this.txtHomeTown.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quê quán:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicWinform.Properties.Resources.ttc;
            this.pictureBox1.Location = new System.Drawing.Point(23, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // girdHistory
            // 
            this.girdHistory.AllowUserToDeleteRows = false;
            this.girdHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girdHistory.AutoGenerateColumns = false;
            this.girdHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.girdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenCapDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.hanhKiemToStringDataGridViewTextBoxColumn});
            this.girdHistory.DataSource = this.capHocBindingSource;
            this.girdHistory.Location = new System.Drawing.Point(23, 344);
            this.girdHistory.Name = "girdHistory";
            this.girdHistory.ReadOnly = true;
            this.girdHistory.Size = new System.Drawing.Size(624, 161);
            this.girdHistory.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lịch sử học tập";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenCapDataGridViewTextBoxColumn
            // 
            this.tenCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenCapDataGridViewTextBoxColumn.DataPropertyName = "tenCap";
            this.tenCapDataGridViewTextBoxColumn.HeaderText = "Cấp";
            this.tenCapDataGridViewTextBoxColumn.Name = "tenCapDataGridViewTextBoxColumn";
            this.tenCapDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenCapDataGridViewTextBoxColumn.Width = 63;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "Trường";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm TB";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemDataGridViewTextBoxColumn.Width = 95;
            // 
            // hanhKiemToStringDataGridViewTextBoxColumn
            // 
            this.hanhKiemToStringDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hanhKiemToStringDataGridViewTextBoxColumn.DataPropertyName = "HanhKiemToString";
            this.hanhKiemToStringDataGridViewTextBoxColumn.HeaderText = "Hạnh Kiểm";
            this.hanhKiemToStringDataGridViewTextBoxColumn.Name = "hanhKiemToStringDataGridViewTextBoxColumn";
            this.hanhKiemToStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.hanhKiemToStringDataGridViewTextBoxColumn.Width = 112;
            // 
            // capHocBindingSource
            // 
            this.capHocBindingSource.DataSource = typeof(BasicWinform.Entities.CapHoc);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(679, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.girdHistory);
            this.Controls.Add(this.birthDay);
            this.Controls.Add(this.rdKhac);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHomeTown);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdKhac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthDay;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView girdHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource capHocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhKiemToStringDataGridViewTextBoxColumn;
    }
}