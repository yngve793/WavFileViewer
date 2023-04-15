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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            OpenFileDialog of1 = new OpenFileDialog();
            // of1.Filter = "Audio files (*.wav)|*.txt|All files (*.*)|*.*'";

            if (of1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = of1.SafeFileName;
            }
        }
    }
}
