using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrojanFormsApp
{
    public partial class LocalPortForm : Form
    {
        public LocalPortForm()
        {
            //ReadJson
            string FilePath = "config.json";
            string josnString = File.ReadAllText(FilePath, Encoding.UTF8);
            Console.WriteLine(josnString);
            JObject ConfigJson = JObject.Parse(josnString);

            //读取JObject的值到变量
            //string local_port = ConfigJson["local_port"].ToString();
            int local_port = int.Parse(ConfigJson["local_port"].ToString());

            InitializeComponent();


            //将变量的值赋给文本框
            Local_Port_numericUpDown.Value = local_port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(Local_Port_numericUpDown.Text);
            if (port <= 0 || port > 65535)
                MessageBox.Show("Port out of range，端口超出范围，您的设置未被保存，请重新输入。");
            //else
                //WriteJson
                //string FilePath = "config.json";
                //string josnString = File.ReadAllText(FilePath, Encoding.UTF8);
                //JObject ConfigJson = JObject.Parse(josnString);

                //文本框内容保存到变量
                //string local_port = Local_Port_numericUpDown.Text;

                //修改JObject的值
                //ConfigJson["local_port"] = local_port;


                //将JObject写入到本地文件
                //File.WriteAllText("config.json", ConfigJson.ToString());

        }


    }
}
