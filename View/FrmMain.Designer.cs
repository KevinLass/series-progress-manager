
namespace View {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.LblFileName = new System.Windows.Forms.Label();
            this.DgFiles = new System.Windows.Forms.DataGridView();
            this.BtnVlc = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnWatched = new System.Windows.Forms.Button();
            this.BtnUnwatched = new System.Windows.Forms.Button();
            this.TvFiles = new System.Windows.Forms.TreeView();
            this.CbRecursiveSearch = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(104, 38);
            this.BtnOpenFile.TabIndex = 4;
            this.BtnOpenFile.Text = "Open";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(422, 74);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(14, 20);
            this.LblFileName.TabIndex = 6;
            this.LblFileName.Text = "-";
            // 
            // DgFiles
            // 
            this.DgFiles.AllowUserToAddRows = false;
            this.DgFiles.AllowUserToDeleteRows = false;
            this.DgFiles.AllowUserToResizeColumns = false;
            this.DgFiles.AllowUserToResizeRows = false;
            this.DgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgFiles.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgFiles.Location = new System.Drawing.Point(0, 0);
            this.DgFiles.MultiSelect = false;
            this.DgFiles.Name = "DgFiles";
            this.DgFiles.ReadOnly = true;
            this.DgFiles.RowHeadersVisible = false;
            this.DgFiles.RowHeadersWidth = 62;
            this.DgFiles.RowTemplate.Height = 28;
            this.DgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgFiles.Size = new System.Drawing.Size(1015, 951);
            this.DgFiles.TabIndex = 7;
            this.DgFiles.DoubleClick += new System.EventHandler(this.DgFiles_DoubleClick);
            this.DgFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgFiles_KeyDown);
            // 
            // BtnVlc
            // 
            this.BtnVlc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVlc.Location = new System.Drawing.Point(1301, 12);
            this.BtnVlc.Name = "BtnVlc";
            this.BtnVlc.Size = new System.Drawing.Size(140, 38);
            this.BtnVlc.TabIndex = 8;
            this.BtnVlc.Text = "Start in VLC";
            this.BtnVlc.UseVisualStyleBackColor = true;
            this.BtnVlc.Click += new System.EventHandler(this.BtnVlc_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(1016, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(121, 38);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear History";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(122, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(112, 38);
            this.BtnRefresh.TabIndex = 10;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnWatched
            // 
            this.BtnWatched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWatched.Location = new System.Drawing.Point(817, 12);
            this.BtnWatched.Name = "BtnWatched";
            this.BtnWatched.Size = new System.Drawing.Size(88, 38);
            this.BtnWatched.TabIndex = 11;
            this.BtnWatched.Text = "Mark";
            this.BtnWatched.UseVisualStyleBackColor = true;
            this.BtnWatched.Click += new System.EventHandler(this.BtnWatched_Click);
            // 
            // BtnUnwatched
            // 
            this.BtnUnwatched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUnwatched.Location = new System.Drawing.Point(911, 12);
            this.BtnUnwatched.Name = "BtnUnwatched";
            this.BtnUnwatched.Size = new System.Drawing.Size(99, 38);
            this.BtnUnwatched.TabIndex = 12;
            this.BtnUnwatched.Text = "Unmark";
            this.BtnUnwatched.UseVisualStyleBackColor = true;
            this.BtnUnwatched.Click += new System.EventHandler(this.BtnUnwatched_Click);
            // 
            // TvFiles
            // 
            this.TvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvFiles.Location = new System.Drawing.Point(0, 0);
            this.TvFiles.Name = "TvFiles";
            this.TvFiles.Size = new System.Drawing.Size(410, 951);
            this.TvFiles.TabIndex = 13;
            this.TvFiles.DoubleClick += new System.EventHandler(this.TvFiles_DoubleClick);
            // 
            // CbRecursiveSearch
            // 
            this.CbRecursiveSearch.AutoSize = true;
            this.CbRecursiveSearch.Location = new System.Drawing.Point(318, 73);
            this.CbRecursiveSearch.Name = "CbRecursiveSearch";
            this.CbRecursiveSearch.Size = new System.Drawing.Size(98, 24);
            this.CbRecursiveSearch.TabIndex = 14;
            this.CbRecursiveSearch.Text = "recursive";
            this.CbRecursiveSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 111);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TvFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgFiles);
            this.splitContainer1.Size = new System.Drawing.Size(1429, 951);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 15;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 71);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(290, 26);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 1074);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CbRecursiveSearch);
            this.Controls.Add(this.BtnUnwatched);
            this.Controls.Add(this.BtnWatched);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnVlc);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.BtnOpenFile);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Video Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.DgFiles)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.DataGridView DgFiles;
        private System.Windows.Forms.Button BtnVlc;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnWatched;
        private System.Windows.Forms.Button BtnUnwatched;
        private System.Windows.Forms.TreeView TvFiles;
        private System.Windows.Forms.CheckBox CbRecursiveSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}