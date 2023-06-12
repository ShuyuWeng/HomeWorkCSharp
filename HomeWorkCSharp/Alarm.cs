using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HomeWorkCSharp
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            timeNow.Start();
        }

        int alarm時;
        int alarm分;
        int alarm秒;
        private void timeNow_Tick(object sender, EventArgs e)
        {
            labTimeNow.Text = DateTime.Now.ToString("現在時間： " + "HH:mm:ss");
            if (DateTime.Now.Hour == alarm時 && DateTime.Now.Minute == alarm分 && DateTime.Now.Second == alarm秒)
            {
                MessageBox.Show("鬧鐘時間到了!");
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = @"C:\Shared\Shared\student\CSharp\HomeWorkCSharp\HomeWorkCSharp\10021.wav";                
                sound.Play();
            }
        }

        private void btnAlarmSet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt時.Text,out int hour) && int.TryParse(txt分.Text,out int min) && int.TryParse(txt秒.Text,out int s))
            {
                if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59 && s >= 0 && s<= 59)
                {
                    alarm時 = hour;
                    alarm分 = min;
                    alarm秒 = s;
                    MessageBox.Show($"鬧鐘設定時間為 {alarm時:##} : {alarm分:##}  : {alarm秒:##}。");
                }
                else
                { MessageBox.Show("整點時間應設於0到23之間，分鐘時間應設於0到59之間"); }
            }
            else
            { MessageBox.Show("請輸入正確的整點和分鐘時間"); }
        }

        
    }
}
