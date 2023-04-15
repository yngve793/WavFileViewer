using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace WavFileViewer
{
    public partial class WavFileViewerForm : Form
    {
        public WavFileViewerForm()
        {
            InitializeComponent();
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // of1.Filter = "Audio files (*.wav)|*.txt|All files (*.*)|*.*'";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WavFilev wf = new WavFilev(textBox1.Text);

            formsPlot1.Plot.AddSignal(wf.audioData, wf.sampelingRate, Color.Blue, "Raw signal");
            formsPlot1.Plot.XLabel("Time in seconds [S]");
            formsPlot1.Plot.YLabel("Magnitude");
            formsPlot1.Plot.Title("Wav data");
            formsPlot1.Plot.AddSignal(wf.PowerLevel(100), wf.sampelingRate,Color.Red, "PowerLevel");
            formsPlot1.Plot.Legend(true);
            formsPlot1.Refresh();

            var y_fft = wf.DiscreteFourierTransform();
            var x_fft = wf.FrequencyVector(y_fft.Length);


            formsPlot2.Plot.AddScatter(x_fft, y_fft);

            // .AddSignal(wf.DiscreteFourierTransform(), , wf.sampelingRate, Color.Blue, "FFT");
            formsPlot2.Plot.XLabel("Frequency");
            formsPlot2.Plot.YLabel("Power");
            formsPlot2.Refresh();


            this.textBox2.Text = Math.Round(wf.Power, 2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int test_freq = 1;
            Int32.TryParse(textBox3.Text, out test_freq);

            double fs = 44100;
            double duration = 0.45;
            // double test_freq = 100;
            double[] data = new double[(int)(duration * fs)];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Math.Sin(i* 2 * Math.PI * test_freq / fs);
            }
            
            WavFilev wf = new WavFilev(data, (int)fs);

            formsPlot1.Plot.AddSignal(wf.audioData, wf.sampelingRate, Color.Blue, "Raw signal");
            formsPlot1.Plot.XLabel("Time in seconds [S]");
            formsPlot1.Plot.YLabel("Magnitude");
            formsPlot1.Plot.Title("Wav data");
            formsPlot1.Plot.AddSignal(wf.PowerLevel(100), wf.sampelingRate, Color.Red, "PowerLevel");
            formsPlot1.Plot.Legend(true);
            formsPlot1.Refresh();

            var y_fft = wf.DiscreteFourierTransform();
            var x_fft = wf.FrequencyVector(y_fft.Length);

            formsPlot2.Plot.AddScatter(x_fft, y_fft);

            // .AddSignal(wf.DiscreteFourierTransform(), , wf.sampelingRate, Color.Blue, "FFT");
            formsPlot2.Plot.XLabel("Frequency");
            formsPlot2.Plot.YLabel("Power");
            formsPlot2.Refresh();


            this.textBox2.Text = Math.Round(wf.Power, 2).ToString();
        }
    }
}
