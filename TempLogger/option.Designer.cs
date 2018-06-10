﻿namespace TempLogger
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
            this.textLogPath = new System.Windows.Forms.TextBox();
            this.butLogBrowse = new System.Windows.Forms.Button();
            this.checkLog = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlertGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.GoupLog.SuspendLayout();
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
            this.AlertGroup.Location = new System.Drawing.Point(12, 12);
            this.AlertGroup.Name = "AlertGroup";
            this.AlertGroup.Size = new System.Drawing.Size(182, 142);
            this.AlertGroup.TabIndex = 0;
            this.AlertGroup.TabStop = false;
            this.AlertGroup.Text = "Alert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sound";
            // 
            // butbrowse
            // 
            this.butbrowse.Location = new System.Drawing.Point(99, 113);
            this.butbrowse.Name = "butbrowse";
            this.butbrowse.Size = new System.Drawing.Size(75, 23);
            this.butbrowse.TabIndex = 6;
            this.butbrowse.Text = "browse";
            this.butbrowse.UseVisualStyleBackColor = true;
            this.butbrowse.Click += new System.EventHandler(this.butbrowse_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(7, 116);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(86, 20);
            this.textPath.TabIndex = 5;
            // 
            // CheckAlert
            // 
            this.CheckAlert.AutoSize = true;
            this.CheckAlert.Location = new System.Drawing.Point(10, 18);
            this.CheckAlert.Name = "CheckAlert";
            this.CheckAlert.Size = new System.Drawing.Size(83, 17);
            this.CheckAlert.TabIndex = 4;
            this.CheckAlert.Text = "Alert :Value:";
            this.CheckAlert.UseVisualStyleBackColor = true;
            this.CheckAlert.CheckedChanged += new System.EventHandler(this.CheckAlert_CheckedChanged);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(40, 65);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(120, 20);
            this.numMin.TabIndex = 3;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(42, 38);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 20);
            this.numMax.TabIndex = 2;
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(7, 62);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(24, 13);
            this.labMin.TabIndex = 1;
            this.labMin.Text = "Min";
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Location = new System.Drawing.Point(7, 40);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(27, 13);
            this.labMax.TabIndex = 0;
            this.labMax.Text = "Max";
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(22, 165);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 22);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCanc
            // 
            this.butCanc.Location = new System.Drawing.Point(103, 165);
            this.butCanc.Name = "butCanc";
            this.butCanc.Size = new System.Drawing.Size(75, 22);
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
            this.GoupLog.Controls.Add(this.label2);
            this.GoupLog.Controls.Add(this.checkLog);
            this.GoupLog.Controls.Add(this.textLogPath);
            this.GoupLog.Controls.Add(this.butLogBrowse);
            this.GoupLog.Location = new System.Drawing.Point(201, 13);
            this.GoupLog.Name = "GoupLog";
            this.GoupLog.Size = new System.Drawing.Size(200, 141);
            this.GoupLog.TabIndex = 3;
            this.GoupLog.TabStop = false;
            this.GoupLog.Text = "Log";
            // 
            // textLogPath
            // 
            this.textLogPath.Location = new System.Drawing.Point(7, 58);
            this.textLogPath.Name = "textLogPath";
            this.textLogPath.Size = new System.Drawing.Size(100, 20);
            this.textLogPath.TabIndex = 0;
            // 
            // butLogBrowse
            // 
            this.butLogBrowse.Location = new System.Drawing.Point(113, 58);
            this.butLogBrowse.Name = "butLogBrowse";
            this.butLogBrowse.Size = new System.Drawing.Size(75, 23);
            this.butLogBrowse.TabIndex = 6;
            this.butLogBrowse.Text = "browse";
            this.butLogBrowse.UseVisualStyleBackColor = true;
            this.butLogBrowse.Click += new System.EventHandler(this.textLogPath_Click);
            // 
            // checkLog
            // 
            this.checkLog.AutoSize = true;
            this.checkLog.Location = new System.Drawing.Point(7, 17);
            this.checkLog.Name = "checkLog";
            this.checkLog.Size = new System.Drawing.Size(87, 17);
            this.checkLog.TabIndex = 7;
            this.checkLog.Text = "Save :Value:";
            this.checkLog.UseVisualStyleBackColor = true;
            this.checkLog.CheckedChanged += new System.EventHandler(this.checkLog_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Where to save";
            // 
            // option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 208);
            this.Controls.Add(this.GoupLog);
            this.Controls.Add(this.butCanc);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.AlertGroup);
            this.Name = "option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.option_Load);
            this.AlertGroup.ResumeLayout(false);
            this.AlertGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.GoupLog.ResumeLayout(false);
            this.GoupLog.PerformLayout();
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
    }
}