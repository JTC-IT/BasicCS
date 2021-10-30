
namespace BasicWinform
{
    partial class frmCountDown
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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.lblS = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.labelk2 = new System.Windows.Forms.Label();
            this.labelk1 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.numS = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radioTet = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimerS = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.lblS);
            this.panel.Controls.Add(this.lblM);
            this.panel.Controls.Add(this.labelk2);
            this.panel.Controls.Add(this.labelk1);
            this.panel.Controls.Add(this.lblH);
            this.panel.Controls.Add(this.lblDate);
            this.panel.Controls.Add(this.numS);
            this.panel.Controls.Add(this.numM);
            this.panel.Controls.Add(this.numH);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Controls.Add(this.radioCustom);
            this.panel.Controls.Add(this.radioTet);
            this.panel.Controls.Add(this.lblHeader);
            this.panel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Location = new System.Drawing.Point(1031, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(339, 751);
            this.panel.TabIndex = 0;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(220, 348);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(46, 18);
            this.lblS.TabIndex = 4;
            this.lblS.Text = "Giây";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(142, 348);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(49, 18);
            this.lblM.TabIndex = 4;
            this.lblM.Text = "Phút";
            // 
            // labelk2
            // 
            this.labelk2.AutoSize = true;
            this.labelk2.Location = new System.Drawing.Point(208, 375);
            this.labelk2.Name = "labelk2";
            this.labelk2.Size = new System.Drawing.Size(14, 18);
            this.labelk2.TabIndex = 4;
            this.labelk2.Text = ":";
            // 
            // labelk1
            // 
            this.labelk1.AutoSize = true;
            this.labelk1.Location = new System.Drawing.Point(126, 375);
            this.labelk1.Name = "labelk1";
            this.labelk1.Size = new System.Drawing.Size(14, 18);
            this.labelk1.TabIndex = 4;
            this.labelk1.Text = ":";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(60, 348);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(36, 18);
            this.lblH.TabIndex = 4;
            this.lblH.Text = "Giờ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(60, 278);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày";
            // 
            // numS
            // 
            this.numS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numS.Enabled = false;
            this.numS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numS.Location = new System.Drawing.Point(223, 369);
            this.numS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numS.Name = "numS";
            this.numS.ReadOnly = true;
            this.numS.Size = new System.Drawing.Size(57, 27);
            this.numS.TabIndex = 3;
            this.numS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numS.ValueChanged += new System.EventHandler(this.numS_ValueChanged);
            // 
            // numM
            // 
            this.numM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numM.Enabled = false;
            this.numM.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numM.Location = new System.Drawing.Point(145, 369);
            this.numM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numM.Name = "numM";
            this.numM.ReadOnly = true;
            this.numM.Size = new System.Drawing.Size(57, 27);
            this.numM.TabIndex = 3;
            this.numM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numM.ValueChanged += new System.EventHandler(this.numM_ValueChanged);
            // 
            // numH
            // 
            this.numH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numH.Enabled = false;
            this.numH.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numH.Location = new System.Drawing.Point(63, 369);
            this.numH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numH.Name = "numH";
            this.numH.ReadOnly = true;
            this.numH.Size = new System.Drawing.Size(57, 27);
            this.numH.TabIndex = 3;
            this.numH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numH.ValueChanged += new System.EventHandler(this.numH_ValueChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CausesValidation = false;
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(63, 299);
            this.dateTimePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2021, 10, 12, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // radioCustom
            // 
            this.radioCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioCustom.AutoSize = true;
            this.radioCustom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioCustom.Location = new System.Drawing.Point(170, 213);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(110, 22);
            this.radioCustom.TabIndex = 1;
            this.radioCustom.Text = "Tùy chỉnh";
            this.radioCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioTet
            // 
            this.radioTet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioTet.AutoSize = true;
            this.radioTet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioTet.Checked = true;
            this.radioTet.ForeColor = System.Drawing.Color.Lime;
            this.radioTet.Location = new System.Drawing.Point(63, 172);
            this.radioTet.Name = "radioTet";
            this.radioTet.Size = new System.Drawing.Size(217, 22);
            this.radioTet.TabIndex = 1;
            this.radioTet.TabStop = true;
            this.radioTet.Text = "Tết Nguyên Đán 2022";
            this.radioTet.UseVisualStyleBackColor = true;
            this.radioTet.CheckedChanged += new System.EventHandler(this.radioTet_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblHeader.Location = new System.Drawing.Point(0, 76);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(339, 49);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "THIẾT LẬP";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("SVN-Blade Runner", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitle.Image = global::BasicWinform.Properties.Resources.down;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTitle.Location = new System.Drawing.Point(127, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(788, 191);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CountDown";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("SVN-Kimberley", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Aqua;
            this.lblTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimer.Location = new System.Drawing.Point(210, 527);
            this.lblTimer.MinimumSize = new System.Drawing.Size(600, 105);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(642, 159);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "109d  22:20";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimerS
            // 
            this.lblTimerS.Font = new System.Drawing.Font("SVN-Revolution", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerS.ForeColor = System.Drawing.Color.Aqua;
            this.lblTimerS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimerS.Location = new System.Drawing.Point(418, 330);
            this.lblTimerS.Name = "lblTimerS";
            this.lblTimerS.Size = new System.Drawing.Size(207, 157);
            this.lblTimerS.TabIndex = 2;
            this.lblTimerS.Text = "90";
            this.lblTimerS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicWinform.Properties.Resources.hcm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblTimerS);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel);
            this.Name = "frmCountDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCountDown";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radioTet;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.NumericUpDown numS;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.Label labelk2;
        private System.Windows.Forms.Label labelk1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimerS;
    }
}