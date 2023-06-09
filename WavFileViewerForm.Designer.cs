﻿
namespace WavFileViewer
{
    partial class WavFileViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WavFileViewerForm));
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonLoadWav = new System.Windows.Forms.Button();
            this.formsPlotTime = new ScottPlot.FormsPlot();
            this.formsPlotFrequency = new ScottPlot.FormsPlot();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_freq = new System.Windows.Forms.TextBox();
            this.textBox_duration = new System.Windows.Forms.TextBox();
            this.textBox_fs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRmsValueInData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDurationInData = new System.Windows.Forms.TextBox();
            this.textBoxNrSamplesInData = new System.Windows.Forms.TextBox();
            this.textBoxFsInData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonLockX = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonNeither = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(6, 23);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(411, 26);
            this.textBoxFileName.TabIndex = 0;
            this.textBoxFileName.Text = "C:\\Users\\yngve\\Documents\\demo.wav";
            this.textBoxFileName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxFileName_MouseUp);
            // 
            // buttonLoadWav
            // 
            this.buttonLoadWav.Location = new System.Drawing.Point(434, 17);
            this.buttonLoadWav.Name = "buttonLoadWav";
            this.buttonLoadWav.Size = new System.Drawing.Size(75, 32);
            this.buttonLoadWav.TabIndex = 2;
            this.buttonLoadWav.Text = "Load";
            this.buttonLoadWav.UseVisualStyleBackColor = true;
            this.buttonLoadWav.Click += new System.EventHandler(this.buttonLoadWav_Click);
            // 
            // formsPlotTime
            // 
            this.formsPlotTime.Location = new System.Drawing.Point(14, 78);
            this.formsPlotTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlotTime.Name = "formsPlotTime";
            this.formsPlotTime.Size = new System.Drawing.Size(856, 316);
            this.formsPlotTime.TabIndex = 3;
            // 
            // formsPlotFrequency
            // 
            this.formsPlotFrequency.Location = new System.Drawing.Point(14, 372);
            this.formsPlotFrequency.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlotFrequency.Name = "formsPlotFrequency";
            this.formsPlotFrequency.Size = new System.Drawing.Size(856, 334);
            this.formsPlotFrequency.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAppend);
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_freq);
            this.groupBox1.Controls.Add(this.textBox_duration);
            this.groupBox1.Controls.Add(this.textBox_fs);
            this.groupBox1.Location = new System.Drawing.Point(866, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 190);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // buttonAppend
            // 
            this.buttonAppend.Enabled = false;
            this.buttonAppend.Location = new System.Drawing.Point(131, 142);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(103, 34);
            this.buttonAppend.TabIndex = 18;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(23, 142);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(103, 34);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gen. freq. [Hz]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Duration [s]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sampling rate [Hz]";
            // 
            // textBox_freq
            // 
            this.textBox_freq.Location = new System.Drawing.Point(23, 100);
            this.textBox_freq.Name = "textBox_freq";
            this.textBox_freq.Size = new System.Drawing.Size(56, 26);
            this.textBox_freq.TabIndex = 15;
            this.textBox_freq.Text = "134";
            // 
            // textBox_duration
            // 
            this.textBox_duration.Location = new System.Drawing.Point(23, 68);
            this.textBox_duration.Name = "textBox_duration";
            this.textBox_duration.Size = new System.Drawing.Size(56, 26);
            this.textBox_duration.TabIndex = 14;
            this.textBox_duration.Text = "2";
            this.textBox_duration.TextChanged += new System.EventHandler(this.textBox_duration_TextChanged);
            // 
            // textBox_fs
            // 
            this.textBox_fs.Location = new System.Drawing.Point(23, 36);
            this.textBox_fs.Name = "textBox_fs";
            this.textBox_fs.Size = new System.Drawing.Size(56, 26);
            this.textBox_fs.TabIndex = 13;
            this.textBox_fs.Text = "5000";
            this.textBox_fs.TextChanged += new System.EventHandler(this.textBox_fs_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRmsValueInData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxDurationInData);
            this.groupBox2.Controls.Add(this.textBoxNrSamplesInData);
            this.groupBox2.Controls.Add(this.textBoxFsInData);
            this.groupBox2.Location = new System.Drawing.Point(872, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 190);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signal Info";
            // 
            // textBoxRmsValueInData
            // 
            this.textBoxRmsValueInData.Location = new System.Drawing.Point(158, 126);
            this.textBoxRmsValueInData.Name = "textBoxRmsValueInData";
            this.textBoxRmsValueInData.Size = new System.Drawing.Size(56, 26);
            this.textBoxRmsValueInData.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "RMS value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sampling rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Duration [s]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of samples";
            // 
            // textBoxDurationInData
            // 
            this.textBoxDurationInData.Location = new System.Drawing.Point(158, 94);
            this.textBoxDurationInData.Name = "textBoxDurationInData";
            this.textBoxDurationInData.Size = new System.Drawing.Size(56, 26);
            this.textBoxDurationInData.TabIndex = 15;
            // 
            // textBoxNrSamplesInData
            // 
            this.textBoxNrSamplesInData.Location = new System.Drawing.Point(158, 30);
            this.textBoxNrSamplesInData.Name = "textBoxNrSamplesInData";
            this.textBoxNrSamplesInData.Size = new System.Drawing.Size(56, 26);
            this.textBoxNrSamplesInData.TabIndex = 14;
            // 
            // textBoxFsInData
            // 
            this.textBoxFsInData.Location = new System.Drawing.Point(158, 62);
            this.textBoxFsInData.Name = "textBoxFsInData";
            this.textBoxFsInData.Size = new System.Drawing.Size(56, 26);
            this.textBoxFsInData.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxFileName);
            this.groupBox3.Controls.Add(this.buttonLoadWav);
            this.groupBox3.Location = new System.Drawing.Point(81, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 55);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wav file selection";
            // 
            // radioButtonLockX
            // 
            this.radioButtonLockX.AutoSize = true;
            this.radioButtonLockX.Location = new System.Drawing.Point(6, 25);
            this.radioButtonLockX.Name = "radioButtonLockX";
            this.radioButtonLockX.Size = new System.Drawing.Size(110, 24);
            this.radioButtonLockX.TabIndex = 20;
            this.radioButtonLockX.Text = "Lock x axis";
            this.radioButtonLockX.UseVisualStyleBackColor = true;
            this.radioButtonLockX.CheckedChanged += new System.EventHandler(this.radioButtonLockX_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 24);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "Lock y axis";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonNeither
            // 
            this.radioButtonNeither.AutoSize = true;
            this.radioButtonNeither.Checked = true;
            this.radioButtonNeither.Location = new System.Drawing.Point(6, 85);
            this.radioButtonNeither.Name = "radioButtonNeither";
            this.radioButtonNeither.Size = new System.Drawing.Size(85, 24);
            this.radioButtonNeither.TabIndex = 22;
            this.radioButtonNeither.TabStop = true;
            this.radioButtonNeither.Text = "Neither";
            this.radioButtonNeither.UseVisualStyleBackColor = true;
            this.radioButtonNeither.CheckedChanged += new System.EventHandler(this.radioButtonNeither_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonLockX);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButtonNeither);
            this.groupBox5.Location = new System.Drawing.Point(866, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 120);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select zoom axis";
            // 
            // WavFileViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 719);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formsPlotFrequency);
            this.Controls.Add(this.formsPlotTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WavFileViewerForm";
            this.Text = "WavFileViewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonLoadWav;
        private ScottPlot.FormsPlot formsPlotTime;
        private ScottPlot.FormsPlot formsPlotFrequency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_freq;
        private System.Windows.Forms.TextBox textBox_duration;
        private System.Windows.Forms.TextBox textBox_fs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRmsValueInData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDurationInData;
        private System.Windows.Forms.TextBox textBoxNrSamplesInData;
        private System.Windows.Forms.TextBox textBoxFsInData;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonLockX;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonNeither;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

