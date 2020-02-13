using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCMS_Server
{
    interface ITrendCalculator
    {
        string title { get; set; }
        //string option { get; set; }

        TrendData GetTrend(WaveData wave, float[] spectrum);
    }
}
