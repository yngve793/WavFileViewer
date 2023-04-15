using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OpenFileDialog of1 = new OpenFileDialog();
            // of1.Filter = "Audio files (*.wav)|*.txt|All files (*.*)|*.*'";

            if (of1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = of1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WavFilev wf = new WavFilev(textBox1.Text);

            formsPlot1.Plot.AddSignal(wf.audioData, wf.sampelingRate);
            formsPlot1.Plot.XLabel("Time in seconds [S]");
            formsPlot1.Plot.YLabel("Magnitude");
            formsPlot1.Plot.Title("Wav data");
            formsPlot1.Refresh();
        }
    }
}
