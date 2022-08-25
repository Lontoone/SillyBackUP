using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

using AutoBackup.Properties;

namespace AutoBackup
{
    public partial class Setting_Form : Form
    {
        //備份存放位址
        public string BackupStoragePath;

        public Setting_Form()
        {
            InitializeComponent();
        }

        //打開選單
        private void Setting_Form_Load(object sender, EventArgs e)
        {
            //讀取先前設定***************
            BackupStoragePath= Settings.Default["BackupStoragePath"].ToString();
            BackupStoragePath_txt.Text = BackupStoragePath;

            AutoBox_checkbox.Checked = (bool)Settings.Default["AutoRun"];
            HideCopyProcess_ck.Checked = (bool)Settings.Default["HideCopyProcess"];
            CopyNumber_inputbox.Text = Settings.Default["CopyNumber"].ToString();

            if ((string)Settings.Default["AllYN"]=="0")
            {
                ask.Checked = true;
            }
            else if ((string)Settings.Default["AllYN"] == "Y")
            {
                allYes.Checked = true;
            }
            else if ((string)Settings.Default["AllYN"] == "N")
            {
                allNo.Checked = true;
            }
            //*************************
        }

        //瀏覽資料夾按鈕
        private void Browse_btn_Click(object sender, EventArgs e)
        {
            //打開資料夾瀏覽器
            folderBrowserDialog1.ShowDialog();
            //設定
            BackupStoragePath=folderBrowserDialog1.SelectedPath;

            //非空白位址=>保存/顯示
            if (BackupStoragePath != "")
            {
                //顯示textbox
                BackupStoragePath_txt.Text = BackupStoragePath;


                //存儲********************
                Settings.Default["BackupStoragePath"] = BackupStoragePath;
                Settings.Default.Save();
            }
        }

        //開關自動啟動
        private void AutoBox_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            AppManager.registeAutoStartup(AutoBox_checkbox.Checked);
        }

        //隱藏複製跑條
        private void HideCopyProcess_ck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["HideCopyProcess"] = (bool)HideCopyProcess_ck.Checked;
            Settings.Default.Save();
        }

        //備份數量輸入
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int isInt;
            if (int.TryParse(CopyNumber_inputbox.Text, out isInt) && isInt>0)
            {

                Settings.Default["CopyNumber"] = isInt;
                Settings.Default.Save();
            }
            else {
                MessageBox.Show("請輸入大於0的次數");
                CopyNumber_inputbox.Text = Settings.Default["CopyNumber"].ToString();
            }
        }


        //近期無更新操作
        private void AllYN_rb_Change(object sender, EventArgs e)
        {
            if (allNo.Checked)
            {
                Settings.Default["AllYN"] = "N";
            }
            if (allYes.Checked)
            {
                Settings.Default["AllYN"] = "Y";
            }
            if (ask.Checked)
            {
                Settings.Default["AllYN"] = "0";
            }

            Settings.Default.Save();
        }


    }
}

