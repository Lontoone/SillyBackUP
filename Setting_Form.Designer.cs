namespace AutoBackup
{
    partial class Setting_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Form));
            this.BackupStoragePath_txt = new System.Windows.Forms.TextBox();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.AutoBox_checkbox = new System.Windows.Forms.CheckBox();
            this.HideCopyProcess_ck = new System.Windows.Forms.CheckBox();
            this.CopyNumber_inputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allYN_rb = new System.Windows.Forms.GroupBox();
            this.allNo = new System.Windows.Forms.RadioButton();
            this.allYes = new System.Windows.Forms.RadioButton();
            this.ask = new System.Windows.Forms.RadioButton();
            this.allYN_rb.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupStoragePath_txt
            // 
            this.BackupStoragePath_txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BackupStoragePath_txt.Location = new System.Drawing.Point(60, 27);
            this.BackupStoragePath_txt.Name = "BackupStoragePath_txt";
            this.BackupStoragePath_txt.Size = new System.Drawing.Size(575, 29);
            this.BackupStoragePath_txt.TabIndex = 1;
            this.BackupStoragePath_txt.TabStop = false;
            this.BackupStoragePath_txt.WordWrap = false;
            // 
            // Browse_btn
            // 
            this.Browse_btn.Location = new System.Drawing.Point(650, 31);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(75, 23);
            this.Browse_btn.TabIndex = 1;
            this.Browse_btn.Text = "瀏覽";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // AutoBox_checkbox
            // 
            this.AutoBox_checkbox.AutoSize = true;
            this.AutoBox_checkbox.Location = new System.Drawing.Point(60, 84);
            this.AutoBox_checkbox.Name = "AutoBox_checkbox";
            this.AutoBox_checkbox.Size = new System.Drawing.Size(72, 16);
            this.AutoBox_checkbox.TabIndex = 3;
            this.AutoBox_checkbox.Text = "開機執行";
            this.AutoBox_checkbox.UseVisualStyleBackColor = true;
            this.AutoBox_checkbox.CheckedChanged += new System.EventHandler(this.AutoBox_checkbox_CheckedChanged);
            // 
            // HideCopyProcess_ck
            // 
            this.HideCopyProcess_ck.AutoSize = true;
            this.HideCopyProcess_ck.Location = new System.Drawing.Point(60, 116);
            this.HideCopyProcess_ck.Name = "HideCopyProcess_ck";
            this.HideCopyProcess_ck.Size = new System.Drawing.Size(72, 16);
            this.HideCopyProcess_ck.TabIndex = 4;
            this.HideCopyProcess_ck.Text = "隱藏進度";
            this.HideCopyProcess_ck.UseVisualStyleBackColor = true;
            this.HideCopyProcess_ck.CheckedChanged += new System.EventHandler(this.HideCopyProcess_ck_CheckedChanged);
            // 
            // CopyNumber_inputbox
            // 
            this.CopyNumber_inputbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CopyNumber_inputbox.Location = new System.Drawing.Point(60, 283);
            this.CopyNumber_inputbox.Name = "CopyNumber_inputbox";
            this.CopyNumber_inputbox.Size = new System.Drawing.Size(82, 29);
            this.CopyNumber_inputbox.TabIndex = 5;
            this.CopyNumber_inputbox.TabStop = false;
            this.CopyNumber_inputbox.WordWrap = false;
            this.CopyNumber_inputbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "備份上限數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "備分檔案存放位置";
            // 
            // allYN_rb
            // 
            this.allYN_rb.Controls.Add(this.allNo);
            this.allYN_rb.Controls.Add(this.allYes);
            this.allYN_rb.Controls.Add(this.ask);
            this.allYN_rb.Location = new System.Drawing.Point(60, 158);
            this.allYN_rb.Name = "allYN_rb";
            this.allYN_rb.Size = new System.Drawing.Size(334, 70);
            this.allYN_rb.TabIndex = 10;
            this.allYN_rb.TabStop = false;
            this.allYN_rb.Text = "近期無更新檔案操作";
            // 
            // allNo
            // 
            this.allNo.AutoSize = true;
            this.allNo.Location = new System.Drawing.Point(230, 30);
            this.allNo.Name = "allNo";
            this.allNo.Size = new System.Drawing.Size(71, 16);
            this.allNo.TabIndex = 2;
            this.allNo.Text = "一律跳過";
            this.allNo.UseVisualStyleBackColor = true;
            this.allNo.CheckedChanged += new System.EventHandler(this.AllYN_rb_Change);
            // 
            // allYes
            // 
            this.allYes.AutoSize = true;
            this.allYes.Location = new System.Drawing.Point(121, 30);
            this.allYes.Name = "allYes";
            this.allYes.Size = new System.Drawing.Size(71, 16);
            this.allYes.TabIndex = 1;
            this.allYes.Text = "一律備份";
            this.allYes.UseVisualStyleBackColor = true;
            this.allYes.CheckedChanged += new System.EventHandler(this.AllYN_rb_Change);
            // 
            // ask
            // 
            this.ask.AutoSize = true;
            this.ask.Checked = true;
            this.ask.Location = new System.Drawing.Point(16, 30);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(83, 16);
            this.ask.TabIndex = 0;
            this.ask.TabStop = true;
            this.ask.Text = "一律詢問我";
            this.ask.UseVisualStyleBackColor = true;
            this.ask.CheckedChanged += new System.EventHandler(this.AllYN_rb_Change);
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allYN_rb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyNumber_inputbox);
            this.Controls.Add(this.HideCopyProcess_ck);
            this.Controls.Add(this.AutoBox_checkbox);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.BackupStoragePath_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting_Form";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Setting_Form_Load);
            this.allYN_rb.ResumeLayout(false);
            this.allYN_rb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BackupStoragePath_txt;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox AutoBox_checkbox;
        private System.Windows.Forms.CheckBox HideCopyProcess_ck;
        private System.Windows.Forms.TextBox CopyNumber_inputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox allYN_rb;
        private System.Windows.Forms.RadioButton allNo;
        private System.Windows.Forms.RadioButton allYes;
        private System.Windows.Forms.RadioButton ask;
    }
}