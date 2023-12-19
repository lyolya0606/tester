namespace tester {
    partial class ChartsForm {
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
            this.TimeChart = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView_Time = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeChart
            // 
            this.TimeChart.Location = new System.Drawing.Point(9, 10);
            this.TimeChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeChart.Name = "TimeChart";
            this.TimeChart.Size = new System.Drawing.Size(536, 506);
            this.TimeChart.TabIndex = 0;
            this.TimeChart.Text = "cartesianChart1";
            // 
            // dataGridView_Time
            // 
            this.dataGridView_Time.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Time.Location = new System.Drawing.Point(558, 10);
            this.dataGridView_Time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Time.Name = "dataGridView_Time";
            this.dataGridView_Time.RowHeadersWidth = 51;
            this.dataGridView_Time.RowTemplate.Height = 24;
            this.dataGridView_Time.Size = new System.Drawing.Size(342, 506);
            this.dataGridView_Time.TabIndex = 1;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 526);
            this.Controls.Add(this.dataGridView_Time);
            this.Controls.Add(this.TimeChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartsForm";
            this.Text = "ChartsAndTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart TimeChart;
        private System.Windows.Forms.DataGridView dataGridView_Time;
    }
}