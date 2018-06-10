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
            this.Cont_text = new System.Windows.Forms.Button();
            this.Ports_compo = new System.Windows.Forms.ComboBox();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Cont_text
            // 
            this.Cont_text.Location = new System.Drawing.Point(139, 22);
            this.Cont_text.Name = "Cont_text";
            this.Cont_text.Size = new System.Drawing.Size(75, 23);
            this.Cont_text.TabIndex = 1;
            this.Cont_text.Text = "connect";
            this.Cont_text.UseVisualStyleBackColor = true;
            this.Cont_text.Click += new System.EventHandler(this.Cont_text_Click);
            // 
            // Ports_compo
            // 
            this.Ports_compo.FormattingEnabled = true;
            this.Ports_compo.Location = new System.Drawing.Point(12, 22);
            this.Ports_compo.Name = "Ports_compo";
            this.Ports_compo.Size = new System.Drawing.Size(121, 24);
            this.Ports_compo.TabIndex = 2;
            // 
            // tempchart
            // 
            chartArea1.Name = "ChartArea1";
            this.tempchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempchart.Legends.Add(legend1);
            this.tempchart.Location = new System.Drawing.Point(12, 52);
            this.tempchart.Name = "tempchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "TempSeries";
            this.tempchart.Series.Add(series1);
            this.tempchart.Size = new System.Drawing.Size(659, 434);
            this.tempchart.TabIndex = 4;
            this.tempchart.Text = "Temp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tempchart);
            this.Controls.Add(this.Ports_compo);
            this.Controls.Add(this.Cont_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cont_text;
        private System.Windows.Forms.ComboBox Ports_compo;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempchart;
        private System.Windows.Forms.Button button1;
    }
}

