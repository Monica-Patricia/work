namespace database_assignment
{
    partial class chartScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shoeDatabaseDataSet = new database_assignment.ShoeDatabaseDataSet();
            this.shoeDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new database_assignment.ShoeDatabaseDataSetTableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.stockBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(71, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueMembers = "Total quantity";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(366, 364);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // shoeDatabaseDataSet
            // 
            this.shoeDatabaseDataSet.DataSetName = "ShoeDatabaseDataSet";
            this.shoeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoeDatabaseDataSetBindingSource
            // 
            this.shoeDatabaseDataSetBindingSource.DataSource = this.shoeDatabaseDataSet;
            this.shoeDatabaseDataSetBindingSource.Position = 0;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.shoeDatabaseDataSetBindingSource;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // chartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::database_assignment.Properties.Resources.stock__1_;
            this.ClientSize = new System.Drawing.Size(1290, 429);
            this.Controls.Add(this.chart1);
            this.Name = "chartScreen";
            this.Text = "chartScreen";
            this.Load += new System.EventHandler(this.ChartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource shoeDatabaseDataSetBindingSource;
        private ShoeDatabaseDataSet shoeDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private ShoeDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
    }
}