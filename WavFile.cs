using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using FftSharp;

namespace WavFileViewer
{
    class WavFilev
    {

        public readonly string fileName;
        public readonly double[] audioData;
        public readonly int sampelingRate;

        public WavFilev(string fileName)
        {
            this.fileName = fileName;
            (this.audioData, this.sampelingRate) = WavFilev.ReadWav(this.fileName);
        }

        public WavFilev(double[] data, int sampelingRate)
        {
            this.audioData = data;
            this.sampelingRate = sampelingRate;
        }

        /// <summary>
        /// Calculate the power of the electrical signal in Watt.
        /// </summary>
        public double Power
        {
            get
            {
                double power = 0;
                foreach (double value in this.audioData)
                {
                    power += value * value;
                }
                return power / this.audioData.Length;
            }
        }

        public double Duration => (double)this.audioData.Length / (double)this.sampelingRate;

        public double BinSize => ((double)this.sampelingRate / (double)this.audioData.Length);

        public int Nyquist => (int)(this.sampelingRate / 2);

        public double[] FrequencyVector(int VectorLength)
        {

            double bs = (double)this.Nyquist / (double)(VectorLength * this.Duration);
            double[] freq_vector = new double[VectorLength];
            for (int i = 0; i < freq_vector.Length; i++)
            {
                freq_vector[i] = i * bs;
            }
            return freq_vector;
        }


        public int Power2Length
        {
            get
            {
                double power2 = Math.Log(this.audioData.Length, 2);
                return (int)Math.Ceiling(power2);
            }
        }


        public double[] DiscreteFourierTransform()
        {

            // Shape the signal using a Hanning window
            var window = new FftSharp.Windows.Hanning();

            double[] signal = new double[this.audioData.Length];
            Array.Copy(this.audioData, signal, this.audioData.Length);
            window.ApplyInPlace(signal);


            // Adjust to power of 2
            double[] signal_p2 = new double[(int)Math.Pow(2, this.Power2Length+1)];
            Array.Copy(signal, signal_p2, this.audioData.Length);
            
            double[] fftPwr = Transform.FFTpower(signal_p2);

            double[] out_data = new double[(int)fftPwr.Length/2];
            for (int i= 0; i < out_data.Length; i++)
            {
                out_data[i] = fftPwr[i];
            }
            return out_data;
        }


        public double[] PowerLevel(int halfWindow)
        {
            double[] powerLevel = new double[this.audioData.Length];
            int fullWindow = (2 * halfWindow) + 1;

            double partialSum = 0;
            for (int i = 0; i < this.audioData.Length; i++)
            {
                partialSum += this.audioData[i] * this.audioData[i];
                if (i > fullWindow)
                {
                    partialSum -= this.audioData[i - fullWindow] * this.audioData[i - fullWindow];
                    powerLevel[i] = partialSum / fullWindow;
                }
            }
            return powerLevel;
        }


        static (double[] audio, int sampleRate) ReadWav(string filePath)
        {
            var afr = new NAudio.Wave.AudioFileReader(filePath);
            int sampleRate = afr.WaveFormat.SampleRate;
            int sampleCount = (int)(afr.Length / afr.WaveFormat.BitsPerSample / 8);
            int channelCount = afr.WaveFormat.Channels;
            var audio = new List<double>(sampleCount);
            var buffer = new float[sampleRate * channelCount];
            int samplesRead = 0;
            while ((samplesRead = afr.Read(buffer, 0, buffer.Length)) > 0)
                audio.AddRange(buffer.Take(samplesRead).Select(x => (double)x));

            return (audio.ToArray(), sampleRate);            
        }
    }
}
