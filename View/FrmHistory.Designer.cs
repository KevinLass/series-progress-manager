
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
            this.DgGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPerDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DgGrid
            // 
            this.DgGrid.AllowUserToAddRows = false;
            this.DgGrid.AllowUserToDeleteRows = false;
            this.DgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgGrid.Location = new System.Drawing.Point(12, 12);
            this.DgGrid.Name = "DgGrid";
            this.DgGrid.ReadOnly = true;
            this.DgGrid.RowHeadersVisible = false;
            this.DgGrid.RowHeadersWidth = 62;
            this.DgGrid.RowTemplate.Height = 28;
            this.DgGrid.Size = new System.Drawing.Size(1223, 692);
            this.DgGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Episodes per Day:";
            // 
            // LblPerDay
            // 
            this.LblPerDay.AutoSize = true;
            this.LblPerDay.Location = new System.Drawing.Point(178, 740);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgGrid);
            this.Name = "FrmHistory";
            this.Text = "History";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPerDay;
    }
}