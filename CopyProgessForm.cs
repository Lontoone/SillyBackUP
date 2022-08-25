using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace AutoBackup
{
    public partial class CopyProgessForm : Form
    {

        public BackgroundWorker worker = new BackgroundWorker();

        public CopyProgessForm()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_doWork;
        }

        private void Worker_doWork(object sender, DoWorkEventArgs e) {
            //CopyFile();
        }


        void CopyFile(string source, string des) {
            FileStream fsOut = new FileStream(des, FileMode.Create);
            FileStream fsIn = new FileStream(des, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readBytes;

            while ((readBytes=fsIn.Read(bt,0,bt.Length))>0) {
                fsOut.Write(bt, 0, readBytes);
                worker.ReportProgress((int)(fsIn.Position*100/fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();
        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        private void CopyProgessForm_Load(object sender, EventArgs e)
        {

        }
    }
}
