using AutoIt;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NoteDetector {
    public partial class Form1 : Form {

        NAudio.Wave.WaveInEvent Wave;

        readonly double[] AudioValues;
        readonly double[] FftValues;

        readonly int SampleRate = 44100;
        readonly int BitDepth = 16;
        readonly int ChannelCount = 1;
        readonly int BufferMilliseconds = 20;

        string keyBind = "coco";


        public Form1() {
            InitializeComponent();

            AudioValues = new double[SampleRate * BufferMilliseconds / 1000];
            double[] paddedAudio = FftSharp.Pad.ZeroPad(AudioValues);
            double[] fftMag = FftSharp.Transform.FFTmagnitude(paddedAudio);
            FftValues = new double[fftMag.Length];

            double fftPeriod = FftSharp.Transform.FFTfreqPeriod(SampleRate,fftMag.Length);
        }

        private void Form1_Load(object sender,EventArgs e) {
            for(int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++) {
                var caps = NAudio.Wave.WaveIn.GetCapabilities(i);
                comboBox1.Items.Add(caps.ProductName);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender,EventArgs e) {
            if(Wave != null) {
                Wave.StopRecording();
                Wave.Dispose();

                for(int i = 0; i < AudioValues.Length; i++)
                    AudioValues[i] = 0;
            }

            if(comboBox1.SelectedIndex == -1)
                return;

            Wave = new NAudio.Wave.WaveInEvent() {
                DeviceNumber = comboBox1.SelectedIndex,
                WaveFormat = new NAudio.Wave.WaveFormat(SampleRate,BitDepth,ChannelCount),
                BufferMilliseconds = BufferMilliseconds
            };

            Wave.DataAvailable += WaveIn_DataAvailable;
            Wave.StartRecording();

        }

        void WaveIn_DataAvailable(object sender,NAudio.Wave.WaveInEventArgs e) {
            for(int i = 0; i < e.Buffer.Length / 2; i++)
                AudioValues[i] = BitConverter.ToInt16(e.Buffer,i * 2);
        }

        private void timer1_Tick(object sender,EventArgs e) {
            double[] paddedAudio = FftSharp.Pad.ZeroPad(AudioValues);
            double[] fftMag = FftSharp.Transform.FFTpower(paddedAudio);
            Array.Copy(fftMag,FftValues,fftMag.Length);

            // find the frequency peak
            int peakIndex = 0;
            for(int i = 0; i < fftMag.Length; i++) {
                if(fftMag[i] > fftMag[peakIndex])
                    peakIndex = i;
            }
            double fftPeriod = FftSharp.Transform.FFTfreqPeriod(SampleRate,fftMag.Length);
            double peakFrequency = fftPeriod * peakIndex;
            

            // auto-scale the plot Y axis limits
            double fftPeakMag = fftMag.Max();

            label1.Text = $"Peak Frequency:";

            bind0.ForeColor = Color.Black;
            bind1.ForeColor = Color.Black;
            bind2.ForeColor = Color.Black;
            bind3.ForeColor = Color.Black;
            bind4.ForeColor = Color.Black;
            bind5.ForeColor = Color.Black;

            keyBind = "coco";

            if(fftPeakMag >= trackBar1.Value) {
                label1.Text = $"Peak Frequency: {peakFrequency:N0} Hz";

                switch(peakFrequency) {

                    case double n when(n <= 200):
                        bind0.ForeColor = Color.Red;
                        keyBind = "Q";
                        break;

                    case double n when(n >= 300 && n <=400):
                        bind1.ForeColor = Color.Red;
                        keyBind = "W";
                        break;

                    case double n when(n > 400 && n <= 500):
                        bind2.ForeColor = Color.Red;
                        keyBind = "E";
                        break;

                    case double n when(n > 500 && n <= 600):
                        bind3.ForeColor = Color.Red;
                        keyBind = "R";
                        break;

                    case double n when(n > 600 && n <= 1500):
                        bind4.ForeColor = Color.Red;
                        keyBind = "D";
                        break;

                    case double n when(n > 1500):
                        bind5.ForeColor = Color.Red;
                        keyBind = "F";
                        break;

                }


                if(checkBox1.Checked && keyBind != "coco") {
                    AutoItX.Send("{"+keyBind+" down}");
                    AutoItX.Sleep(10);
                    AutoItX.Send("{"+keyBind+" up}");
                }

            }
            


        }

        private void trackBar1_Scroll(object sender,EventArgs e) {
            label2.Text = $"Mic Sensibility: {trackBar1.Value}";
        }
    }
}
