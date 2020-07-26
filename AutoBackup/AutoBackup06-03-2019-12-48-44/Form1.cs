using AutoBackup.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup
{
    //起始介面
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            //自動開啟後=>詢問是否執行備分:
            DialogResult IsDoBackup = MessageBox.Show("是否執行備分?", "MYAutoBackUP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (IsDoBackup == DialogResult.Yes)
            {
                AppManager.DoBackup();
            }
            else {
                Application.Exit();
            }
        }

        //開啟設定頁面
        private void Setting_btn_Click(object sender, EventArgs e)
        {
            Form _setting_F = new Setting_Form();
            _setting_F.Show();

            
        }

        //打開備分頁面
        private void OpenBackupPage_btn_Click(object sender, EventArgs e)
        {
            //確認有選擇備份檔案存放位置?
            if (Settings.Default["BackupStoragePath"] != null && Settings.Default["BackupStoragePath"] != "")
            {
                Form _backupPage = new BackupPage();
                _backupPage.Show();
            }
            else {
                MessageBox.Show("未指定備分檔案存放位置，\n請去選項頁面設定");
            }
            
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
