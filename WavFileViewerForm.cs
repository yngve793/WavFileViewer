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

        // Global variable for WavFile
        private WavFile wavFile;

        public WavFileViewerForm()
        {
            InitializeComponent();
        }

        private void textBoxFileName_MouseUp(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // of1.Filter = "Audio files (*.wav)|*.txt|All files (*.*)|*.*'";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog.FileName;
            }
        }

        private void buttonLoadWav_Click(object sender, EventArgs e)
        {
            this.wavFile = new WavFile(textBoxFileName.Text);
            this.UpdateSignalPlot(this.wavFile, 100);
            this.UpdateFrequencyPlot(this.wavFile);
        }

        /// <summary>
        /// Plot the raw signal
        /// </summary>
        /// <param name="wavFile">Data source</param>
        /// <param name="powerlevel">Length of half window used in the function</param>
        private void UpdateSignalPlot(WavFile wavFile, int powerlevel)
        {
            formsPlotTime.Reset();
            formsPlotTime.Plot.AddSignal(wavFile.audioData, wavFile.sampelingRate, Color.Blue, "Raw signal");
            formsPlotTime.Plot.XLabel("Time in seconds [S]");
            formsPlotTime.Plot.YLabel("Magnitude");
            formsPlotTime.Plot.Title("Time representation");
            formsPlotTime.Plot.AddSignal(wavFile.PowerLevel(powerlevel), wavFile.sampelingRate, Color.Red, "PowerLevel");
            formsPlotTime.Plot.Legend(true);
            formsPlotTime.Refresh();

            this.UpdateInfoBoard(wavFile);
        }

        /// <summary>
        /// Update wav information field
        /// </summary>
        /// <param name="wavFile"></param>
        private void UpdateInfoBoard(WavFile wavFile)
        {
            this.textBoxNrSamplesInData.Text = wavFile.audioData.Length.ToString();
            this.textBoxFsInData.Text = wavFile.sampelingRate.ToString();
            this.textBoxDurationInData.Text = wavFile.Duration.ToString();
            this.textBoxRmsValueInData.Text = wavFile.RMS.ToString();
        }

        /// <summary>
        /// Plot the frequency data
        /// </summary>
        /// <param name="wavFile">Data source</param>
        private void UpdateFrequencyPlot(WavFile wavFile)
        {
            // Generate the frequency domain signal
            (var y_fft, var x_fft) = wavFile.DiscreteFourierTransform();
            formsPlotFrequency.Reset();
            formsPlotFrequency.Plot.AddSignal(y_fft, 1 / x_fft[1]);
            formsPlotFrequency.Plot.XLabel("Frequency [Hz]");
            formsPlotFrequency.Plot.YLabel("Magnitude");
            formsPlotFrequency.Plot.Title("Frequency representation");
            formsPlotFrequency.Refresh();
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
        /// Read parameters and generate a signal
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

            this.wavFile = new WavFile(signal, fs);
            this.UpdateSignalPlot(this.wavFile, 100);
            this.UpdateFrequencyPlot(this.wavFile);

            this.buttonAppend.Enabled = true;
        }

        /// <summary>
        /// Disable append button when sampling rate is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_fs_TextChanged(object sender, EventArgs e)
        {
            this.buttonAppend.Enabled = false;
        }

        /// <summary>
        /// Disable append when duration is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_duration_TextChanged(object sender, EventArgs e)
        {
            this.buttonAppend.Enabled = false;
        }

        /// <summary>
        /// Append the new signal to the existing signal. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAppend_Click(object sender, EventArgs e)
        {
            if (this.wavFile != null)
            {
                Int32.TryParse(textBox_fs.Text, out int fs);
                Double.TryParse(textBox_duration.Text, out double duration);
                Double.TryParse(textBox_freq.Text, out double gen_freq);

                // Generate the signal
                var signal_2 = this.generateSignal(fs, duration, gen_freq);

                for (int i = 0; i < signal_2.Length; i++)
                {
                    signal_2[i] = (signal_2[i] + wavFile.audioData[i]) / 2;
                }

                this.wavFile = new WavFile(signal_2, fs);
                this.UpdateSignalPlot(this.wavFile, 100);
                this.UpdateFrequencyPlot(this.wavFile);
            }
        }
    }
}
