namespace ANSv1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.MainForm_lbl_factory = new MetroFramework.Controls.MetroLabel();
            this.MainForm_btn_send = new MetroFramework.Controls.MetroButton();
            this.MainForm_lbl_area = new MetroFramework.Controls.MetroLabel();
            this.MainForm_lbl_line = new MetroFramework.Controls.MetroLabel();
            this.MainForm_lbl_shift = new MetroFramework.Controls.MetroLabel();
            this.MainForm_lbl_product = new MetroFramework.Controls.MetroLabel();
            this.MainForm_txtbox_remark = new MetroFramework.Controls.MetroTextBox();
            this.MainForm_lbl_remark1 = new MetroFramework.Controls.MetroLabel();
            this.MainForm_lbl_datetimes = new MetroFramework.Controls.MetroLabel();
            this.MainForm_lbl_datetime = new MetroFramework.Controls.MetroLabel();
            this.MainForm_cmbbox_product = new MetroFramework.Controls.MetroComboBox();
            this.MainForm_cmbbox_shift = new MetroFramework.Controls.MetroComboBox();
            this.MainForm_cmbbox_line = new MetroFramework.Controls.MetroComboBox();
            this.MainForm_cmbbox_area = new MetroFramework.Controls.MetroComboBox();
            this.MainForm_cmbbox_factory = new MetroFramework.Controls.MetroComboBox();
            this.MainForm_chkbox_telegram = new MetroFramework.Controls.MetroCheckBox();
            this.MainForm_chkbox_sms = new MetroFramework.Controls.MetroCheckBox();
            this.MainForm_btn_settings = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.MainForm_lbl_title = new System.Windows.Forms.Label();
            this.time_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // MainForm_lbl_factory
            // 
            this.MainForm_lbl_factory.AutoSize = true;
            this.MainForm_lbl_factory.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_factory.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_factory.Location = new System.Drawing.Point(30, 106);
            this.MainForm_lbl_factory.Name = "MainForm_lbl_factory";
            this.MainForm_lbl_factory.Size = new System.Drawing.Size(85, 25);
            this.MainForm_lbl_factory.TabIndex = 20;
            this.MainForm_lbl_factory.Text = "Factory :";
            // 
            // MainForm_btn_send
            // 
            this.MainForm_btn_send.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.MainForm_btn_send.Location = new System.Drawing.Point(637, 329);
            this.MainForm_btn_send.Name = "MainForm_btn_send";
            this.MainForm_btn_send.Size = new System.Drawing.Size(121, 39);
            this.MainForm_btn_send.TabIndex = 10;
            this.MainForm_btn_send.Text = "&Send";
            this.MainForm_btn_send.UseSelectable = true;
            this.MainForm_btn_send.Click += new System.EventHandler(this.MainForm_btn_send_Click);
            // 
            // MainForm_lbl_area
            // 
            this.MainForm_lbl_area.AutoSize = true;
            this.MainForm_lbl_area.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_area.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_area.Location = new System.Drawing.Point(30, 151);
            this.MainForm_lbl_area.Name = "MainForm_lbl_area";
            this.MainForm_lbl_area.Size = new System.Drawing.Size(62, 25);
            this.MainForm_lbl_area.TabIndex = 21;
            this.MainForm_lbl_area.Text = "Area :";
            // 
            // MainForm_lbl_line
            // 
            this.MainForm_lbl_line.AutoSize = true;
            this.MainForm_lbl_line.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_line.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_line.Location = new System.Drawing.Point(30, 196);
            this.MainForm_lbl_line.Name = "MainForm_lbl_line";
            this.MainForm_lbl_line.Size = new System.Drawing.Size(57, 25);
            this.MainForm_lbl_line.TabIndex = 22;
            this.MainForm_lbl_line.Text = "Line :";
            // 
            // MainForm_lbl_shift
            // 
            this.MainForm_lbl_shift.AutoSize = true;
            this.MainForm_lbl_shift.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_shift.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_shift.Location = new System.Drawing.Point(332, 106);
            this.MainForm_lbl_shift.Name = "MainForm_lbl_shift";
            this.MainForm_lbl_shift.Size = new System.Drawing.Size(62, 25);
            this.MainForm_lbl_shift.TabIndex = 24;
            this.MainForm_lbl_shift.Text = "Shift :";
            // 
            // MainForm_lbl_product
            // 
            this.MainForm_lbl_product.AutoSize = true;
            this.MainForm_lbl_product.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_product.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_product.Location = new System.Drawing.Point(332, 155);
            this.MainForm_lbl_product.Name = "MainForm_lbl_product";
            this.MainForm_lbl_product.Size = new System.Drawing.Size(89, 25);
            this.MainForm_lbl_product.TabIndex = 25;
            this.MainForm_lbl_product.Text = "Product :";
            // 
            // MainForm_txtbox_remark
            // 
            // 
            // 
            // 
            this.MainForm_txtbox_remark.CustomButton.Image = null;
            this.MainForm_txtbox_remark.CustomButton.Location = new System.Drawing.Point(357, 1);
            this.MainForm_txtbox_remark.CustomButton.Name = "";
            this.MainForm_txtbox_remark.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.MainForm_txtbox_remark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MainForm_txtbox_remark.CustomButton.TabIndex = 1;
            this.MainForm_txtbox_remark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MainForm_txtbox_remark.CustomButton.UseSelectable = true;
            this.MainForm_txtbox_remark.CustomButton.Visible = false;
            this.MainForm_txtbox_remark.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MainForm_txtbox_remark.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.MainForm_txtbox_remark.Lines = new string[0];
            this.MainForm_txtbox_remark.Location = new System.Drawing.Point(125, 241);
            this.MainForm_txtbox_remark.MaxLength = 32767;
            this.MainForm_txtbox_remark.Multiline = true;
            this.MainForm_txtbox_remark.Name = "MainForm_txtbox_remark";
            this.MainForm_txtbox_remark.PasswordChar = '\0';
            this.MainForm_txtbox_remark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MainForm_txtbox_remark.SelectedText = "";
            this.MainForm_txtbox_remark.SelectionLength = 0;
            this.MainForm_txtbox_remark.SelectionStart = 0;
            this.MainForm_txtbox_remark.ShortcutsEnabled = true;
            this.MainForm_txtbox_remark.Size = new System.Drawing.Size(483, 127);
            this.MainForm_txtbox_remark.TabIndex = 6;
            this.MainForm_txtbox_remark.UseSelectable = true;
            this.MainForm_txtbox_remark.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MainForm_txtbox_remark.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MainForm_lbl_remark1
            // 
            this.MainForm_lbl_remark1.AutoSize = true;
            this.MainForm_lbl_remark1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_remark1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_remark1.Location = new System.Drawing.Point(29, 241);
            this.MainForm_lbl_remark1.Name = "MainForm_lbl_remark1";
            this.MainForm_lbl_remark1.Size = new System.Drawing.Size(87, 25);
            this.MainForm_lbl_remark1.TabIndex = 23;
            this.MainForm_lbl_remark1.Text = "Remark :";
            // 
            // MainForm_lbl_datetimes
            // 
            this.MainForm_lbl_datetimes.AutoSize = true;
            this.MainForm_lbl_datetimes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_datetimes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MainForm_lbl_datetimes.Location = new System.Drawing.Point(631, 72);
            this.MainForm_lbl_datetimes.Name = "MainForm_lbl_datetimes";
            this.MainForm_lbl_datetimes.Size = new System.Drawing.Size(19, 25);
            this.MainForm_lbl_datetimes.TabIndex = 9;
            this.MainForm_lbl_datetimes.Text = "-";
            // 
            // MainForm_lbl_datetime
            // 
            this.MainForm_lbl_datetime.AutoSize = true;
            this.MainForm_lbl_datetime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainForm_lbl_datetime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MainForm_lbl_datetime.Location = new System.Drawing.Point(631, 42);
            this.MainForm_lbl_datetime.Name = "MainForm_lbl_datetime";
            this.MainForm_lbl_datetime.Size = new System.Drawing.Size(122, 25);
            this.MainForm_lbl_datetime.TabIndex = 26;
            this.MainForm_lbl_datetime.Text = "Date / Time :";
            // 
            // MainForm_cmbbox_product
            // 
            this.MainForm_cmbbox_product.FormattingEnabled = true;
            this.MainForm_cmbbox_product.ItemHeight = 23;
            this.MainForm_cmbbox_product.Location = new System.Drawing.Point(427, 151);
            this.MainForm_cmbbox_product.Name = "MainForm_cmbbox_product";
            this.MainForm_cmbbox_product.Size = new System.Drawing.Size(181, 29);
            this.MainForm_cmbbox_product.TabIndex = 8;
            this.MainForm_cmbbox_product.UseSelectable = true;
            // 
            // MainForm_cmbbox_shift
            // 
            this.MainForm_cmbbox_shift.FormattingEnabled = true;
            this.MainForm_cmbbox_shift.ItemHeight = 23;
            this.MainForm_cmbbox_shift.Location = new System.Drawing.Point(427, 102);
            this.MainForm_cmbbox_shift.Name = "MainForm_cmbbox_shift";
            this.MainForm_cmbbox_shift.Size = new System.Drawing.Size(181, 29);
            this.MainForm_cmbbox_shift.TabIndex = 7;
            this.MainForm_cmbbox_shift.UseSelectable = true;
            // 
            // MainForm_cmbbox_line
            // 
            this.MainForm_cmbbox_line.FormattingEnabled = true;
            this.MainForm_cmbbox_line.ItemHeight = 23;
            this.MainForm_cmbbox_line.Location = new System.Drawing.Point(125, 192);
            this.MainForm_cmbbox_line.Name = "MainForm_cmbbox_line";
            this.MainForm_cmbbox_line.Size = new System.Drawing.Size(181, 29);
            this.MainForm_cmbbox_line.TabIndex = 5;
            this.MainForm_cmbbox_line.UseSelectable = true;
            // 
            // MainForm_cmbbox_area
            // 
            this.MainForm_cmbbox_area.FormattingEnabled = true;
            this.MainForm_cmbbox_area.ItemHeight = 23;
            this.MainForm_cmbbox_area.Location = new System.Drawing.Point(125, 147);
            this.MainForm_cmbbox_area.Name = "MainForm_cmbbox_area";
            this.MainForm_cmbbox_area.Size = new System.Drawing.Size(181, 29);
            this.MainForm_cmbbox_area.TabIndex = 4;
            this.MainForm_cmbbox_area.UseSelectable = true;
            // 
            // MainForm_cmbbox_factory
            // 
            this.MainForm_cmbbox_factory.FormattingEnabled = true;
            this.MainForm_cmbbox_factory.ItemHeight = 23;
            this.MainForm_cmbbox_factory.Location = new System.Drawing.Point(125, 102);
            this.MainForm_cmbbox_factory.Name = "MainForm_cmbbox_factory";
            this.MainForm_cmbbox_factory.Size = new System.Drawing.Size(181, 29);
            this.MainForm_cmbbox_factory.TabIndex = 3;
            this.MainForm_cmbbox_factory.UseSelectable = true;
            // 
            // MainForm_chkbox_telegram
            // 
            this.MainForm_chkbox_telegram.AutoSize = true;
            this.MainForm_chkbox_telegram.Checked = true;
            this.MainForm_chkbox_telegram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainForm_chkbox_telegram.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.MainForm_chkbox_telegram.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.MainForm_chkbox_telegram.Location = new System.Drawing.Point(689, 188);
            this.MainForm_chkbox_telegram.Name = "MainForm_chkbox_telegram";
            this.MainForm_chkbox_telegram.Size = new System.Drawing.Size(108, 25);
            this.MainForm_chkbox_telegram.TabIndex = 1;
            this.MainForm_chkbox_telegram.TabStop = false;
            this.MainForm_chkbox_telegram.Text = "Telegram";
            this.MainForm_chkbox_telegram.UseSelectable = true;
            // 
            // MainForm_chkbox_sms
            // 
            this.MainForm_chkbox_sms.AutoSize = true;
            this.MainForm_chkbox_sms.Checked = true;
            this.MainForm_chkbox_sms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainForm_chkbox_sms.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.MainForm_chkbox_sms.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.MainForm_chkbox_sms.Location = new System.Drawing.Point(689, 230);
            this.MainForm_chkbox_sms.Name = "MainForm_chkbox_sms";
            this.MainForm_chkbox_sms.Size = new System.Drawing.Size(65, 25);
            this.MainForm_chkbox_sms.TabIndex = 2;
            this.MainForm_chkbox_sms.TabStop = false;
            this.MainForm_chkbox_sms.Text = "SMS";
            this.MainForm_chkbox_sms.UseSelectable = true;
            // 
            // MainForm_btn_settings
            // 
            this.MainForm_btn_settings.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.MainForm_btn_settings.Location = new System.Drawing.Point(637, 121);
            this.MainForm_btn_settings.Name = "MainForm_btn_settings";
            this.MainForm_btn_settings.Size = new System.Drawing.Size(121, 39);
            this.MainForm_btn_settings.TabIndex = 11;
            this.MainForm_btn_settings.Text = "S&ettings";
            this.MainForm_btn_settings.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MainForm_btn_settings.UseSelectable = true;
            this.MainForm_btn_settings.Click += new System.EventHandler(this.MainForm_btn_settings_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(637, 182);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(45, 38);
            this.metroPanel1.TabIndex = 50;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(638, 230);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(45, 38);
            this.metroPanel2.TabIndex = 51;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // MainForm_lbl_title
            // 
            this.MainForm_lbl_title.AutoSize = true;
            this.MainForm_lbl_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainForm_lbl_title.Location = new System.Drawing.Point(30, 30);
            this.MainForm_lbl_title.Name = "MainForm_lbl_title";
            this.MainForm_lbl_title.Size = new System.Drawing.Size(383, 42);
            this.MainForm_lbl_title.TabIndex = 50;
            this.MainForm_lbl_title.Text = "Alert Notification System";
            // 
            // time_timer
            // 
            this.time_timer.Enabled = true;
            this.time_timer.Interval = 1000;
            this.time_timer.Tick += new System.EventHandler(this.time_timer_Tick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.MainForm_btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 398);
            this.Controls.Add(this.MainForm_lbl_title);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.MainForm_btn_settings);
            this.Controls.Add(this.MainForm_chkbox_sms);
            this.Controls.Add(this.MainForm_chkbox_telegram);
            this.Controls.Add(this.MainForm_txtbox_remark);
            this.Controls.Add(this.MainForm_lbl_datetimes);
            this.Controls.Add(this.MainForm_lbl_line);
            this.Controls.Add(this.MainForm_lbl_datetime);
            this.Controls.Add(this.MainForm_lbl_product);
            this.Controls.Add(this.MainForm_cmbbox_product);
            this.Controls.Add(this.MainForm_lbl_area);
            this.Controls.Add(this.MainForm_cmbbox_shift);
            this.Controls.Add(this.MainForm_lbl_shift);
            this.Controls.Add(this.MainForm_cmbbox_line);
            this.Controls.Add(this.MainForm_lbl_factory);
            this.Controls.Add(this.MainForm_cmbbox_area);
            this.Controls.Add(this.MainForm_lbl_remark1);
            this.Controls.Add(this.MainForm_cmbbox_factory);
            this.Controls.Add(this.MainForm_btn_send);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(872, 398);
            this.MinimumSize = new System.Drawing.Size(872, 398);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_factory;
        private MetroFramework.Controls.MetroButton MainForm_btn_send;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_area;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_line;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_shift;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_product;
        private MetroFramework.Controls.MetroTextBox MainForm_txtbox_remark;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_remark1;
        private MetroFramework.Controls.MetroComboBox MainForm_cmbbox_factory;
        private MetroFramework.Controls.MetroComboBox MainForm_cmbbox_product;
        private MetroFramework.Controls.MetroComboBox MainForm_cmbbox_shift;
        private MetroFramework.Controls.MetroComboBox MainForm_cmbbox_line;
        private MetroFramework.Controls.MetroComboBox MainForm_cmbbox_area;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_datetimes;
        private MetroFramework.Controls.MetroLabel MainForm_lbl_datetime;
        private MetroFramework.Controls.MetroCheckBox MainForm_chkbox_telegram;
        private MetroFramework.Controls.MetroCheckBox MainForm_chkbox_sms;
        private MetroFramework.Controls.MetroButton MainForm_btn_settings;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label MainForm_lbl_title;
        private System.Windows.Forms.Timer time_timer;
    }
}

