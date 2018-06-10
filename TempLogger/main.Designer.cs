namespace TempLogger
{
    partial class main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Cont_text = new System.Windows.Forms.Button();
            this.Ports_compo = new System.Windows.Forms.ComboBox();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butOption = new System.Windows.Forms.Button();
            this.serialData2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Cont_text
            // 
            this.Cont_text.Location = new System.Drawing.Point(104, 8);
            this.Cont_text.Margin = new System.Windows.Forms.Padding(2);
            this.Cont_text.Name = "Cont_text";
            this.Cont_text.Size = new System.Drawing.Size(80, 21);
            this.Cont_text.TabIndex = 1;
            this.Cont_text.Text = "connect";
            this.Cont_text.UseVisualStyleBackColor = true;
            this.Cont_text.Click += new System.EventHandler(this.Cont_text_Click);
            // 
            // Ports_compo
            // 
            this.Ports_compo.FormattingEnabled = true;
            this.Ports_compo.Location = new System.Drawing.Point(9, 8);
            this.Ports_compo.Margin = new System.Windows.Forms.Padding(2);
            this.Ports_compo.Name = "Ports_compo";
            this.Ports_compo.Size = new System.Drawing.Size(92, 21);
            this.Ports_compo.TabIndex = 2;
            // 
            // tempchart
            // 
            chartArea5.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea5.Name = "ChartArea1";
            this.tempchart.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.tempchart.Legends.Add(legend5);
            this.tempchart.Location = new System.Drawing.Point(9, 33);
            this.tempchart.Margin = new System.Windows.Forms.Padding(2);
            this.tempchart.Name = "tempchart";
            this.tempchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.tempchart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "TempSeries";
            this.tempchart.Series.Add(series5);
            this.tempchart.Size = new System.Drawing.Size(492, 325);
            this.tempchart.TabIndex = 4;
            this.tempchart.Text = "Temp";
            title5.Name = "Tempertur";
            title5.Text = "Tempertur";
            this.tempchart.Titles.Add(title5);
            // 
            // butOption
            // 
            this.butOption.Location = new System.Drawing.Point(425, 8);
            this.butOption.Name = "butOption";
            this.butOption.Size = new System.Drawing.Size(75, 21);
            this.butOption.TabIndex = 6;
            this.butOption.Text = "Option";
            this.butOption.UseVisualStyleBackColor = true;
            this.butOption.Click += new System.EventHandler(this.butOption_Click);
            // 
            // serialData2
            // 
            this.serialData2.Location = new System.Drawing.Point(9, 373);
            this.serialData2.Name = "serialData2";
            this.serialData2.Size = new System.Drawing.Size(100, 20);
            this.serialData2.TabIndex = 7;
            this.serialData2.Text = "Data";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 405);
            this.Controls.Add(this.serialData2);
            this.Controls.Add(this.butOption);
            this.Controls.Add(this.tempchart);
            this.Controls.Add(this.Ports_compo);
            this.Controls.Add(this.Cont_text);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "TempLogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cont_text;
        private System.Windows.Forms.ComboBox Ports_compo;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempchart;
        private System.Windows.Forms.Button butOption;
        private System.Windows.Forms.TextBox serialData2;
    }
}

