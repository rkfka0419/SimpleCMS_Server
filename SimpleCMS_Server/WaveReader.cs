using System;
using System.Collections.Generic;
using NAudio.Wave;
using SimpleCmsDbClassDLL;

namespace SimpleCMS_Server
{
    class WaveReader
    {
        private WaveIn wi;
        Queue<float> sampleQueue = new Queue<float>();
        Queue<Byte> samplingQueue = new Queue<Byte>();
        public event Action<WaveData> OnReceivedWaveData;
        Channel channel;

        public WaveReader(Channel channel)
        {
            this.channel = channel;
            int devcount = WaveIn.DeviceCount;
            // see what audio devices are available
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            wi = new WaveIn();
            wi.DeviceNumber = 0;
            
            wi.WaveFormat = new WaveFormat(this.channel.sample_rate, this.channel.Id);

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
        }

        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                int BUFFER_SIZE = this.channel.sample_rate * 2;
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
                    wave.channel_Id = this.channel.Id;
                    wave.time = DateTime.Now;
                    wave.data = buffer;

                    wave.Floats = new float[this.channel.sample_rate];
                    for (int i = 0; i < buffer.Length; i += 2)
                    {
                        Int16 val = BitConverter.ToInt16(buffer, i);
                        sampleQueue.Enqueue((float)val);
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
