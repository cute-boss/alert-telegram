namespace ANSv1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Settings_lbl_portName = new MetroFramework.Controls.MetroLabel();
            this.Settings_lbl_hp = new MetroFramework.Controls.MetroLabel();
            this.Settings_txt_hp = new MetroFramework.Controls.MetroTextBox();
            this.Settings_cmbbox_portName = new MetroFramework.Controls.MetroComboBox();
            this.Settings_tabSMS_btn_save = new MetroFramework.Controls.MetroButton();
            this.Settings_lbl_title = new System.Windows.Forms.Label();
            this.Settings_tab = new MetroFramework.Controls.MetroTabControl();
            this.Settings_tabSMS = new MetroFramework.Controls.MetroTabPage();
            this.Settings_tabTelegram = new MetroFramework.Controls.MetroTabPage();
            this.Settings_lbl_Id = new MetroFramework.Controls.MetroLabel();
            this.Settings_tabTelegram_btn_refresh = new MetroFramework.Controls.MetroButton();
            this.Settings_lbl_chatId = new MetroFramework.Controls.MetroLabel();
            this.Settings_tabTelegram_btn_save = new MetroFramework.Controls.MetroButton();
            this.Settings_tab.SuspendLayout();
            this.Settings_tabSMS.SuspendLayout();
            this.Settings_tabTelegram.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings_lbl_portName
            // 
            this.Settings_lbl_portName.AutoSize = true;
            this.Settings_lbl_portName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Settings_lbl_portName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Settings_lbl_portName.Location = new System.Drawing.Point(0, 24);
            this.Settings_lbl_portName.Name = "Settings_lbl_portName";
            this.Settings_lbl_portName.Size = new System.Drawing.Size(113, 25);
            this.Settings_lbl_portName.TabIndex = 20;
            this.Settings_lbl_portName.Text = "Port Name :";
            // 
            // Settings_lbl_hp
            // 
            this.Settings_lbl_hp.AutoSize = true;
            this.Settings_lbl_hp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Settings_lbl_hp.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Settings_lbl_hp.Location = new System.Drawing.Point(0, 74);
            this.Settings_lbl_hp.Name = "Settings_lbl_hp";
            this.Settings_lbl_hp.Size = new System.Drawing.Size(111, 25);
            this.Settings_lbl_hp.TabIndex = 21;
            this.Settings_lbl_hp.Text = "Phone No. :";
            // 
            // Settings_txt_hp
            // 
            // 
            // 
            // 
            this.Settings_txt_hp.CustomButton.Image = null;
            this.Settings_txt_hp.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Settings_txt_hp.CustomButton.Name = "";
            this.Settings_txt_hp.CustomButton.Size = new System.Drawing.Size(28, 29);
            this.Settings_txt_hp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Settings_txt_hp.CustomButton.TabIndex = 1;
            this.Settings_txt_hp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Settings_txt_hp.CustomButton.UseSelectable = true;
            this.Settings_txt_hp.CustomButton.Visible = false;
            this.Settings_txt_hp.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Settings_txt_hp.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.Settings_txt_hp.Lines = new string[0];
            this.Settings_txt_hp.Location = new System.Drawing.Point(119, 71);
            this.Settings_txt_hp.MaxLength = 20;
            this.Settings_txt_hp.Multiline = true;
            this.Settings_txt_hp.Name = "Settings_txt_hp";
            this.Settings_txt_hp.PasswordChar = '\0';
            this.Settings_txt_hp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Settings_txt_hp.SelectedText = "";
            this.Settings_txt_hp.SelectionLength = 0;
            this.Settings_txt_hp.SelectionStart = 0;
            this.Settings_txt_hp.ShortcutsEnabled = true;
            this.Settings_txt_hp.Size = new System.Drawing.Size(165, 35);
            this.Settings_txt_hp.TabIndex = 2;
            this.Settings_txt_hp.UseSelectable = true;
            this.Settings_txt_hp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Settings_txt_hp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Settings_cmbbox_portName
            // 
            this.Settings_cmbbox_portName.FormattingEnabled = true;
            this.Settings_cmbbox_portName.ItemHeight = 23;
            this.Settings_cmbbox_portName.Location = new System.Drawing.Point(119, 24);
            this.Settings_cmbbox_portName.Name = "Settings_cmbbox_portName";
            this.Settings_cmbbox_portName.Size = new System.Drawing.Size(165, 29);
            this.Settings_cmbbox_portName.TabIndex = 1;
            this.Settings_cmbbox_portName.UseSelectable = true;
            // 
            // Settings_tabSMS_btn_save
            // 
            this.Settings_tabSMS_btn_save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Settings_tabSMS_btn_save.Location = new System.Drawing.Point(308, 24);
            this.Settings_tabSMS_btn_save.Name = "Settings_tabSMS_btn_save";
            this.Settings_tabSMS_btn_save.Size = new System.Drawing.Size(85, 82);
            this.Settings_tabSMS_btn_save.TabIndex = 3;
            this.Settings_tabSMS_btn_save.Text = "&Save";
            this.Settings_tabSMS_btn_save.UseSelectable = true;
            this.Settings_tabSMS_btn_save.Click += new System.EventHandler(this.Settings_tabSMS_btn_save_Click);
            // 
            // Settings_lbl_title
            // 
            this.Settings_lbl_title.AutoSize = true;
            this.Settings_lbl_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_lbl_title.Location = new System.Drawing.Point(26, 24);
            this.Settings_lbl_title.Name = "Settings_lbl_title";
            this.Settings_lbl_title.Size = new System.Drawing.Size(134, 42);
            this.Settings_lbl_title.TabIndex = 50;
            this.Settings_lbl_title.Text = "Settings";
            // 
            // Settings_tab
            // 
            this.Settings_tab.Controls.Add(this.Settings_tabSMS);
            this.Settings_tab.Controls.Add(this.Settings_tabTelegram);
            this.Settings_tab.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.Settings_tab.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.Settings_tab.Location = new System.Drawing.Point(33, 72);
            this.Settings_tab.Name = "Settings_tab";
            this.Settings_tab.SelectedIndex = 0;
            this.Settings_tab.Size = new System.Drawing.Size(404, 160);
            this.Settings_tab.TabIndex = 52;
            this.Settings_tab.UseSelectable = true;
            // 
            // Settings_tabSMS
            // 
            this.Settings_tabSMS.Controls.Add(this.Settings_tabSMS_btn_save);
            this.Settings_tabSMS.Controls.Add(this.Settings_txt_hp);
            this.Settings_tabSMS.Controls.Add(this.Settings_cmbbox_portName);
            this.Settings_tabSMS.Controls.Add(this.Settings_lbl_portName);
            this.Settings_tabSMS.Controls.Add(this.Settings_lbl_hp);
            this.Settings_tabSMS.HorizontalScrollbarBarColor = true;
            this.Settings_tabSMS.HorizontalScrollbarHighlightOnWheel = false;
            this.Settings_tabSMS.HorizontalScrollbarSize = 3;
            this.Settings_tabSMS.Location = new System.Drawing.Point(4, 44);
            this.Settings_tabSMS.Name = "Settings_tabSMS";
            this.Settings_tabSMS.Size = new System.Drawing.Size(396, 112);
            this.Settings_tabSMS.TabIndex = 0;
            this.Settings_tabSMS.Text = "SMS";
            this.Settings_tabSMS.VerticalScrollbarBarColor = true;
            this.Settings_tabSMS.VerticalScrollbarHighlightOnWheel = false;
            this.Settings_tabSMS.VerticalScrollbarSize = 3;
            // 
            // Settings_tabTelegram
            // 
            this.Settings_tabTelegram.Controls.Add(this.Settings_lbl_Id);
            this.Settings_tabTelegram.Controls.Add(this.Settings_tabTelegram_btn_refresh);
            this.Settings_tabTelegram.Controls.Add(this.Settings_lbl_chatId);
            this.Settings_tabTelegram.Controls.Add(this.Settings_tabTelegram_btn_save);
            this.Settings_tabTelegram.HorizontalScrollbarBarColor = true;
            this.Settings_tabTelegram.HorizontalScrollbarHighlightOnWheel = false;
            this.Settings_tabTelegram.HorizontalScrollbarSize = 3;
            this.Settings_tabTelegram.Location = new System.Drawing.Point(4, 44);
            this.Settings_tabTelegram.Name = "Settings_tabTelegram";
            this.Settings_tabTelegram.Size = new System.Drawing.Size(396, 112);
            this.Settings_tabTelegram.TabIndex = 1;
            this.Settings_tabTelegram.Text = "Telegram";
            this.Settings_tabTelegram.VerticalScrollbarBarColor = true;
            this.Settings_tabTelegram.VerticalScrollbarHighlightOnWheel = false;
            this.Settings_tabTelegram.VerticalScrollbarSize = 3;
            // 
            // Settings_lbl_Id
            // 
            this.Settings_lbl_Id.AutoSize = true;
            this.Settings_lbl_Id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Settings_lbl_Id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Settings_lbl_Id.Location = new System.Drawing.Point(3, 41);
            this.Settings_lbl_Id.Name = "Settings_lbl_Id";
            this.Settings_lbl_Id.Size = new System.Drawing.Size(0, 0);
            this.Settings_lbl_Id.TabIndex = 10;
            // 
            // Settings_tabTelegram_btn_refresh
            // 
            this.Settings_tabTelegram_btn_refresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Settings_tabTelegram_btn_refresh.Location = new System.Drawing.Point(272, 13);
            this.Settings_tabTelegram_btn_refresh.Name = "Settings_tabTelegram_btn_refresh";
            this.Settings_tabTelegram_btn_refresh.Size = new System.Drawing.Size(121, 36);
            this.Settings_tabTelegram_btn_refresh.TabIndex = 11;
            this.Settings_tabTelegram_btn_refresh.Text = "&Refresh";
            this.Settings_tabTelegram_btn_refresh.UseSelectable = true;
            this.Settings_tabTelegram_btn_refresh.Click += new System.EventHandler(this.Settings_tabTelegram_btn_refresh_Click);
            // 
            // Settings_lbl_chatId
            // 
            this.Settings_lbl_chatId.AutoSize = true;
            this.Settings_lbl_chatId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Settings_lbl_chatId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Settings_lbl_chatId.Location = new System.Drawing.Point(3, 13);
            this.Settings_lbl_chatId.Name = "Settings_lbl_chatId";
            this.Settings_lbl_chatId.Size = new System.Drawing.Size(83, 25);
            this.Settings_lbl_chatId.TabIndex = 50;
            this.Settings_lbl_chatId.Text = "Chat Id :";
            // 
            // Settings_tabTelegram_btn_save
            // 
            this.Settings_tabTelegram_btn_save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Settings_tabTelegram_btn_save.Location = new System.Drawing.Point(272, 66);
            this.Settings_tabTelegram_btn_save.Name = "Settings_tabTelegram_btn_save";
            this.Settings_tabTelegram_btn_save.Size = new System.Drawing.Size(121, 36);
            this.Settings_tabTelegram_btn_save.TabIndex = 12;
            this.Settings_tabTelegram_btn_save.Text = "&Save";
            this.Settings_tabTelegram_btn_save.UseSelectable = true;
            this.Settings_tabTelegram_btn_save.Click += new System.EventHandler(this.Settings_tabTelegram_btn_save_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.Settings_tabSMS_btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 244);
            this.Controls.Add(this.Settings_tab);
            this.Controls.Add(this.Settings_lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 244);
            this.MinimumSize = new System.Drawing.Size(463, 244);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Settings_tab.ResumeLayout(false);
            this.Settings_tabSMS.ResumeLayout(false);
            this.Settings_tabSMS.PerformLayout();
            this.Settings_tabTelegram.ResumeLayout(false);
            this.Settings_tabTelegram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Settings_lbl_portName;
        private MetroFramework.Controls.MetroLabel Settings_lbl_hp;
        private MetroFramework.Controls.MetroTextBox Settings_txt_hp;
        private MetroFramework.Controls.MetroComboBox Settings_cmbbox_portName;
        private MetroFramework.Controls.MetroButton Settings_tabSMS_btn_save;
        private System.Windows.Forms.Label Settings_lbl_title;
        private MetroFramework.Controls.MetroTabControl Settings_tab;
        private MetroFramework.Controls.MetroTabPage Settings_tabSMS;
        private MetroFramework.Controls.MetroTabPage Settings_tabTelegram;
        private MetroFramework.Controls.MetroButton Settings_tabTelegram_btn_save;
        private MetroFramework.Controls.MetroLabel Settings_lbl_chatId;
        private MetroFramework.Controls.MetroButton Settings_tabTelegram_btn_refresh;
        private MetroFramework.Controls.MetroLabel Settings_lbl_Id;
    }
}