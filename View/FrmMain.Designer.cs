
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            this.DgSeries = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(11, 10);
            this.BtnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(92, 31);
            this.BtnOpenFile.TabIndex = 4;
            this.BtnOpenFile.Text = "Open";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(375, 59);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(11, 16);
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
            this.DgFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgFiles.MultiSelect = false;
            this.DgFiles.Name = "DgFiles";
            this.DgFiles.ReadOnly = true;
            this.DgFiles.RowHeadersVisible = false;
            this.DgFiles.RowHeadersWidth = 62;
            this.DgFiles.RowTemplate.Height = 28;
            this.DgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgFiles.Size = new System.Drawing.Size(903, 761);
            this.DgFiles.TabIndex = 7;
            this.DgFiles.DoubleClick += new System.EventHandler(this.DgFiles_DoubleClick);
            this.DgFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgFiles_KeyDown);
            // 
            // BtnVlc
            // 
            this.BtnVlc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVlc.Location = new System.Drawing.Point(1161, 10);
            this.BtnVlc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVlc.Name = "BtnVlc";
            this.BtnVlc.Size = new System.Drawing.Size(120, 31);
            this.BtnVlc.TabIndex = 8;
            this.BtnVlc.Text = "Start Video";
            this.BtnVlc.UseVisualStyleBackColor = true;
            this.BtnVlc.Click += new System.EventHandler(this.BtnVlc_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(903, 10);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 31);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear History";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(108, 10);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(100, 31);
            this.BtnRefresh.TabIndex = 10;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnWatched
            // 
            this.BtnWatched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWatched.Location = new System.Drawing.Point(727, 10);
            this.BtnWatched.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWatched.Name = "BtnWatched";
            this.BtnWatched.Size = new System.Drawing.Size(79, 31);
            this.BtnWatched.TabIndex = 11;
            this.BtnWatched.Text = "Mark";
            this.BtnWatched.UseVisualStyleBackColor = true;
            this.BtnWatched.Click += new System.EventHandler(this.BtnWatched_Click);
            // 
            // BtnUnwatched
            // 
            this.BtnUnwatched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUnwatched.Location = new System.Drawing.Point(809, 10);
            this.BtnUnwatched.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUnwatched.Name = "BtnUnwatched";
            this.BtnUnwatched.Size = new System.Drawing.Size(88, 31);
            this.BtnUnwatched.TabIndex = 12;
            this.BtnUnwatched.Text = "Unmark";
            this.BtnUnwatched.UseVisualStyleBackColor = true;
            this.BtnUnwatched.Click += new System.EventHandler(this.BtnUnwatched_Click);
            // 
            // TvFiles
            // 
            this.TvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TvFiles.Location = new System.Drawing.Point(1, 410);
            this.TvFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TvFiles.Name = "TvFiles";
            this.TvFiles.Size = new System.Drawing.Size(361, 347);
            this.TvFiles.TabIndex = 13;
            this.TvFiles.DoubleClick += new System.EventHandler(this.TvFiles_DoubleClick);
            // 
            // CbRecursiveSearch
            // 
            this.CbRecursiveSearch.AutoSize = true;
            this.CbRecursiveSearch.Location = new System.Drawing.Point(268, 383);
            this.CbRecursiveSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbRecursiveSearch.Name = "CbRecursiveSearch";
            this.CbRecursiveSearch.Size = new System.Drawing.Size(84, 20);
            this.CbRecursiveSearch.TabIndex = 14;
            this.CbRecursiveSearch.Text = "recursive";
            this.CbRecursiveSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 89);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgSeries);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.CbRecursiveSearch);
            this.splitContainer1.Panel1.Controls.Add(this.TvFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgFiles);
            this.splitContainer1.Size = new System.Drawing.Size(1271, 761);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 15;
            // 
            // DgSeries
            // 
            this.DgSeries.AllowUserToAddRows = false;
            this.DgSeries.AllowUserToDeleteRows = false;
            this.DgSeries.AllowUserToResizeColumns = false;
            this.DgSeries.AllowUserToResizeRows = false;
            this.DgSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgSeries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSeries.Location = new System.Drawing.Point(5, 4);
            this.DgSeries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgSeries.MultiSelect = false;
            this.DgSeries.Name = "DgSeries";
            this.DgSeries.ReadOnly = true;
            this.DgSeries.RowHeadersVisible = false;
            this.DgSeries.RowHeadersWidth = 51;
            this.DgSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSeries.Size = new System.Drawing.Size(355, 347);
            this.DgSeries.TabIndex = 14;
            this.DgSeries.DoubleClick += new System.EventHandler(this.DgSeries_DoubleClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(5, 380);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(259, 22);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(213, 10);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(120, 30);
            this.BtnHistory.TabIndex = 17;
            this.BtnHistory.Text = "Show History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(11, 54);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 28);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(108, 53);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 28);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 849);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BtnUnwatched);
            this.Controls.Add(this.BtnWatched);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnVlc);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.BtnOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Video Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.DgFiles)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgSeries)).EndInit();
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
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.DataGridView DgSeries;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
    }
}