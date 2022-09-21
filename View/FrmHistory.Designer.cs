
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.DgGrid = new System.Windows.Forms.DataGridView();
            this.LblPerDay = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // DgGrid
            // 
            this.DgGrid.AllowUserToAddRows = false;
            this.DgGrid.AllowUserToDeleteRows = false;
            this.DgGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgGrid.Location = new System.Drawing.Point(11, 8);
            this.DgGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgGrid.Name = "DgGrid";
            this.DgGrid.ReadOnly = true;
            this.DgGrid.RowHeadersVisible = false;
            this.DgGrid.RowHeadersWidth = 62;
            this.DgGrid.RowTemplate.Height = 28;
            this.DgGrid.Size = new System.Drawing.Size(951, 345);
            this.DgGrid.TabIndex = 0;
            // 
            // LblPerDay
            // 
            this.LblPerDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPerDay.AutoSize = true;
            this.LblPerDay.Location = new System.Drawing.Point(966, 8);
            this.LblPerDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPerDay.Name = "LblPerDay";
            this.LblPerDay.Size = new System.Drawing.Size(63, 13);
            this.LblPerDay.TabIndex = 2;
            this.LblPerDay.Text = "Placeholder";
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)));
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Location = new System.Drawing.Point(8, 357);
            this.Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Episodes";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(1228, 322);
            this.Chart.TabIndex = 3;
            this.Chart.Text = "chart1";
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 690);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.LblPerDay);
            this.Controls.Add(this.DgGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgGrid;
        private System.Windows.Forms.Label LblPerDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}