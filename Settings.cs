using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Configuration;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using NetTelebot;
using NetTelebot.Result;
using NetTelebot.Type;

namespace ANSv1
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            /* Load cmbbox port name */
            if (System.IO.Ports.SerialPort.GetPortNames().Length == 0)
            {
                Settings_txt_hp.Enabled = false;
                MetroFramework.MetroMessageBox.Show(this, "Please plug in your broadband then restart the application.", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                Settings_txt_hp.Enabled = true;
                Settings_cmbbox_portName.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            }

            Settings_lbl_Id.Text = Convert.ToInt64(ConfigurationManager.AppSettings["ChatId"]).ToString();
        }

        /* Click SMS save button */
        private void Settings_tabSMS_btn_save_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            /* Display msg when hp is empty */
            if (Settings_txt_hp.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please insert phone number.", "Warning!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Settings_txt_hp.Focus();
                return;
            }

            #region Check connection & save phone no

            string portName = Settings_cmbbox_portName.SelectedValue.ToString();
            string hp = Settings_txt_hp.Text;
            int baudRate = 19200, timeout = 300;

            GsmCommMain com = new GsmCommMain(portName, baudRate, timeout);

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["Hp"].Value == Settings_txt_hp.Text)
            {
                try
                {
                    com.Open();

                    if (com.IsConnected())
                    {
                        /* Send SMS when success connect */
                        SmsSubmitPdu ssp = new SmsSubmitPdu("Congratulation! Successfully connected.", hp);
                        com.SendMessage(ssp);
                        com.Close();

                        MetroFramework.MetroMessageBox.Show(this, "Success to connect.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Failed to connect. Make sure port name and phone no. are correct.", "Warning!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        com.Close();
                        return;
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Failed to connect. Please check your configurations.", "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    com.Close();
                    return;
                }
            }
            else
            {
                config.AppSettings.SectionInformation.ForceSave = true;
                config.AppSettings.Settings["Port"].Value = Settings_cmbbox_portName.SelectedValue.ToString();
                config.AppSettings.Settings["Hp"].Value = Settings_txt_hp.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MetroFramework.MetroMessageBox.Show(this, "Phone number has been saved.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            #endregion Check connection & save phone no
        }

        /* Click Telegram save button */
        private void Settings_tabTelegram_btn_save_Click(object sender, EventArgs e)
        {
            /* Display message when id is empty. Save id to ip config when id is not empty */
            if (Settings_lbl_Id.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please message bot and click Refresh button.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.SectionInformation.ForceSave = true;
                config.AppSettings.Settings["ChatId"].Value = Settings_lbl_Id.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MetroFramework.MetroMessageBox.Show(this, "Chat id has been saved.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        /* Click Telegram refresh button */
        private void Settings_tabTelegram_btn_refresh_Click(object sender, EventArgs e)
        {
            var bot = new TelegramBotClient()
            {
                Token = ConfigurationManager.AppSettings["Token"]
            };

            /* Update bot when able to connect. Display message when unable to connect */
            if (Common.CheckConnection())
            {
                bot.UpdatesReceived += UpdatesReceived;
                bot.StartCheckingUpdates();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Unable to connect. Please check your internet connections.", "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Display latest chat id from bot side to settings */
        public void UpdatesReceived(object sender, TelegramUpdateEventArgs e)
        {
            foreach (var update in e.Updates)
            {
                if (update.CallbackQuery.Id != null)
                {
                    //ParseCommandInCallbackQuery(update.CallbackQuery);
                    Settings_lbl_Id.Text = update.CallbackQuery.Message.Chat.Id.ToString();
                }
            }
        }

        /*public void ParseCommandInCallbackQuery(CallbackQueryInfo callbackQuery)
        {
            Settings_lbl_Id.Text = callbackQuery.Message.Chat.Id.ToString();
        }*/
    }
}
