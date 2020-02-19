namespace FileSearch
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folders_tv = new System.Windows.Forms.TreeView();
            this.current_folder_lbl = new System.Windows.Forms.Label();
            this.choose_folder_btn = new System.Windows.Forms.Button();
            this.folder_dialog_fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.params_gb = new System.Windows.Forms.GroupBox();
            this.folder_name_lbl = new System.Windows.Forms.Label();
            this.params_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // folders_tv
            // 
            this.folders_tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folders_tv.Location = new System.Drawing.Point(13, 34);
            this.folders_tv.Name = "folders_tv";
            this.folders_tv.Size = new System.Drawing.Size(337, 396);
            this.folders_tv.TabIndex = 0;
            // 
            // current_folder_lbl
            // 
            this.current_folder_lbl.AutoSize = true;
            this.current_folder_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_folder_lbl.Location = new System.Drawing.Point(12, 6);
            this.current_folder_lbl.Name = "current_folder_lbl";
            this.current_folder_lbl.Size = new System.Drawing.Size(192, 26);
            this.current_folder_lbl.TabIndex = 1;
            this.current_folder_lbl.Text = "Current folder path";
            // 
            // choose_folder_btn
            // 
            this.choose_folder_btn.Location = new System.Drawing.Point(128, 19);
            this.choose_folder_btn.Name = "choose_folder_btn";
            this.choose_folder_btn.Size = new System.Drawing.Size(110, 23);
            this.choose_folder_btn.TabIndex = 2;
            this.choose_folder_btn.Text = "Choose folder";
            this.choose_folder_btn.UseVisualStyleBackColor = true;
            this.choose_folder_btn.Click += new System.EventHandler(this.choose_folder_btn_Click);
            // 
            // folder_dialog_fbd
            // 
            this.folder_dialog_fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // params_gb
            // 
            this.params_gb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.params_gb.Controls.Add(this.folder_name_lbl);
            this.params_gb.Controls.Add(this.choose_folder_btn);
            this.params_gb.Location = new System.Drawing.Point(368, 34);
            this.params_gb.Name = "params_gb";
            this.params_gb.Size = new System.Drawing.Size(244, 396);
            this.params_gb.TabIndex = 3;
            this.params_gb.TabStop = false;
            this.params_gb.Text = "Params";
            // 
            // folder_name_lbl
            // 
            this.folder_name_lbl.AutoSize = true;
            this.folder_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folder_name_lbl.Location = new System.Drawing.Point(6, 22);
            this.folder_name_lbl.Name = "folder_name_lbl";
            this.folder_name_lbl.Size = new System.Drawing.Size(95, 16);
            this.folder_name_lbl.TabIndex = 3;
            this.folder_name_lbl.Text = "Folder name";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.params_gb);
            this.Controls.Add(this.folders_tv);
            this.Controls.Add(this.current_folder_lbl);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "main_form";
            this.Text = "FileSearch";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.params_gb.ResumeLayout(false);
            this.params_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView folders_tv;
        private System.Windows.Forms.Button choose_folder_btn;
        public System.Windows.Forms.FolderBrowserDialog folder_dialog_fbd;
        public System.Windows.Forms.Label current_folder_lbl;
        private System.Windows.Forms.GroupBox params_gb;
        public System.Windows.Forms.Label folder_name_lbl;
    }
}

