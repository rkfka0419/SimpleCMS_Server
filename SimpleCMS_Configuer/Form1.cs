using System;
using System.Windows.Forms;
using SimpleCmsDbClassDLL;
using System.Linq;

namespace SimpleCMS_Configuer
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";

        public Form1()
        {
            InitializeComponent();

            //TO DO :DB에 기본 설정 잡는중, 설정 프로그램 분리 시 옮겨야함


            var db = new SimpleCmsDBClassDataContext(connectionString);
            if (!db.DatabaseExists())
                db.CreateDatabase();
            Console.WriteLine("database created.");

            Channel channelMic = new Channel();
            channelMic.name = "Mic1";
            channelMic.sample_rate = (int)(Math.Pow(2, 13));
            db.Channel.InsertOnSubmit(channelMic);
            db.SubmitChanges();

            Channel channel2 = new Channel()
            {
                name = "Bluetooth",
                sample_rate = (int)(Math.Pow(2, 13))
            };
            db.Channel.InsertOnSubmit(channel2);
            db.SubmitChanges();

            RmsConfig rmsConfig1 = new RmsConfig();
            rmsConfig1.name = "RMS1";
            rmsConfig1.start = 100;
            rmsConfig1.end = 1000;
            db.TrendConfig.InsertOnSubmit(rmsConfig1);
            db.SubmitChanges();

            RmsConfig rmsConfig2 = new RmsConfig()
            {
                name = "RMS2",
                start = 1000,
                end = 2000
            };
            db.TrendConfig.InsertOnSubmit(rmsConfig2);
            db.SubmitChanges();

            RmsConfig rmsConfig3 = new RmsConfig()
            {
                name = "RMS3",
                start = 2000,
                end = 4000
            };
            db.TrendConfig.InsertOnSubmit(rmsConfig3);
            db.SubmitChanges();

            PeakConfig peakConfig = new PeakConfig();
            peakConfig.name = "Peak1";
            peakConfig.option = "upper";
            db.TrendConfig.InsertOnSubmit(peakConfig);
            db.SubmitChanges();

            db.Dispose();
        }
    }
}
