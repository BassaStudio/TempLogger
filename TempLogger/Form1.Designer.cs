namespace TempLogger
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Cont_text = new System.Windows.Forms.Button();
            this.Ports_compo = new System.Windows.Forms.ComboBox();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialData = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Cont_text
            // 
            this.Cont_text.Location = new System.Drawing.Point(104, 8);
            this.Cont_text.Margin = new System.Windows.Forms.Padding(2);
            this.Cont_text.Name = "Cont_text";
            this.Cont_text.Size = new System.Drawing.Size(56, 21);
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
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.tempchart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.tempchart.Legends.Add(legend1);
            this.tempchart.Location = new System.Drawing.Point(9, 33);
            this.tempchart.Margin = new System.Windows.Forms.Padding(2);
            this.tempchart.Name = "tempchart";
            this.tempchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.tempchart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "TempSeries";
            this.tempchart.Series.Add(series1);
            this.tempchart.Size = new System.Drawing.Size(492, 330);
            this.tempchart.TabIndex = 4;
            this.tempchart.Text = "Temp";
            title1.Name = "Tempertur";
            title1.Text = "Tempertur";
            this.tempchart.Titles.Add(title1);
            // 
            // serialData
            // 
            this.serialData.Location = new System.Drawing.Point(9, 372);
            this.serialData.Name = "serialData";
            this.serialData.Size = new System.Drawing.Size(75, 21);
            this.serialData.TabIndex = 5;
            this.serialData.Text = "data";
            this.serialData.TextChanged += new System.EventHandler(this.serialData_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 405);
            this.Controls.Add(this.serialData);
            this.Controls.Add(this.tempchart);
            this.Controls.Add(this.Ports_compo);
            this.Controls.Add(this.Cont_text);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cont_text;
        private System.Windows.Forms.ComboBox Ports_compo;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempchart;
        private System.Windows.Forms.RichTextBox serialData;
    }
}

