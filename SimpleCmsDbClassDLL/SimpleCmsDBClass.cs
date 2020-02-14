using System;

namespace SimpleCmsDbClassDLL
{
    partial class SimpleCmsDBClassDataContext
    {
    }
    partial class Channel
    {
    }

    partial class WaveData
    {
        public float[] Floats;

        public void ToFloatArray()
        {
            Floats = new float[data.ToArray().Length / 2];

            for(int i = 0; i<Floats.Length; i++)
            {
                float val = BitConverter.ToInt16(data.ToArray(), i*2);
                Floats[i] = val;
            }
            //var byteArray = new byte[data.ToArray().Length];
            //Buffer.BlockCopy(data.ToArray(), 0, Floats, 0, data.ToArray().Length / 2);
        }

    }
    partial class TrendData
    {
    }

    partial class TrendConfig
    {
        public virtual TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            return new TrendData();
        }
    }

    partial class RmsConfig : TrendConfig
    {

        public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            RmsCalculator peak = new RmsCalculator(name, start, end);
            var trendData = peak.GetTrend(wave, spectrum.fft);
            trendData.trendConfig_Id = base.Id;
            return trendData;
        }

    }
    partial class PeakConfig : TrendConfig
    {
        public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            PeakCalculator peak = new PeakCalculator(name, option);
            var trendData = peak.GetTrend(wave, spectrum.fft);
            trendData.trendConfig_Id = base.Id;
            return trendData;
        }
    }

}