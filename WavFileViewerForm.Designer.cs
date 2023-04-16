
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_freq = new System.Windows.Forms.TextBox();
            this.textBox_duration = new System.Windows.Forms.TextBox();
            this.textBox_fs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\Users\\yngve\\Documents\\demo.wav";
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(14, 78);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(856, 256);
            this.formsPlot1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(885, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calculated power";
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(14, 342);
            this.formsPlot2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(856, 284);
            this.formsPlot2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_freq);
            this.groupBox1.Controls.Add(this.textBox_duration);
            this.groupBox1.Controls.Add(this.textBox_fs);
            this.groupBox1.Location = new System.Drawing.Point(878, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 190);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(23, 142);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(174, 34);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Generate signal";
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
            // 
            // textBox_fs
            // 
            this.textBox_fs.Location = new System.Drawing.Point(23, 36);
            this.textBox_fs.Name = "textBox_fs";
            this.textBox_fs.Size = new System.Drawing.Size(56, 26);
            this.textBox_fs.TabIndex = 13;
            this.textBox_fs.Text = "5000";
            // 
            // WavFileViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formsPlot2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "WavFileViewerForm";
            this.Text = "WavFileViewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_freq;
        private System.Windows.Forms.TextBox textBox_duration;
        private System.Windows.Forms.TextBox textBox_fs;
    }
}

