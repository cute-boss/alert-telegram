using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using NetTelebot;
using NetTelebot.Result;
using NetTelebot.Type;
using MetroFramework.Forms;
using System.IO.Ports;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;

namespace ANSv1
{
    public partial class MainForm : MetroForm
    {
        private long? ChatId = 0;
        private string Token = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Splash splash = new Splash();
            //splash.ShowDialog();

            ChatId = Convert.ToInt64(ConfigurationManager.AppSettings["ChatId"]);
            Token = ConfigurationManager.AppSettings["Token"];
            MainForm_lbl_datetimes.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");

            /* Bind factory */
            MainForm_cmbbox_factory.ValueMember = "factory";
            MainForm_cmbbox_factory.DisplayMember = "factory";
            var list1 = new[] { 
                new { factory = "FAC 1"},
                new { factory = "FAC 2"},
                new { factory = "FAC 3"}
            };
            MainForm_cmbbox_factory.DataSource = list1;

            /* Bind area */
            MainForm_cmbbox_area.ValueMember = "area";
            MainForm_cmbbox_area.DisplayMember = "area";
            var list2 = new[] { 
                new { area = "WELDING"},
                new { area = "PACKAGING"},
                new { area = "SPRAY PAINT"}
            };
            MainForm_cmbbox_area.DataSource = list2;

            /* Bind line */
            MainForm_cmbbox_line.ValueMember = "line";
            MainForm_cmbbox_line.DisplayMember = "line";
            var list3 = new[] { 
                new { line = "LINE 1"},
                new { line = "LINE 2"},
                new { line = "LINE 3"}
            };
            MainForm_cmbbox_line.DataSource = list3;

            /* Bind shift */
            MainForm_cmbbox_shift.ValueMember = "shift";
            MainForm_cmbbox_shift.DisplayMember = "shift";
            var list4 = new[] { 
                new { shift = "MORNING"},
                new { shift = "NIGHT"},
            };
            MainForm_cmbbox_shift.DataSource = list4;

            /* Bind product */
            MainForm_cmbbox_product.ValueMember = "product";
            MainForm_cmbbox_product.DisplayMember = "product";
            var list5 = new[] { 
                new { product = "AX-100"},
                new { product = "AW-100"},
            };
            MainForm_cmbbox_product.DataSource = list5;
        }

        /* Send button */
        private void MainForm_btn_send_Click(object sender, EventArgs e)
        {
            string factory = MainForm_cmbbox_factory.SelectedValue.ToString();
            string area = MainForm_cmbbox_area.SelectedValue.ToString();
            string line = MainForm_cmbbox_line.SelectedValue.ToString();
            string shift = MainForm_cmbbox_shift.SelectedValue.ToString();
            string product = MainForm_cmbbox_product.SelectedValue.ToString();
            string remark = MainForm_txtbox_remark.Text;
            string dateTime = MainForm_lbl_datetimes.Text;
            string msg = "Date/Time: " + dateTime + "\nFactory: " + factory + "\nArea: " + area + "\nLine: " + line + "\nShift: " + shift + "\nProduct: " + product + "\nRemark: " + remark;

            /* Display message when none checkbox is ticked */
            if (!MainForm_chkbox_telegram.Checked && !MainForm_chkbox_sms.Checked)
            {
                MetroFramework.MetroMessageBox.Show(this, "No checkbox is selected.", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            #region Telegram

            if (MainForm_chkbox_telegram.Checked)
            {
                var Client = new TelegramBotClient()
                {
                    Token = Token
                };

                /* Proceed to send message to chat id when connected to telegram API */
                if (Common.CheckConnection())
                {
                    Client.SendMessage(ChatId, msg);
                     
                    MetroFramework.MetroMessageBox.Show(this, "Message sent to the Telegram.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Message not sent to the Telegram. Please check your internet connections.", "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            #endregion Telegram

            #region SMS

            if (MainForm_chkbox_sms.Checked)
            {
                string portName = System.Configuration.ConfigurationManager.AppSettings["Port"];
                string hp = System.Configuration.ConfigurationManager.AppSettings["Hp"];
                int baudRate = 19200, timeout = 300;

                GsmCommMain com = new GsmCommMain(portName, baudRate, timeout);

                try
                {
                    com.Open();

                    if (com.IsConnected())
                    {
                        /* Send SMS when success connect */
                        SmsSubmitPdu ssp = new SmsSubmitPdu(msg, hp);
                        com.SendMessage(ssp);
                        com.Close();

                        MetroFramework.MetroMessageBox.Show(this, "Message sent to the SMS.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        com.Close();

                        MetroFramework.MetroMessageBox.Show(this, "Message not sent to the SMS. Please check your connections.", "Error!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Message not sent to the SMS. Please check your configurations.", "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            #endregion SMS
        }

        /* Settings button */
        private void MainForm_btn_settings_Click(object sender, EventArgs e)
        {
            Settings stg = new Settings();
            stg.ShowDialog();
        }

        /* Time timer */
        private void time_timer_Tick(object sender, EventArgs e)
        {
            MainForm_lbl_datetimes.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
    }
}
