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
        LineDrawer lineDrawWave;
        LineDrawer lineDrawFFT;
        List<LineDrawer> trendList;
        const string connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";


        public Form1()
        {
            InitializeComponent();

            trendList = new List<LineDrawer>();
            lineDrawWave = new LineDrawer(tChartWave, new Line());
            lineDrawFFT = new LineDrawer(tChartFFT, new Line());
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

                tableLayoutPanel1.Controls.Add(tChartTrends, 0, 0);
                tableLayoutPanel1.Controls.Add(tChartWave, 0, 1);
                tableLayoutPanel1.Controls.Add(tChartFFT, 0, 2);



                // 채널 갯수에 따라 TabControl 확장 예정
                //var channels = db.Channel.Select(channel => channel).ToList();
                var channels = db.Channel.Select(channel => channel).FirstOrDefault();
                //tabPage1.Text = channels.name;
                tabControl.TabPages[0].Text = channels.name;

                foreach (var item in DBController.GetTrendConfigList())
                {
                    trendCheckedListBox.Items.Add(item.name);
                }


                //TrendConfig ID와 TrendData의 config_ID를 조인 -> name을 가져온다.
                //TrendConfig 갯수만큼 LineDraw 인스턴스 생성
                // 해당 wave 시간의 trend를 화면에 그린다.


                //데이터꺼내기
                // 일단 한개만 꺼내보기 첫번째, 추후에는 채널 ID와 조인 수행해야함
                //var wave = db.WaveData.Select(w => w).FirstOrDefault(); // 
                //wave.ToFloatArray();

                //Spectrum spectrum = new Spectrum();
                //spectrum.GetFFT(wave);

                //lineDrawWave.DrawLine(wave);
                //lineDrawFFT.DrawLine(spectrum.fft);
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
                var clickedTime = DateTime.FromOADate(s.XValues[valueIndex]);
                DrawWaveAndSpecturm(clickedTime);
            }
        }

        public void DrawWaveAndSpecturm(DateTime trendTime)
        {
            WaveData wave = DBController.GetWaveFromTrendTime(trendTime);
            try
            {
                wave.ToFloatArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            Spectrum spectrum = new Spectrum();
            spectrum.GetFFT(wave);

            lineDrawWave.DrawLine(wave, true);
            lineDrawFFT.DrawLine(spectrum.fft, true);
        }
        

        private void chartStartTime_MouseWheel(object sender, MouseEventArgs e)
        {
            if ( e.Delta > 0 )
            {
                SendKeys.Send("{UP}");
            }
            else
            {
                SendKeys.Send("{DOWN}");
            }
        }
        private void chartEndTime_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendKeys.Send("{UP}");
            }
            else
            {
                SendKeys.Send("{DOWN}");
            }
        }

        private void btnGetRange_Click(object sender, EventArgs e)
        {
            
            var checkedTrends = trendCheckedListBox.CheckedItems;

            tChartTrends.Series.Clear();
            foreach (var item in checkedTrends)
            {
                Console.WriteLine(item.ToString());
                var trend = DBController.GetSingleTrendFromTimeRange(item.ToString(), chartStartTime.Value, chartEndTime.Value);
                Line line = new Line();
                line.Title = item.ToString();
                line.Legend.Visible = false;
                tChartTrends.Series.Add(line);
                line.Add(trend.Select(w => w.Time).ToArray(), trend.Select(w=>w.Value).ToArray());
            }

        }
    }
}
