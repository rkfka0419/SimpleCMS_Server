using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCMS_Server
{
    public partial class Form1 : Form
    {

        // TO DO : 추후 실시간 모니터링시, TeeChart 설치하고 Line Draw
        //LineDrawer lineDrawWave;
        //LineDrawer lineDrawFFT;

        const string CONFIG_FILE_PATH = @"config.json";
        const string connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";

        Channel channelMic;

        public Form1()
        {
            InitializeComponent();

            // TO DO :DB에 기본 설정 잡는중, 설정 프로그램 분리 시 옮겨야함
            //using (var db = new SimpleCmsDbClassDataContext(connectionString))
            //{
            //    if (!db.DatabaseExists())
            //    {
            //    } // TO DO : 설정 프로그램 생성하고 초기설정 이동하기
            //}
            var db = new SimpleCmsDbClassDataContext(connectionString);
            if(!db.DatabaseExists())
                db.CreateDatabase();
            Console.WriteLine("database created.");

            channelMic = new Channel();
            channelMic.name = "Mic1";
            channelMic.sample_rate = (int)(Math.Pow(2, 13));
            db.Channel.InsertOnSubmit(channelMic);
            db.SubmitChanges();

            RmsConfig rmsConfig1 = new RmsConfig();
            rmsConfig1.name = "RMS1";
            rmsConfig1.start = 100;
            rmsConfig1.end = 1000;
            db.TrendConfig.InsertOnSubmit(rmsConfig1);
            db.SubmitChanges();

            RmsConfig rmsConfig2 = new RmsConfig();
            rmsConfig2.name = "RMS2";
            rmsConfig2.start = 1000;
            rmsConfig2.end = 4000;
            db.TrendConfig.InsertOnSubmit(rmsConfig2);
            db.SubmitChanges();

            PeakConfig peakConfig = new PeakConfig();
            peakConfig.name = "Peak1";
            peakConfig.option = "upper";
            db.TrendConfig.InsertOnSubmit(peakConfig);
            db.SubmitChanges();

            channelMic.StartRecording();
            channelMic.OnReceivedWaveData += micControll_OnReceivedWaveData;
            
            db.Dispose();
        }

        private void micControll_OnReceivedWaveData(WaveData wave)
        {
            using (var db = new SimpleCmsDbClassDataContext(connectionString))
            {
                db.WaveData.InsertOnSubmit(wave);
                db.SubmitChanges();
                //Calculate Spectrum data from wave
                Spectrum spectrum = new Spectrum();
                spectrum.GetFFT(wave);

                var trends = db.TrendConfig.Select(trend => trend.CalTrend(wave, spectrum));
                db.TrendData.InsertAllOnSubmit(trends);
                db.SubmitChanges();
            }
        }

        private void Btn_Record_Click(object sender, EventArgs e)
        {
            channelMic.StartRecording();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            channelMic.StopRecording();
        }

        private void Btn_DeleteDB_Click(object sender, EventArgs e)
        {
            var db = new SimpleCmsDbClassDataContext(connectionString);
            db.DeleteDatabase();
        }
    }
}
