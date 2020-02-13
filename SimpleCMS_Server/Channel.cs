using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace SimpleCMS_Server
{
    partial class Channel
    {
        /*
         *  Channel 이름이 맞는지?
         *  현재는 테이블 입력을 저장해서 Wave를 넘기는 역할을 가지고 있음
         *  네이밍 고민할것
         */
        private WaveIn wi;
        //private int SAMPLE_RATE = (int)(Math.Pow(2, 13)); // sample rate of the sound card
        Queue<float> sampleQueue = new Queue<float>();
        Queue<Byte> samplingQueue = new Queue<Byte>();
        public event Action<WaveData> OnReceivedWaveData;

        partial void OnCreated()
        {
            int devcount = WaveIn.DeviceCount;
            // see what audio devices are available
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            wi = new WaveIn();
            wi.DeviceNumber = 0;
            Console.WriteLine(sample_rate +" "+ Id);
            wi.WaveFormat = new NAudio.Wave.WaveFormat(sample_rate, 1);
            //wi.BufferMilliseconds = wi.WaveFormat.AverageBytesPerSecond / 5000;
            //wi.BufferMilliseconds = 100;

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
        }

        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                int BUFFER_SIZE = sample_rate * 2;
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
                    wave.channel_Id = Id;
                    wave.time = DateTime.Now;
                    wave.data = buffer;

                    wave.Floats = new float[sample_rate];
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
            try
            {
                wi.StartRecording();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }
        public void StopRecording()
        {
            wi.StopRecording();
        }
    }
}
