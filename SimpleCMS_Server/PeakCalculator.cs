using System;
using Accord.Math;

namespace SimpleCMS_Server
{
    class PeakCalculator : ITrendCalculator
    {
        public string title { get; set; }
        public string option { get; set; }

        //생성자
        public PeakCalculator(string title, string option)
        {
            this.title = title;
            this.option = option;
        }

        public TrendData GetTrend(WaveData wave, float[] spectrum)
        {
            TrendData trendData = new TrendData();
            trendData.Time = wave.time;
            switch (this.option)
            {
                case "p2p":
                    trendData.Value = GetPeakToPeak(wave);
                    break;
                case "upper":
                    trendData.Value = GetUpperPeak(wave);
                    break;
                case "lower":
                    trendData.Value = GetLowerPeak(wave);
                    break;
                case "peak":
                    trendData.Value = GetPeak(wave);
                    break;
                default:
                    throw new Exception("Peak option is unavailable");
            }
            return trendData;
        }

        public float GetPeakToPeak(float[] data)
        {
            float p2p;
            p2p = data.Max() - data.Min();
            return p2p;
        }
        public float GetPeakToPeak(WaveData wave)
        {
            return GetPeakToPeak(wave.Floats);
        }
        //Get Peak
        public float GetUpperPeak(float[] data)
        {
            return data.Max();
        }
        public float GetUpperPeak(WaveData wave)
        {
            return GetUpperPeak(wave.Floats);
        }
        public float GetLowerPeak(float[] data)
        {
            return data.Min();
        }
        public float GetLowerPeak(WaveData wave)
        {
            return GetLowerPeak(wave.Floats);
        }
        public float GetPeak(float[] data)
        {
            float upperPeakScala = data.Max();
            float lowerPeakScala = Math.Abs(data.Min());
            return upperPeakScala > lowerPeakScala == true ? upperPeakScala : lowerPeakScala;
        }
        public float GetPeak(WaveData wave)
        {
            return GetPeak(wave.Floats);
        }
    }
}