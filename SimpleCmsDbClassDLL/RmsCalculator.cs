using System;
using System.Linq;

namespace SimpleCmsDbClassDLL
{
    class RmsCalculator : ITrendCalculator
    {
        public string title { get; set; }
        public int start, end; // property들을 읽어옴
                               //생성자
        public RmsCalculator(string title, int start, int end)
        {
            this.title = title;
            this.start = start;
            this.end = end;
        }

        //파싱한 후 옵션을 제대로 가지게 하고 새로운 인스턴스 리턴
        public static RmsCalculator Parse(string title, string line)
        {
            var token = line.Split('-').Select(int.Parse).ToArray();
            return new RmsCalculator(title, token[0], token[1]);
        }
        //Get Rms with Option
        public TrendData GetTrend(WaveData wave, float[] spectrum)
        {
            double square = 0;
            float mean, root = 0;

            for (int i = start; i < end; i++)
            {
                square += (wave.Floats[i] * wave.Floats[i]);
            }
            mean = (float)square / wave.data.Length;
            root = (float)Math.Sqrt(mean);

            var id = title;

            TrendData trendData = new TrendData();
            trendData.Value = root;
            trendData.Time = wave.time;
            //trendData.Id = title;
            return trendData;
        }
    }
}
