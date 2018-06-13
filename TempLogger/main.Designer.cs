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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Cont_text = new System.Windows.Forms.Button();
            this.Ports_compo = new System.Windows.Forms.ComboBox();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butOption = new System.Windows.Forms.Button();
            this.serialData2 = new System.Windows.Forms.TextBox();
            this.Debug = new System.Windows.Forms.TextBox();
            this.Logsbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Cont_text
            // 
            this.Cont_text.Location = new System.Drawing.Point(139, 10);
            this.Cont_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cont_text.Name = "Cont_text";
            this.Cont_text.Size = new System.Drawing.Size(107, 26);
            this.Cont_text.TabIndex = 1;
            this.Cont_text.Text = "connect";
            this.Cont_text.UseVisualStyleBackColor = true;
            this.Cont_text.Click += new System.EventHandler(this.Cont_text_Click);
            // 
            // Ports_compo
            // 
            this.Ports_compo.FormattingEnabled = true;
            this.Ports_compo.Location = new System.Drawing.Point(12, 10);
            this.Ports_compo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ports_compo.Name = "Ports_compo";
            this.Ports_compo.Size = new System.Drawing.Size(121, 24);
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
            this.tempchart.Location = new System.Drawing.Point(12, 41);
            this.tempchart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempchart.Name = "tempchart";
            this.tempchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.tempchart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "TempSeries";
            this.tempchart.Series.Add(series1);
            this.tempchart.Size = new System.Drawing.Size(656, 400);
            this.tempchart.TabIndex = 4;
            this.tempchart.Text = "Temp";
            title1.Name = "Tempertur";
            title1.Text = "Tempertur";
            this.tempchart.Titles.Add(title1);
            // 
            // butOption
            // 
            this.butOption.Location = new System.Drawing.Point(567, 10);
            this.butOption.Margin = new System.Windows.Forms.Padding(4);
            this.butOption.Name = "butOption";
            this.butOption.Size = new System.Drawing.Size(100, 26);
            this.butOption.TabIndex = 6;
            this.butOption.Text = "Option";
            this.butOption.UseVisualStyleBackColor = true;
            this.butOption.Click += new System.EventHandler(this.butOption_Click);
            // 
            // serialData2
            // 
            this.serialData2.Location = new System.Drawing.Point(12, 459);
            this.serialData2.Margin = new System.Windows.Forms.Padding(4);
            this.serialData2.Name = "serialData2";
            this.serialData2.Size = new System.Drawing.Size(132, 22);
            this.serialData2.TabIndex = 7;
            this.serialData2.Text = "Grader";
            // 
            // Debug
            // 
            this.Debug.Enabled = false;
            this.Debug.Location = new System.Drawing.Point(176, 458);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(100, 22);
            this.Debug.TabIndex = 8;
            // 
            // Logsbut
            // 
            this.Logsbut.Location = new System.Drawing.Point(592, 459);
            this.Logsbut.Name = "Logsbut";
            this.Logsbut.Size = new System.Drawing.Size(75, 23);
            this.Logsbut.TabIndex = 9;
            this.Logsbut.Text = "Logs";
            this.Logsbut.UseVisualStyleBackColor = true;
            this.Logsbut.Click += new System.EventHandler(this.Logsbut_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.Logsbut);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.serialData2);
            this.Controls.Add(this.butOption);
            this.Controls.Add(this.tempchart);
            this.Controls.Add(this.Ports_compo);
            this.Controls.Add(this.Cont_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox Debug;
        private System.Windows.Forms.Button Logsbut;
    }
}

