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
            WavFilev wavFilev = new WavFilev(textBox1.Text);
            this.UpdateSignalPlot(wavFilev, 100);
            this.UpdateFrequencyPlot(wavFilev);

            this.textBox2.Text = Math.Round(wavFilev.Power, 2).ToString();
        }


        /// <summary>
        /// Plot the raw signal
        /// </summary>
        /// <param name="wavFilev">Data source</param>
        /// <param name="powerlevel">Length of half window used in the function</param>
        private void UpdateSignalPlot(WavFilev wavFilev, int powerlevel)
        {
            formsPlot1.Reset();
            formsPlot1.Plot.AddSignal(wavFilev.audioData, wavFilev.sampelingRate, Color.Blue, "Raw signal");
            formsPlot1.Plot.XLabel("Time in seconds [S]");
            formsPlot1.Plot.YLabel("Magnitude");
            formsPlot1.Plot.Title("Wav data");
            formsPlot1.Plot.AddSignal(wavFilev.PowerLevel(powerlevel), wavFilev.sampelingRate, Color.Red, "PowerLevel");
            formsPlot1.Plot.Legend(true);
            formsPlot1.Refresh();
        }

        /// <summary>
        /// Plot the frequency data
        /// </summary>
        /// <param name="wavFilev">Data source</param>
        private void UpdateFrequencyPlot(WavFilev wavFilev)
        {
            // Generate the frequency domain signal
            (var y_fft, var x_fft) = wavFilev.DiscreteFourierTransform();
            formsPlot2.Reset();
            formsPlot2.Plot.AddSignal(y_fft, 1 / x_fft[1]);
            formsPlot2.Plot.XLabel("Frequency [Hz]");
            formsPlot2.Plot.YLabel("Magnitude");
            formsPlot2.Refresh();
        }

        /// <summary>
        /// Generate a synthetic signal 
        /// </summary>
        /// <param name="fs">Sampling rate</param>
        /// <param name="duration">Length of the signal in time</param>
        /// <param name="gen_freq">Frequency of added sinus frequency</param>
        /// <returns></returns>
        private double[] generateSignal(int fs, double duration, double gen_freq)
        {
            double[] data = new double[(int)(duration * fs)];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Math.Sin(i * 2 * Math.PI * gen_freq / fs);
            }
            return data;
        }

        /// <summary>
        /// Read parametres and generate a signal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox_fs.Text, out int fs);
            Double.TryParse(textBox_duration.Text, out double duration);
            Double.TryParse(textBox_freq.Text, out double gen_freq);

            // Generate the signal
            var signal = this.generateSignal(fs, duration, gen_freq);

            WavFilev wavFilev = new WavFilev(signal, fs);
            this.UpdateSignalPlot(wavFilev, 100);
            this.UpdateFrequencyPlot(wavFilev);
        }
    }
}
