using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using AutoBackup.Properties;
using Microsoft.Win32;
using System.Windows.Forms;

using Microsoft.VisualBasic.FileIO;

namespace AutoBackup
{
    public class AppManager
    {
        //存檔
        public static void SaveData<T>(T _data)
        {

            //D:\Code_Work\AutoBackup\bin\Debug
            string path = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt");

            FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Read);
            //檔案不存在就建檔
            if (!File.Exists(path))
            {
                File.Create(path);
            }


            Debug.WriteLine(path, _data.ToString());

            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(_data);

            streamWriter.Close();

        }

        public static void SaveData_overWrite(List<string> _data)
        {

            //D:\Code_Work\AutoBackup\bin\Debug
            string path = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt");

            //檔案不存在就建檔
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            Debug.WriteLine(path, _data.ToString());

            File.WriteAllLines(path, _data);

        }
        public static List<string> Load_string(string _path)
        {

            if (File.Exists(_path))
            {
                FileStream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader streamReader = new StreamReader(fileStream);

                List<string> _data = new List<string>();
                string s = string.Empty;

                while ((s = streamReader.ReadLine()) != null)
                {
                    _data.Add(s);
                }

                streamReader.Close();

                return _data;
            }
            else
            {
                System.Diagnostics.Debug.Print("讀不到檔案");
                return null;
            }
        }

        //執行備份動作
        public static void DoBackup()
        {
            //把資料複製到設定中指定位置
            string BackupPath = Settings.Default["BackupStoragePath"].ToString();

            //建立主資料夾
            string MainPath = Path.Combine(BackupPath, "MyBackUP");
            if (!Directory.Exists(MainPath))
            {
                Directory.CreateDirectory(MainPath);
            }

            //建立各個備分文件的資料夾------------
            //讀取資料位置清單
            string path = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "FoldersList.txt");
            List<string> _data = Load_string(path) == null ? new List<string>() : Load_string(path);

            //複製
            for (int i = 0; i < _data.Count; i++)
            {

                //處理資料夾:----------------
                if (Directory.Exists(_data[i]))
                {
                    //檢查檔案有沒有更動:
                    string _backupFolderName = new DirectoryInfo(_data[i]).Name; //資料夾名稱
                    if (!IsFolderModified(_data[i], Path.Combine(MainPath, _backupFolderName))) { continue; }

                    //建立次資料夾------------------------------------
                    string folderName = Path.GetFileName(_data[i]); //資料夾名稱
                    string folderPath = Path.Combine(MainPath, folderName); //該筆資料的次資料夾
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    //備份_上編號---------------------------------
                    DirectoryInfo info = new DirectoryInfo(folderPath);
                    //用日期命名資料夾
                    string _date = DateTime.Now.ToString("MM-dd-yyyy-hh-mm-ss");
                    string folder_copy_path = Path.Combine(folderPath, folderName + _date);//目標資料夾位置
                    Directory.CreateDirectory(folder_copy_path);


                    #region
                    //從最舊的資料夾刪除多出的備分
                    DirectoryInfo[] dateTimes = info.GetDirectories();
                    while (dateTimes.Length > int.Parse(Settings.Default["CopyNumber"].ToString()))
                    {
                        dateTimes = info.GetDirectories().OrderByDescending(x => x.CreationTime).ToArray();
                        dateTimes.Last().Delete(true);
                    }

                    string[] files = System.IO.Directory.GetFiles(_data[i]);

                    //判斷copy模式
                    if ((bool)Settings.Default["HideCopyProcess"])
                    {
                        // Copy the files and overwrite destination files if they already exist.
                        foreach (string s in files)
                        {
                            // Use static Path methods to extract only the file name from the path.
                            string fileName = Path.GetFileName(s);
                            string destFile = Path.Combine(folder_copy_path, fileName);
                            File.Copy(s, destFile, true);

                        }
                    }
                    else
                    {
                        //使用window內建copy模式
                        FileSystem.CopyDirectory(_data[i], folder_copy_path, UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                    #endregion
                }

                //處理單一文件檔--------------
                else if (File.Exists(_data[i]))
                {
                    //檢查檔案有沒有更動:
                    string _backupFileName = Path.GetFileNameWithoutExtension(_data[i]); //檔案名稱
                    string extension = Path.GetExtension(_data[i]);
                    if (!IsFolderModified(_data[i], Path.Combine(MainPath, _backupFileName))) { continue; }

                    //建立次資料夾------------------------------------
                    string folderName = _backupFileName; //資料夾名稱
                    string folderPath = Path.Combine(MainPath, folderName); //該筆資料的次資料夾
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    //備份_上編號---------------------------------
                    DirectoryInfo info = new DirectoryInfo(folderPath);
                    //用日期命名檔案
                    string _date = DateTime.Now.ToString("MM-dd-yyyy-hh-mm-ss");
                    string file_copy_path = Path.Combine(folderPath, folderName + "_" + _date);//目標檔案名稱
                    //Directory.CreateDirectory(file_copy_path);


                    #region
                    //從最舊的資料夾刪除多出的備分
                    FileInfo[] dateTimes = info.GetFiles();
                    while (dateTimes.Length > int.Parse(Settings.Default["CopyNumber"].ToString()))
                    {
                        dateTimes = info.GetFiles().OrderByDescending(x => x.CreationTime).ToArray();
                        dateTimes.Last().Delete();
                    }

                    //判斷copy模式
                    if ((bool)Settings.Default["HideCopyProcess"])
                    {
                        // Copy the files and overwrite destination files if they already exist.
                        // Use static Path methods to extract only the file name from the path.
                        string destFile = file_copy_path + extension;
                        File.Copy(_data[i], destFile, true);
                    }
                    else
                    {
                        //使用window內建copy模式
                        FileSystem.CopyFile(_data[i], file_copy_path + extension, UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                    #endregion
                }
            }

            //-----------------------------------------

        }


        //啟動開機自動執行
        public static void registeAutoStartup(bool IsOpen)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (IsOpen)
            {
                //開啟自動啟動
                reg.SetValue("myAutoBackup", Application.ExecutablePath.ToString());
                Settings.Default["AutoRun"] = true;
            }
            else
            {
                //關閉自動啟動
                reg.DeleteValue("myAutoBackup", false);
                Settings.Default["AutoRun"] = false;
            }
            Settings.Default.Save();
        }

        //複製
        public static void Copy_FileAndFolder(string SourcePath, string destinationPath)
        {
            //取得所有資料夾
            if (Directory.Exists(SourcePath))
            {

                string des = Path.Combine(destinationPath, Path.GetFileName(SourcePath));
                FileSystem.CopyDirectory(SourcePath, des, UIOption.AllDialogs, UICancelOption.DoNothing);
            }

            if (File.Exists(SourcePath))
            {
                string des = Path.Combine(destinationPath, Path.GetFileName(SourcePath));
                FileSystem.CopyFile(SourcePath, des, UIOption.AllDialogs, UICancelOption.DoNothing);
                //File.Copy(sourcePath,des);

            }
        }

        public static bool IsFolderModified(string _folderPath, string _BackupFolder)
        {

            //先查看預設
            if ((string)Settings.Default["AllYN"] == "Y") {
                return true;
            }
            else if ((string)Settings.Default["AllYN"] == "N") {
                return false;
            }

            //比較目前資料夾與備份資料夾修改時間
            if (Directory.GetLastWriteTime(_folderPath) <= Directory.GetLastWriteTime(_BackupFolder))
            {
                DialogResult _dialogResult = MessageBox.Show(_folderPath + "沒有近期更改紀錄，請問還需要備分嗎?ヾ(•ω•`)o", "沒有近期更改紀錄", MessageBoxButtons.OKCancel);
                //仍要備分
                if (_dialogResult == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
    }


}
