using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SimpleCmsDbClassDLL;

namespace SimpleCMS_Server
{
    public partial class Form1 : Form
    {

        // TO DO : 추후 실시간 모니터링시, TeeChart 설치하고 Line Draw
        //LineDrawer lineDrawWave;
        //LineDrawer lineDrawFFT;

        const string connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";

        WaveReader channelMic;

        public Form1()
        {
            InitializeComponent();
            
            Channel channel = new Channel();
            using (var db = new SimpleCmsDBClassDataContext(connectionString))
            {
                if (!db.DatabaseExists())
                {
                    MessageBox.Show("Database does not exist, check configuration.");
                    return;
                }
                Console.WriteLine("DB status normal");

                //일단 한개만 테스트 중
                channel = db.Channel.Select(row => row).FirstOrDefault();
            }

            channelMic = new WaveReader(channel);
            //channelMic.StartRecording();
            channelMic.OnReceivedWaveData += micControll_OnReceivedWaveData;
        }

        private void micControll_OnReceivedWaveData(WaveData wave)
        {
            // wave가 가공되어 넘어올 때마다 DB 연결을 맺고 끊고를 반복?? 효율적인지??
            // 레코딩 중에는 계속 insert 하기 때문에 연결을 가지고 있으면 어떨까

            using (var db = new SimpleCmsDBClassDataContext(connectionString))
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
            var db = new SimpleCmsDBClassDataContext(connectionString);
            db.DeleteDatabase();
        }
    }
}
