namespace AutoBackup
{
    partial class StartForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.Setting_btn = new System.Windows.Forms.Button();
            this.OpenBackupPage_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Setting_btn
            // 
            this.Setting_btn.Location = new System.Drawing.Point(167, 276);
            this.Setting_btn.Name = "Setting_btn";
            this.Setting_btn.Size = new System.Drawing.Size(170, 50);
            this.Setting_btn.TabIndex = 0;
            this.Setting_btn.Text = "選項";
            this.Setting_btn.UseVisualStyleBackColor = true;
            this.Setting_btn.Click += new System.EventHandler(this.Setting_btn_Click);
            // 
            // OpenBackupPage_btn
            // 
            this.OpenBackupPage_btn.Location = new System.Drawing.Point(167, 147);
            this.OpenBackupPage_btn.Name = "OpenBackupPage_btn";
            this.OpenBackupPage_btn.Size = new System.Drawing.Size(170, 50);
            this.OpenBackupPage_btn.TabIndex = 1;
            this.OpenBackupPage_btn.Text = "開始備份";
            this.OpenBackupPage_btn.UseVisualStyleBackColor = true;
            this.OpenBackupPage_btn.Click += new System.EventHandler(this.OpenBackupPage_btn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 386);
            this.Controls.Add(this.OpenBackupPage_btn);
            this.Controls.Add(this.Setting_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "MyBackup";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Setting_btn;
        private System.Windows.Forms.Button OpenBackupPage_btn;
    }
}

