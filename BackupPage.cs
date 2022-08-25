using AutoBackup.Properties;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup
{
    public partial class BackupPage : Form
    {
        //目前的資料夾路徑
        private string Directory_History = "";
        //(左)主要選取的資料夾
        private string SelectedFolder = "";
        //目前正在比較的備份檔案路徑
        private string SelectedBackupPath = "";

        public BackupPage()
        {
            InitializeComponent();

            //*********委託***********
            FolderList_gdv.CellClick += Folder_gdv_buttonClick;
            FolderList_gdv.CellClick += FolderList_gdv_OnCellSelected;

            Compare_current_dgv.CellContentDoubleClick += Compare_current_dgv_OnCellClicked;

        }

        public List<string> FolderList = new List<string>();
        private void BackupPage_Load(object sender, EventArgs e)
        {
            //讀取清單
            LoadFoldersList();

        }


        //新增要備份的資料夾
        private void AddFolder_btn_Click(object sender, EventArgs e)
        {
            //瀏覽器
            folderBrowserDialog1.ShowDialog();
            string _selectedFolder = folderBrowserDialog1.SelectedPath;

            //*****[存檔塞選]檢查這資料夾有沒有重複或空白*****
            #region
            string path = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt");

            List<string> _data = AppManager.Load_string(path);
            if (_data == null) { _data = new List<string>(); }

            if (_selectedFolder != null && _selectedFolder != "" &&
                (_data.Find(x => x == _selectedFolder)) == null)
            {

                //存檔
                AppManager.SaveData<string>(_selectedFolder + "\n");
            }
            #endregion
            //**********************************

            //更新清單列表
            LoadFoldersList();
        }

        //新增要備份的檔案
        private void AddFile_btn_Click(object sender, EventArgs e)
        {
            //瀏覽器
            openFileDialog1.ShowDialog();
            string _selectedFolder = openFileDialog1.FileName;

            //*****[存檔塞選]檢查這資料夾有沒有重複或空白*****
            #region
            string path = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt");

            List<string> _data = AppManager.Load_string(path);
            if (_data == null) { _data = new List<string>(); }

            if (_selectedFolder != null && _selectedFolder != "" &&
                (_data.Find(x => x == _selectedFolder)) == null)
            {

                //存檔
                AppManager.SaveData<string>(_selectedFolder + "\n");
            }
            #endregion
            //**********************************

            //更新清單列表
            LoadFoldersList();
        }


        //讀取資料夾清單
        private void LoadFoldersList()
        {
            //先清空列表*******
            FolderList_gdv.Rows.Clear();
            //****************
            List<string> FolderList = new List<string>();
            string path = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt");

            if (File.Exists(path))
            {
                FolderList = AppManager.Load_string(path);

                //把資料夾列出來:
                foreach (string s in FolderList)
                {
                    //System.Diagnostics.Debug.Print("讀取結果" + s);
                    //資料夾名稱
                    string _folderName = Path.GetFileName(s);

                    string[] row = new string[] { _folderName, s };
                    FolderList_gdv.Rows.Add(row);
                }

            }

        }

        private void LoadFoldersList(DataGridView gdv, string path,Label fileCountLabel)
        {
            //if (File.Exists(path))
            if (Directory.Exists(path))
            {
                //先清空列表*******
                gdv.Rows.Clear();
                //****************

                //展示第一層所有資料夾&檔案
                DirectoryInfo info = new DirectoryInfo(path);
                //資料夾
                foreach (DirectoryInfo s in info.GetDirectories())
                {
                    //System.Diagnostics.Debug.Print("讀取結果" + s);
                    //資料夾名稱
                    string _folderName = Path.GetFileName(s.FullName);

                    string[] row = new string[] { _folderName, s.FullName };
                    gdv.Rows.Add(row);
                }

                //文件檔案
                foreach (FileInfo s in info.GetFiles())
                {
                    //System.Diagnostics.Debug.Print("讀取結果" + s);
                    //資料夾名稱
                    string _folderName = Path.GetFileName(s.FullName);

                    string[] row = new string[] { _folderName, s.FullName };
                    gdv.Rows.Add(row);
                }
                //檔案數量
                fileCountLabel.Text = "檔案數量:"+(info.GetFiles().Length+info.GetDirectories().Length).ToString();
            }

        }

        //案到資料夾列表按鈕=>打開對應資料夾:
        private void Folder_gdv_buttonClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                string _path = FolderList_gdv.SelectedCells[0].Value.ToString();
                //打開該資料夾
                Process.Start("explorer.exe", _path);
            }

        }

        //(左)資料夾選取
        private void FolderList_gdv_OnCellSelected(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //點擊第一排時(資料夾名稱時)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewRow seletedRow = FolderList_gdv.Rows[e.RowIndex];

                //取得path欄位資料
                Debug.Print(seletedRow.Cells[1].Value.ToString());

                //紀錄目前主要資料夾
                SelectedFolder = seletedRow.Cells[1].Value.ToString();

                //TODO-展示對比資料----------------------
                ShowContrast(FolderList_gdv,seletedRow.Cells[1].Value.ToString());
                //---------------------------------
            }
        }

        //current(副)資料夾選取(雙擊)
        private void Compare_current_dgv_OnCellClicked(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            //點擊第一排時(資料夾名稱時)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewRow seletedRow = Compare_current_dgv.Rows[e.RowIndex];

                //取得path欄位資料
                Debug.Print(seletedRow.Cells[1].Value.ToString());

                //是資料夾才進一步顯示
                if (Directory.Exists(seletedRow.Cells[1].Value.ToString()))
                {
                    //TODO-展示對比資料----------------------
                    ShowContrast(Compare_current_dgv, seletedRow.Cells[1].Value.ToString());
                    //OpenCompareListFolder(seletedRow.Cells[1].Value.ToString());
                    //---------------------------------
                }

            }

        }

        //按下"備份"按鈕
        private void DoBackup_btn_Click(object sender, EventArgs e)
        {
            AppManager.DoBackup();
            //完成後關機:
            if (AutoShutDown_checkbox.Checked)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else {
                //打開備份存放點資料夾:
                System.Diagnostics.Process.Start(Settings.Default["BackupStoragePath"].ToString());
            }
            /*
            CopyProgessForm copyProgessForm = new CopyProgessForm();
            copyProgessForm.Show();
            copyProgessForm.worker.RunWorkerAsync();*/
        }

        //移除清單中的資料位置
        private void Remove_btn_Click(object sender, EventArgs e)
        {
            //讀取清單資料
            List<string> _data = AppManager.Load_string(Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt"));

            //從中移除選取項目
            string target = FolderList_gdv.Rows[FolderList_gdv.CurrentRow.Index].Cells[1].Value.ToString();
            _data.Remove(_data.Find(v => v == target));

            //存檔
            AppManager.SaveData_overWrite(_data);
            //刷新
            LoadFoldersList();


        }

        //覆蓋原檔案

        //顯示檔案對比
        private void ShowContrast(DataGridView dgv, string target)
        {
            //清空***
            Compare_current_dgv.Rows.Clear();
            Compare_Past_dgv.Rows.Clear();
            //*******

            //紀錄目前位置
            Directory_History = target;

            //取得選取的資料夾路徑
            LoadFoldersList(Compare_current_dgv, target,CurrentFileCount_label);

            //打開舊檔 列出
            //找到資料夾最後編輯的備份檔
            string BackupPath = Settings.Default["BackupStoragePath"].ToString();

            //組合主資料夾路徑
            /*
            string MainPath = Path.Combine(BackupPath, "MyBackUP");
            string folderName = Path.GetFileName(target); //資料夾名稱
            string folderPath = Path.Combine(MainPath, folderName); //該筆資料的次資料夾
            */
            //備份的主目錄
            string MainPath = Path.Combine(BackupPath, "MyBackUP");
            string folderName = Path.GetFileName(SelectedFolder);
            string folderPath = Path.Combine(MainPath, folderName);
            //string _subfolderName = target.Substring(Path.GetFileName(SelectedFolder).ToString().Length+1).Replace(Path.GetFileName(SelectedFolder).ToString(),"");
            string _subfolderName = target.Replace(SelectedFolder, "");

            //附上日期的目錄
            //

            //判斷資料夾是否存在 (備份的主目錄)
            if (Directory.Exists(folderPath))
            {
                //依日期尋找資料夾--------------
                DirectoryInfo info = new DirectoryInfo(folderPath);
                DirectoryInfo[] dateTimes = info.GetDirectories();
                dateTimes = info.GetDirectories().OrderByDescending(x => x.CreationTime).ToArray();

                target = dateTimes[0].FullName+_subfolderName;
                //紀錄路徑
                SelectedBackupPath = target;
                //------------------------------
                LoadFoldersList(Compare_Past_dgv, target,PastFileCount_label);


                #region 顯示對比=> 
                //取得current GDV的資料
                List<string> CurrentFile_name = new List<string>();
                foreach (DataGridViewRow row in Compare_current_dgv.Rows) {
                    CurrentFile_name.Add(row.Cells[0].Value.ToString());
                }
                //取得Past GDV的資料
                List<string> PastFile_name = new List<string>();
                foreach (DataGridViewRow row in Compare_Past_dgv.Rows)
                {
                    PastFile_name.Add(row.Cells[0].Value.ToString());
                }
                //if(current有，past沒有)=>current資料呈綠色
                var _greenList = CurrentFile_name.Except(PastFile_name);
                foreach (DataGridViewRow row in Compare_current_dgv.Rows) {
                    if (_greenList.ToList().Exists(x=>x==row.Cells[0].Value.ToString())) {
                        row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                }
                //if(current沒有，past有)=>past資料呈紅色
                var _redList = PastFile_name.Except(CurrentFile_name);
                foreach (DataGridViewRow row in Compare_Past_dgv.Rows)
                {
                    if (_redList.ToList().Exists(x => x == row.Cells[0].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                }
                #endregion
            }
            else {
                //MessageBox.Show("路徑錯誤");
                PastFileCount_label.Text = "無資料";
            }
        }

        //在比較欄位打開資料夾??
        private void OpenCompareListFolder(string _folderName) {

            //在Compare_Past_dgv找到資料夾
            foreach (DataGridViewRow row in Compare_Past_dgv.Rows) {

                //找到對應資料夾
                if (row.Cells[0].Value.ToString() == _folderName)
                {
                    //刷新dgv
                    LoadFoldersList(Compare_Past_dgv,row.Cells[1].Value.ToString(),PastFileCount_label);

                    break;
                }

                //找不到對應資料夾
                else {
                    Compare_Past_dgv.Rows.Clear();
                    PastFileCount_label.Text = "";
                }
            }
        }

        //回上一個資料夾按鈕
        private void DirectoryUP_btn_Click(object sender, EventArgs e)
        {
            //紀錄不為空，且最大不能返回超過目前主要選擇的資料夾
            if (Directory_History!="" && Directory_History!= SelectedFolder) {
                Directory_History = Directory.GetParent(Directory_History).ToString();
                ShowContrast(Compare_current_dgv,Directory_History);
                
            }
        }



        //單向還原按鈕
        private void Copy_Back_btn_Click(object sender, EventArgs e)
        {
            //取得選取的項目的路徑位置
            List<string> _SelectedFolder = new List<string>();
            foreach (DataGridViewCell cell in Compare_Past_dgv.SelectedCells) {
                //複製檔案
                AppManager.Copy_FileAndFolder(cell.OwningRow.Cells[1].Value.ToString(),Directory_History);
            }
            //複製至current
            Debug.Print("Directory_History: " + Directory_History);

            //刷新版面:
            //LoadFoldersList(Compare_current_dgv,Directory_History,CurrentFileCount_label);
            ShowContrast(Compare_current_dgv,Directory_History);

        }

        //從備份檔案複製檔案覆蓋目前的
        private void Copy_back_All_btn_Click(object sender, EventArgs e)
        {
            //AppManager.Copy_FileAndFolder(SelectedBackupPath,Directory_History);
            foreach (DirectoryInfo info in new DirectoryInfo(SelectedBackupPath).GetDirectories()) {
                AppManager.Copy_FileAndFolder(info.FullName,Directory_History);
            }
            foreach (FileInfo info in new DirectoryInfo(SelectedBackupPath).GetFiles())
            {
                AppManager.Copy_FileAndFolder(info.FullName, Directory_History);
            }
            ShowContrast(Compare_current_dgv, Directory_History);

        }

        private void Compare_current_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FolderList_gdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
