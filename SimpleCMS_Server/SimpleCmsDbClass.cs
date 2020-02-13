namespace SimpleCMS_Server
{

    partial class SimpleCmsDbClassDataContext
    {
    }
    partial class TrendData
    {
    }

    partial class WaveData
    {
        public float[] Floats;
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