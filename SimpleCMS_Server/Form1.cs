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
                channel = db.Channel.Select(row => row).FirstOrDefault();
            }

            channelMic = new WaveReader(channel);
            channelMic.StartRecording();
            channelMic.OnReceivedWaveData += micControll_OnReceivedWaveData;
        }

        private void micControll_OnReceivedWaveData(WaveData wave)
        {
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
