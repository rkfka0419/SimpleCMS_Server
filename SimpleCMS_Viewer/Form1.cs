using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCmsDbClassDLL;
using Steema.TeeChart.Styles;

namespace SimpleCMS_Viewer
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";
        LineDrawer lineDrawWave;
        LineDrawer lineDrawFFT;
        List<LineDrawer> trendList;

        public Form1()
        {
            InitializeComponent();

            trendList = new List<LineDrawer>();
            lineDrawWave = new LineDrawer(tChartWave, new Steema.TeeChart.Styles.Line());
            lineDrawFFT = new LineDrawer(tChartFFT, new Steema.TeeChart.Styles.Line());
            chartStartTime.ShowUpDown = true;
            chartStartTime.Format = DateTimePickerFormat.Custom;
            chartStartTime.CustomFormat = "M'월' d'일' H'시' m'분' s'초'";
            chartEndTime.ShowUpDown = true;
            chartEndTime.Format = DateTimePickerFormat.Custom;
            chartEndTime.CustomFormat = "M'월' d'일' H'시' m'분' s'초'";

            tChartTrends.ClickSeries += trendChart_ClickSeries;

            using (var db = new SimpleCmsDBClassDataContext(connectionString))
            {
                if (!db.DatabaseExists())
                {
                    MessageBox.Show("database does not exist");
                    return;
                }



                // 채널 갯수에 따라 TabControl 확장 예정
                var channels = db.Channel.Select(channel => channel).FirstOrDefault();
                //tabPage1.Text = channels.name;
                tabControl.TabPages[0].Text = channels.name;


                //TrendConfig ID와 TrendData의 config_ID를 조인 -> name을 가져온다.
                //TrendConfig 갯수만큼 LineDraw 인스턴스 생성
                // 해당 wave 시간의 trend를 화면에 그린다.
                var trends = from trendData in db.TrendData
                             from trendConfig in db.TrendConfig
                             where trendData.trendConfig_Id == trendConfig.Id
                             select new
                             {
                                 Title = trendConfig.name,
                                 Time = trendData.Time,
                                 Value = trendData.Value
                             };

                var groupbyTrend = from trnd in trends group trnd by new { trnd.Title } into grp select grp;
                foreach (var item in groupbyTrend)
                {
                    LineDrawer lineTempObj = new LineDrawer(tChartTrends, new Steema.TeeChart.Styles.Line());
                    
                    foreach (var data in item)
                    {
                        //lineTempObj.DrawLine(data.Title, (float)data.Value);
                        lineTempObj.DrawLine(data.Title, data.Time, data.Value);
                    }
                    trendList.Add(lineTempObj);
                }


                //데이터꺼내기
                // 일단 한개만 꺼내보기 첫번째, 추후에는 채널 ID와 조인 수행해야함
                var wave = db.WaveData.Select(w => w).FirstOrDefault(); // 
                wave.ToFloatArray();

                Spectrum spectrum = new Spectrum();
                spectrum.GetFFT(wave);

                lineDrawWave.DrawLine(wave);
                lineDrawFFT.DrawLine(spectrum.fft);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tChartTrends.ShowEditor();
        }

        private void tChartTrends_Click(object sender, EventArgs e)
        {
        }
        private void trendChart_ClickSeries(object sender, Series s, int valueIndex, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var clickedTime = DateTime.FromOADate( s.XValues[valueIndex]);
                MessageBox.Show(
                    s.Title + 
                    ", " +
                    clickedTime +
                    ", " +
                    s.YValues[valueIndex].ToString());
            }
        }
        public void DrawWaveAndSpecturm()
        {

        }
    }
}
