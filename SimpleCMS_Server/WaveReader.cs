using System;
using System.Collections.Generic;
using NAudio.Wave;
using SimpleCmsDbClassDLL;

namespace SimpleCMS_Server
{
    class WaveReader
    {
        private WaveIn wi;
        //private WaveData wave;
        private int SAMPLE_RATE = (int)(Math.Pow(2, 13)); // sample rate of the sound card
        Queue<float> sampleQueue = new Queue<float>();
        Queue<Byte> samplingQueue = new Queue<Byte>();
        public event Action<WaveData> OnReceivedWaveData;

        public WaveReader()
        {
            int devcount = WaveIn.DeviceCount;
            // see what audio devices are available
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(SAMPLE_RATE, 1);
            //wi.BufferMilliseconds = wi.WaveFormat.AverageBytesPerSecond / 5000;
            //wi.BufferMilliseconds = 100;

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
        }

        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                int BUFFER_SIZE = SAMPLE_RATE * 2;
                byte[] buffer = new byte[BUFFER_SIZE];

                for (int i = 0; i < e.BytesRecorded; i++)
                {
                    samplingQueue.Enqueue(e.Buffer[i]);
                }
                if (samplingQueue.Count >= BUFFER_SIZE)
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = samplingQueue.Dequeue();
                    }

                    WaveData wave = new WaveData();
                    wave.channel_Id = wi.DeviceNumber;
                    wave.time = DateTime.Now;
                    wave.data = buffer;

                    wave.Floats = new float[SAMPLE_RATE];
                    for (int i = 0; i < buffer.Length; i += 2)
                    {
                        Int16 val = BitConverter.ToInt16(buffer, i);
                        sampleQueue.Enqueue(val);
                    }
                    for (int i = 0; i < wave.Floats.Length; i++)
                    {
                        wave.Floats[i] = sampleQueue.Dequeue();
                    }
                    samplingQueue.Clear();
                    OnReceivedWaveData(wave);
                }
            }

            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }
        public void StartRecording()
        {
            wi.StartRecording();
        }
        public void StopRecording()
        {
            wi.StopRecording();
        }
    }
}
