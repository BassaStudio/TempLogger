namespace TempLogger
{
    partial class option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(option));
            this.AlertGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butbrowse = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.CheckAlert = new System.Windows.Forms.CheckBox();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.labMin = new System.Windows.Forms.Label();
            this.labMax = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butCanc = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GoupLog = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkLog = new System.Windows.Forms.CheckBox();
            this.textLogPath = new System.Windows.Forms.TextBox();
            this.butLogBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logIntNum = new System.Windows.Forms.NumericUpDown();
            this.AlertGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.GoupLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logIntNum)).BeginInit();
            this.SuspendLayout();
            // 
            // AlertGroup
            // 
            this.AlertGroup.Controls.Add(this.label1);
            this.AlertGroup.Controls.Add(this.butbrowse);
            this.AlertGroup.Controls.Add(this.textPath);
            this.AlertGroup.Controls.Add(this.CheckAlert);
            this.AlertGroup.Controls.Add(this.numMin);
            this.AlertGroup.Controls.Add(this.numMax);
            this.AlertGroup.Controls.Add(this.labMin);
            this.AlertGroup.Controls.Add(this.labMax);
            this.AlertGroup.Location = new System.Drawing.Point(16, 15);
            this.AlertGroup.Margin = new System.Windows.Forms.Padding(4);
            this.AlertGroup.Name = "AlertGroup";
            this.AlertGroup.Padding = new System.Windows.Forms.Padding(4);
            this.AlertGroup.Size = new System.Drawing.Size(243, 175);
            this.AlertGroup.TabIndex = 0;
            this.AlertGroup.TabStop = false;
            this.AlertGroup.Text = "Alert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sound";
            // 
            // butbrowse
            // 
            this.butbrowse.Location = new System.Drawing.Point(132, 139);
            this.butbrowse.Margin = new System.Windows.Forms.Padding(4);
            this.butbrowse.Name = "butbrowse";
            this.butbrowse.Size = new System.Drawing.Size(100, 28);
            this.butbrowse.TabIndex = 6;
            this.butbrowse.Text = "browse";
            this.butbrowse.UseVisualStyleBackColor = true;
            this.butbrowse.Click += new System.EventHandler(this.butbrowse_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(9, 143);
            this.textPath.Margin = new System.Windows.Forms.Padding(4);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(113, 22);
            this.textPath.TabIndex = 5;
            // 
            // CheckAlert
            // 
            this.CheckAlert.AutoSize = true;
            this.CheckAlert.Location = new System.Drawing.Point(13, 22);
            this.CheckAlert.Margin = new System.Windows.Forms.Padding(4);
            this.CheckAlert.Name = "CheckAlert";
            this.CheckAlert.Size = new System.Drawing.Size(107, 21);
            this.CheckAlert.TabIndex = 4;
            this.CheckAlert.Text = "Alert :Value:";
            this.CheckAlert.UseVisualStyleBackColor = true;
            this.CheckAlert.CheckedChanged += new System.EventHandler(this.CheckAlert_CheckedChanged);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(53, 80);
            this.numMin.Margin = new System.Windows.Forms.Padding(4);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(160, 22);
            this.numMin.TabIndex = 3;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(56, 47);
            this.numMax.Margin = new System.Windows.Forms.Padding(4);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(160, 22);
            this.numMax.TabIndex = 2;
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(9, 76);
            this.labMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(30, 17);
            this.labMin.TabIndex = 1;
            this.labMin.Text = "Min";
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Location = new System.Drawing.Point(9, 49);
            this.labMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(33, 17);
            this.labMax.TabIndex = 0;
            this.labMax.Text = "Max";
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(155, 208);
            this.butSave.Margin = new System.Windows.Forms.Padding(4);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(103, 27);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCanc
            // 
            this.butCanc.Location = new System.Drawing.Point(263, 208);
            this.butCanc.Margin = new System.Windows.Forms.Padding(4);
            this.butCanc.Name = "butCanc";
            this.butCanc.Size = new System.Drawing.Size(103, 27);
            this.butCanc.TabIndex = 2;
            this.butCanc.Text = "Cancel";
            this.butCanc.UseVisualStyleBackColor = true;
            this.butCanc.Click += new System.EventHandler(this.butCanc_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "fileDialog";
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.Title = "Find a Sound";
            // 
            // GoupLog
            // 
            this.GoupLog.Controls.Add(this.logIntNum);
            this.GoupLog.Controls.Add(this.label3);
            this.GoupLog.Controls.Add(this.label2);
            this.GoupLog.Controls.Add(this.checkLog);
            this.GoupLog.Controls.Add(this.textLogPath);
            this.GoupLog.Controls.Add(this.butLogBrowse);
            this.GoupLog.Location = new System.Drawing.Point(268, 16);
            this.GoupLog.Margin = new System.Windows.Forms.Padding(4);
            this.GoupLog.Name = "GoupLog";
            this.GoupLog.Padding = new System.Windows.Forms.Padding(4);
            this.GoupLog.Size = new System.Drawing.Size(267, 174);
            this.GoupLog.TabIndex = 3;
            this.GoupLog.TabStop = false;
            this.GoupLog.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Where to save";
            // 
            // checkLog
            // 
            this.checkLog.AutoSize = true;
            this.checkLog.Location = new System.Drawing.Point(9, 21);
            this.checkLog.Margin = new System.Windows.Forms.Padding(4);
            this.checkLog.Name = "checkLog";
            this.checkLog.Size = new System.Drawing.Size(110, 21);
            this.checkLog.TabIndex = 7;
            this.checkLog.Text = "Save :Value:";
            this.checkLog.UseVisualStyleBackColor = true;
            this.checkLog.CheckedChanged += new System.EventHandler(this.checkLog_CheckedChanged);
            // 
            // textLogPath
            // 
            this.textLogPath.Location = new System.Drawing.Point(9, 71);
            this.textLogPath.Margin = new System.Windows.Forms.Padding(4);
            this.textLogPath.Name = "textLogPath";
            this.textLogPath.Size = new System.Drawing.Size(132, 22);
            this.textLogPath.TabIndex = 0;
            // 
            // butLogBrowse
            // 
            this.butLogBrowse.Location = new System.Drawing.Point(151, 71);
            this.butLogBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.butLogBrowse.Name = "butLogBrowse";
            this.butLogBrowse.Size = new System.Drawing.Size(100, 28);
            this.butLogBrowse.TabIndex = 6;
            this.butLogBrowse.Text = "browse";
            this.butLogBrowse.UseVisualStyleBackColor = true;
            this.butLogBrowse.Click += new System.EventHandler(this.textLogPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "interval i sec:";
            // 
            // logIntNum
            // 
            this.logIntNum.Location = new System.Drawing.Point(105, 101);
            this.logIntNum.Name = "logIntNum";
            this.logIntNum.Size = new System.Drawing.Size(120, 22);
            this.logIntNum.TabIndex = 10;
            // 
            // option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 256);
            this.Controls.Add(this.GoupLog);
            this.Controls.Add(this.butCanc);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.AlertGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.option_Load);
            this.AlertGroup.ResumeLayout(false);
            this.AlertGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.GoupLog.ResumeLayout(false);
            this.GoupLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logIntNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AlertGroup;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCanc;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labMax;
        private System.Windows.Forms.CheckBox CheckAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butbrowse;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox GoupLog;
        private System.Windows.Forms.CheckBox checkLog;
        private System.Windows.Forms.TextBox textLogPath;
        private System.Windows.Forms.Button butLogBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown logIntNum;
        private System.Windows.Forms.Label label3;
    }
}