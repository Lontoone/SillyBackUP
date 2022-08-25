namespace AutoBackup
{
    partial class BackupPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupPage));
            this.FolderList_gdv = new System.Windows.Forms.DataGridView();
            this.Folder_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddFolder_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DoBackup_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Compare_current_dgv = new System.Windows.Forms.DataGridView();
            this.Folder_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compare_Past_dgv = new System.Windows.Forms.DataGridView();
            this.Folder_col_past = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path_col_past = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentFileCount_label = new System.Windows.Forms.Label();
            this.PastFileCount_label = new System.Windows.Forms.Label();
            this.DirectoryUP_btn = new System.Windows.Forms.Button();
            this.Copy_Back_btn = new System.Windows.Forms.Button();
            this.Copy_back_All_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoShutDown_checkbox = new System.Windows.Forms.CheckBox();
            this.AddFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FolderList_gdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compare_current_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compare_Past_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderList_gdv
            // 
            this.FolderList_gdv.AllowUserToAddRows = false;
            this.FolderList_gdv.AllowUserToDeleteRows = false;
            this.FolderList_gdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FolderList_gdv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FolderList_gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FolderList_gdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder_Column,
            this.Path_Column});
            this.FolderList_gdv.Location = new System.Drawing.Point(12, 59);
            this.FolderList_gdv.Name = "FolderList_gdv";
            this.FolderList_gdv.ReadOnly = true;
            this.FolderList_gdv.RowHeadersVisible = false;
            this.FolderList_gdv.RowTemplate.Height = 24;
            this.FolderList_gdv.Size = new System.Drawing.Size(213, 368);
            this.FolderList_gdv.TabIndex = 0;
            this.FolderList_gdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FolderList_gdv_CellContentClick);
            // 
            // Folder_Column
            // 
            this.Folder_Column.HeaderText = "Folder";
            this.Folder_Column.Name = "Folder_Column";
            this.Folder_Column.ReadOnly = true;
            this.Folder_Column.Width = 60;
            // 
            // Path_Column
            // 
            this.Path_Column.HeaderText = "Path";
            this.Path_Column.Name = "Path_Column";
            this.Path_Column.ReadOnly = true;
            this.Path_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Path_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Path_Column.Width = 50;
            // 
            // AddFolder_btn
            // 
            this.AddFolder_btn.Location = new System.Drawing.Point(239, 12);
            this.AddFolder_btn.Name = "AddFolder_btn";
            this.AddFolder_btn.Size = new System.Drawing.Size(75, 23);
            this.AddFolder_btn.TabIndex = 1;
            this.AddFolder_btn.Text = "加入資料夾";
            this.AddFolder_btn.UseVisualStyleBackColor = true;
            this.AddFolder_btn.Click += new System.EventHandler(this.AddFolder_btn_Click);
            // 
            // DoBackup_btn
            // 
            this.DoBackup_btn.Location = new System.Drawing.Point(87, 447);
            this.DoBackup_btn.Name = "DoBackup_btn";
            this.DoBackup_btn.Size = new System.Drawing.Size(127, 42);
            this.DoBackup_btn.TabIndex = 2;
            this.DoBackup_btn.Text = "備份";
            this.DoBackup_btn.UseVisualStyleBackColor = true;
            this.DoBackup_btn.Click += new System.EventHandler(this.DoBackup_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(239, 42);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(75, 23);
            this.Remove_btn.TabIndex = 3;
            this.Remove_btn.Text = "移除";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Compare_current_dgv
            // 
            this.Compare_current_dgv.AllowUserToAddRows = false;
            this.Compare_current_dgv.AllowUserToDeleteRows = false;
            this.Compare_current_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Compare_current_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Compare_current_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Compare_current_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Compare_current_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder_col,
            this.Path_col});
            this.Compare_current_dgv.Location = new System.Drawing.Point(327, 70);
            this.Compare_current_dgv.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Compare_current_dgv.Name = "Compare_current_dgv";
            this.Compare_current_dgv.ReadOnly = true;
            this.Compare_current_dgv.RowHeadersVisible = false;
            this.Compare_current_dgv.RowTemplate.Height = 38;
            this.Compare_current_dgv.Size = new System.Drawing.Size(469, 357);
            this.Compare_current_dgv.TabIndex = 4;
            this.Compare_current_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Compare_current_dgv_CellContentClick);
            // 
            // Folder_col
            // 
            this.Folder_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Folder_col.DefaultCellStyle = dataGridViewCellStyle1;
            this.Folder_col.HeaderText = "Folder";
            this.Folder_col.Name = "Folder_col";
            this.Folder_col.ReadOnly = true;
            this.Folder_col.Width = 50;
            // 
            // Path_col
            // 
            this.Path_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Path_col.DefaultCellStyle = dataGridViewCellStyle2;
            this.Path_col.HeaderText = "Path";
            this.Path_col.Name = "Path_col";
            this.Path_col.ReadOnly = true;
            this.Path_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Path_col.Width = 50;
            // 
            // Compare_Past_dgv
            // 
            this.Compare_Past_dgv.AllowUserToAddRows = false;
            this.Compare_Past_dgv.AllowUserToDeleteRows = false;
            this.Compare_Past_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Compare_Past_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Compare_Past_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Compare_Past_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Compare_Past_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder_col_past,
            this.Path_col_past});
            this.Compare_Past_dgv.Location = new System.Drawing.Point(828, 70);
            this.Compare_Past_dgv.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Compare_Past_dgv.Name = "Compare_Past_dgv";
            this.Compare_Past_dgv.ReadOnly = true;
            this.Compare_Past_dgv.RowHeadersVisible = false;
            this.Compare_Past_dgv.RowTemplate.Height = 38;
            this.Compare_Past_dgv.Size = new System.Drawing.Size(469, 357);
            this.Compare_Past_dgv.TabIndex = 5;
            // 
            // Folder_col_past
            // 
            this.Folder_col_past.HeaderText = "Folder";
            this.Folder_col_past.Name = "Folder_col_past";
            this.Folder_col_past.ReadOnly = true;
            this.Folder_col_past.Width = 60;
            // 
            // Path_col_past
            // 
            this.Path_col_past.HeaderText = "Path";
            this.Path_col_past.Name = "Path_col_past";
            this.Path_col_past.ReadOnly = true;
            this.Path_col_past.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Path_col_past.Width = 50;
            // 
            // CurrentFileCount_label
            // 
            this.CurrentFileCount_label.AutoSize = true;
            this.CurrentFileCount_label.Location = new System.Drawing.Point(352, 47);
            this.CurrentFileCount_label.Name = "CurrentFileCount_label";
            this.CurrentFileCount_label.Size = new System.Drawing.Size(8, 12);
            this.CurrentFileCount_label.TabIndex = 6;
            this.CurrentFileCount_label.Text = " ";
            // 
            // PastFileCount_label
            // 
            this.PastFileCount_label.AutoSize = true;
            this.PastFileCount_label.Location = new System.Drawing.Point(836, 47);
            this.PastFileCount_label.Name = "PastFileCount_label";
            this.PastFileCount_label.Size = new System.Drawing.Size(8, 12);
            this.PastFileCount_label.TabIndex = 7;
            this.PastFileCount_label.Text = " ";
            // 
            // DirectoryUP_btn
            // 
            this.DirectoryUP_btn.AutoEllipsis = true;
            this.DirectoryUP_btn.Location = new System.Drawing.Point(290, 96);
            this.DirectoryUP_btn.Name = "DirectoryUP_btn";
            this.DirectoryUP_btn.Size = new System.Drawing.Size(33, 33);
            this.DirectoryUP_btn.TabIndex = 8;
            this.DirectoryUP_btn.Text = "<<";
            this.DirectoryUP_btn.UseVisualStyleBackColor = true;
            this.DirectoryUP_btn.Click += new System.EventHandler(this.DirectoryUP_btn_Click);
            // 
            // Copy_Back_btn
            // 
            this.Copy_Back_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Copy_Back_btn.Location = new System.Drawing.Point(1020, 459);
            this.Copy_Back_btn.Name = "Copy_Back_btn";
            this.Copy_Back_btn.Size = new System.Drawing.Size(126, 30);
            this.Copy_Back_btn.TabIndex = 9;
            this.Copy_Back_btn.Text = "<<單項還原";
            this.Copy_Back_btn.UseVisualStyleBackColor = true;
            this.Copy_Back_btn.Click += new System.EventHandler(this.Copy_Back_btn_Click);
            // 
            // Copy_back_All_btn
            // 
            this.Copy_back_All_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Copy_back_All_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Copy_back_All_btn.Location = new System.Drawing.Point(1170, 447);
            this.Copy_back_All_btn.Name = "Copy_back_All_btn";
            this.Copy_back_All_btn.Size = new System.Drawing.Size(127, 42);
            this.Copy_back_All_btn.TabIndex = 10;
            this.Copy_back_All_btn.Text = "<<全部還原";
            this.Copy_back_All_btn.UseVisualStyleBackColor = true;
            this.Copy_back_All_btn.Click += new System.EventHandler(this.Copy_back_All_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "最近的備分檔案";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "目前的資料";
            // 
            // AutoShutDown_checkbox
            // 
            this.AutoShutDown_checkbox.AutoSize = true;
            this.AutoShutDown_checkbox.Location = new System.Drawing.Point(237, 470);
            this.AutoShutDown_checkbox.Name = "AutoShutDown_checkbox";
            this.AutoShutDown_checkbox.Size = new System.Drawing.Size(108, 16);
            this.AutoShutDown_checkbox.TabIndex = 13;
            this.AutoShutDown_checkbox.Text = "完成後自動關機";
            this.AutoShutDown_checkbox.UseVisualStyleBackColor = true;
            // 
            // AddFile_btn
            // 
            this.AddFile_btn.Location = new System.Drawing.Point(327, 12);
            this.AddFile_btn.Name = "AddFile_btn";
            this.AddFile_btn.Size = new System.Drawing.Size(75, 23);
            this.AddFile_btn.TabIndex = 14;
            this.AddFile_btn.Text = "加入檔案";
            this.AddFile_btn.UseVisualStyleBackColor = true;
            this.AddFile_btn.Click += new System.EventHandler(this.AddFile_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BackupPage
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 501);
            this.Controls.Add(this.AddFile_btn);
            this.Controls.Add(this.AutoShutDown_checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copy_back_All_btn);
            this.Controls.Add(this.Copy_Back_btn);
            this.Controls.Add(this.DirectoryUP_btn);
            this.Controls.Add(this.PastFileCount_label);
            this.Controls.Add(this.CurrentFileCount_label);
            this.Controls.Add(this.Compare_Past_dgv);
            this.Controls.Add(this.Compare_current_dgv);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.DoBackup_btn);
            this.Controls.Add(this.AddFolder_btn);
            this.Controls.Add(this.FolderList_gdv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupPage";
            this.Text = "BackupPage";
            this.Load += new System.EventHandler(this.BackupPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FolderList_gdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compare_current_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compare_Past_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FolderList_gdv;
        private System.Windows.Forms.Button AddFolder_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button DoBackup_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder_Column;
        private System.Windows.Forms.DataGridViewButtonColumn Path_Column;
        private System.Windows.Forms.DataGridView Compare_current_dgv;
        private System.Windows.Forms.DataGridView Compare_Past_dgv;
        private System.Windows.Forms.Label CurrentFileCount_label;
        private System.Windows.Forms.Label PastFileCount_label;
        private System.Windows.Forms.Button DirectoryUP_btn;
        private System.Windows.Forms.Button Copy_Back_btn;
        private System.Windows.Forms.Button Copy_back_All_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder_col_past;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path_col_past;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path_col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox AutoShutDown_checkbox;
        private System.Windows.Forms.Button AddFile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}