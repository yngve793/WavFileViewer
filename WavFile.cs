using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using FftSharp;

namespace WavFileViewer
{
    class WavFile
    {

        public readonly string fileName;
        public readonly double[] audioData;
        public readonly int sampelingRate;

        /// <summary>
        /// Constructor used to read wav files
        /// </summary>
        /// <param name="fileName">Name of the file with full path</param>
        public WavFile(string fileName)
        {
            this.fileName = fileName;
            (this.audioData, this.sampelingRate) = WavFile.ReadWav(this.fileName);
        }

        /// <summary>
        /// Constructor for synthetically generated data
        /// </summary>
        /// <param name="data">The signal</param>
        /// <param name="sampelingRate">Sampling rate</param>
        public WavFile(double[] data, int sampelingRate)
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

        /// <summary>
        /// Calculate the RMS value for the signal
        /// </summary>
        public double RMS
        {
            get
            {
                double rms = 0;
                foreach (double value in this.audioData)
                {
                    rms += value * value;
                }
                rms /= this.audioData.Length;
                return Math.Sqrt(rms);
            }
        }

        /// <summary>
        /// Signal duration
        /// </summary>
        public double Duration => (double)this.audioData.Length / (double)this.sampelingRate;

        /// <summary>
        /// Nyquist frequency
        /// </summary>
        public int Nyquist => (int)(this.sampelingRate / 2);

        /// <summary>
        /// Highest power of two that fits in the audioData array. 
        /// </summary>
        public int Power2Length
        {
            get
            {
                double power2 = Math.Log(this.audioData.Length, 2);
                return (int)Math.Floor(power2);
            }
        }

        /// <summary>
        /// Uses the FFT function in FftSharp to transform to the frequency domain. 
        /// FftSharp library only handles arrays of size that is a power of two. 
        /// Hanning window is applied to the signal to reduce ripples.
        /// </summary>
        /// <returns>Real part of the frequency domain:double[], frequency vector:double[]</returns>
        public (double[], double[]) DiscreteFourierTransform()
        {
            // Only power of 2 length can be used

            // Create a new array of appropriate length 
            double[] signal = new double[(int)Math.Pow(2, this.Power2Length)];

            // Copy data 
            Array.Copy(this.audioData, signal, signal.Length);

            // Apply window
            var window = new FftSharp.Windows.Hanning();
            window.ApplyInPlace(signal);

            // Convert to complex 
            Complex[] c_signal = Transform.MakeComplex(signal);

            // Preform the transform
            Transform.FFT(c_signal);

            // Extract the absolute value
            var abs_signal = Transform.Absolute(c_signal);

            // Copy non negative components
            double[] out_signal = new double[(int)(abs_signal.Length / 2)];
            Array.Copy(abs_signal, out_signal, out_signal.Length);

            // Calculate frequency array 
            double[] x_freq = Transform.FFTfreq(this.sampelingRate, out_signal, true);


            return (out_signal, x_freq);
        }

        /// <summary>
        /// Estimate power level through the data set
        /// TODO: Fix ends. Energy start out at zero in the current version
        /// </summary>
        /// <param name="halfWindow">Defines the size of the sliding window</param>
        /// <returns>power level:double[]</returns>
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

        /// <summary>
        /// Read waveform and sampling rate from a *.wav file
        /// </summary>
        /// <param name="filePath">Name of the file with full path</param>
        /// <returns>audio:double[] and sampling-rate:int</returns>
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
