using System;
using System.Numerics;

namespace SimpleCMS_Server
{
    public class Spectrum
    {
        public float[] fft { get; set; }

        public void GetFFT(WaveData wave, bool isPositiveFFT = true)
        {
            int arrayLength = wave.Floats.Length / 2;
            if (isPositiveFFT == false)
                arrayLength *= 2;

            WaveData waveFFT = new WaveData();

            waveFFT.Floats = new float[arrayLength];
            //float[] fft = new float[data.Length]; // this is where we will store the output (fft)
            Complex[] fftComplex = new Complex[wave.data.Length]; // the FFT function requires complex format
            for (int i = 0; i < arrayLength; i++)
            {
                fftComplex[i] = new Complex(wave.Floats[i], 0.0); // make it complex format (imaginary = 0)
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < arrayLength; i++)
            {
                waveFFT.Floats[i] = (float)fftComplex[i].Magnitude; // back to double
                if (isPositiveFFT == true)
                    waveFFT.Floats[i] *= 2;
            }
            this.fft = waveFFT.Floats;
        }

        public static float[] FFTToDecibel(float[] fft)
        {
            float[] data = new float[fft.Length];
            for (int i = 0; i < fft.Length; i++)
            {
                data[i] = (float)Math.Log10(fft[i]); // convert to dB
            }
            return data;
        }
    }
}