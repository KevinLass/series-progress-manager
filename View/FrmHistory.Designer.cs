
namespace VideoWatcher.View {
    partial class FrmHistory {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.DgGrid = new System.Windows.Forms.DataGridView();
            this.LblPerDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DgGrid
            // 
            this.DgGrid.AllowUserToAddRows = false;
            this.DgGrid.AllowUserToDeleteRows = false;
            this.DgGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgGrid.Location = new System.Drawing.Point(12, 12);
            this.DgGrid.Name = "DgGrid";
            this.DgGrid.ReadOnly = true;
            this.DgGrid.RowHeadersVisible = false;
            this.DgGrid.RowHeadersWidth = 62;
            this.DgGrid.RowTemplate.Height = 28;
            this.DgGrid.Size = new System.Drawing.Size(1223, 675);
            this.DgGrid.TabIndex = 0;
            // 
            // LblPerDay
            // 
            this.LblPerDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPerDay.AutoSize = true;
            this.LblPerDay.Location = new System.Drawing.Point(12, 705);
            this.LblPerDay.Name = "LblPerDay";
            this.LblPerDay.Size = new System.Drawing.Size(0, 20);
            this.LblPerDay.TabIndex = 2;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 810);
            this.Controls.Add(this.LblPerDay);
            this.Controls.Add(this.DgGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgGrid;
        private System.Windows.Forms.Label LblPerDay;
    }
}