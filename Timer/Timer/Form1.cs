using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PushbulletSharp;
using PushbulletSharp.Models.Requests;
using PushbulletSharp.Models.Responses;

namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime; // 終了時間
        int nowTime; // 経過時間

        public FormTimer()
        {
            InitializeComponent();
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }
            //残り時間を計算するため経過時間の変数を0で初期化
            nowTime = 0;
            // タイマースタート
            timerControl.Start();
            int Remtime = int.Parse(textRemainingTime.Text);
            if (Remtime==0)
            {
             
            }
            
        }

        private void timerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime; // 残り時間の変数を整数型で定義
            // 経過時間に1秒を加える
            nowTime++;
            // 残り時間を計算して表示
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();
            // <判定>設定時間になった？
            if (endTime == nowTime)
            {
                timerControl.Stop();
            }
            // 終了時間になったことを知らせる
            int Remtime = int.Parse(textRemainingTime.Text);
            if (Remtime == 0)
            {
                PushbulletClient client = new PushbulletClient("--apicode--");

                //If you don't know your device_iden, you can always query your devices
                var devices = client.CurrentUsersDevices();
                var device = devices.Devices.Where(o => o.manufacturer == "Sony").FirstOrDefault();
                var nick = devices.Devices.Where(o => o.nickname == "Xperia z1f").FirstOrDefault();
                var mails = client.CurrentUsersContacts();
                var mail = mails.contacts.Where(o => o.name == "Johnny Walker").FirstOrDefault();
                if (device != null)
                {
                    PushNoteRequest reqeust = new PushNoteRequest()
                    {
                        device_iden = nick.iden,
                        /*email = mail.email_normalized,*/
                        title = "hello world",
                        body = "本番まで10秒前"
                    };

                    PushResponse response = client.PushNote(reqeust);
                }
                MessageBox.Show("時間になりました！");
            }

      //for文用  }
            else
            {
                // 「No」の場合の処理
            }
        }
        private string var(UserContacts email)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }
            //残り時間を計算するため経過時間の変数を0で初期化
            nowTime = 0;
            // タイマースタート
            timerControl.Start();
           
            

         }
        

        private void button3_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }
            //残り時間を計算するため経過時間の変数を0で初期化
            nowTime = 0;
            // タイマースタート
            timerControl.Start();
            int Remtime = int.Parse(textRemainingTime.Text);
            if (Remtime == 10)
            {
                PushbulletClient client = new PushbulletClient("--apicode--");

                //If you don't know your device_iden, you can always query your devices
                var devices = client.CurrentUsersDevices();
                var device = devices.Devices.Where(o => o.manufacturer == "Sony").FirstOrDefault();
                var nick = devices.Devices.Where(o => o.nickname == "Xperia z1f").FirstOrDefault();
                var mails = client.CurrentUsersContacts();
                var mail = mails.contacts.Where(o => o.name == "Johnny Walker").FirstOrDefault();
                if (device != null)
                {
                    PushNoteRequest reqeust = new PushNoteRequest()
                    {
                        device_iden = device.iden,
                        /*email = mail.email_normalized,*/
                        title = "hello world",
                        body = "本番まで10秒前"
                    };

                    PushResponse response = client.PushNote(reqeust);
                }
                
            }
        }
    }
}
