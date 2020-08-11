using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.IO;

namespace TrojanFormsApp
{


    public partial class MainForm : Form
    {

        public TrojanCore tj = new TrojanCore();       // 实例化启动新进程的方法
        public static bool isRunning = false;          // 设置运行状态Flag全局变量
        public static string local_port;               // 设置全局变量local_port

        public MainForm()
        {
            //互斥体判断
            bool isNotRunning;
            System.Threading.Mutex instance = new System.Threading.Mutex(true, "MutexName", out isNotRunning); //同步基元变量
            if (!isNotRunning)                      // 如果不是未运行状态
            {
                MessageBox.Show("程序已在运行");
                Environment.Exit(1);
            }
            if (!File.Exists(@"trojan.exe"))        // 如果trojan.exe不存在
            {
                MessageBox.Show("Core 文件不存在");
                Environment.Exit(1);
            }
            if (!File.Exists(@"config.json"))       // 如果config.json不存在
            {
                //MessageBox.Show("不存在配置文件，正在新建。");
                File.WriteAllBytes(@"config.json", Properties.Resources.DefaultConfig);
            }
            InitializeComponent();                  // 初始化窗口界面
            ReadJson();
        }


        //////// BEGIN 手写方法 ///////

        public int ReadJson()
        {
            //ReadJson
            string FilePath = "config.json";
            string josnString = File.ReadAllText(FilePath, Encoding.UTF8);
            Console.WriteLine(josnString);
            JObject ConfigJson = JObject.Parse(josnString);

            //读取JObject的值到变量
            string remote_addr = ConfigJson["remote_addr"].ToString();
            string remote_port = ConfigJson["remote_port"].ToString();
            string password = ConfigJson["password"][0].ToString();
            //string local_port = ConfigJson["local_port"].ToString();
            local_port = ConfigJson["local_port"].ToString();

            //将变量的值赋给文本框
            ServerDomain_TextBox.Text = remote_addr;
            ServerProt_TextBox.Text = remote_port;
            ServerPassword_TextBox.Text = password;
            //将变量的值赋给文本框
            LocalPort_TextBox.Text = local_port;
            return 0;
        }

        public int WriteJson()
        {
            //WriteJson
            string FilePath = "config.json";
            string josnString = File.ReadAllText(FilePath, Encoding.UTF8);
            JObject ConfigJson = JObject.Parse(josnString);

            //文本框内容保存到变量
            string remote_addr = ServerDomain_TextBox.Text;
            string remote_port = ServerProt_TextBox.Text;
            string password = ServerPassword_TextBox.Text;

            //修改JObject的值
            ConfigJson["remote_addr"] = remote_addr;
            ConfigJson["remote_port"] = remote_port;
            ConfigJson["password"][0] = password;

            //将JObject写入到本地文件
            File.WriteAllText("config.json", ConfigJson.ToString());

            return 0;
        }


        public int EngineStartup()
        {
            WriteJson();
            //文本框设为只读
            ServerDomain_TextBox.ReadOnly = true;
            ServerProt_TextBox.ReadOnly = true;
            ServerPassword_TextBox.ReadOnly = true;
            LocalPort_TextBox.ReadOnly = true;
            Switch_Button.Text = "█ 停止";
            RunningStatus_Label.Text = "当前状态：运行中";
            isRunning = true;
            tj.Start();         //启动TrojanCore

            return 0;
        }

        public int EngineShutdown()
        {

            // 如果Flag标记为运行则尝试终止
            if (isRunning == true)
            {
                try
                {
                    tj.Stop();
                }
                finally
                {

                }
            }

            //文本框设为可编辑
            ServerDomain_TextBox.ReadOnly = false;
            ServerProt_TextBox.ReadOnly = false;
            ServerPassword_TextBox.ReadOnly = false;
            LocalPort_TextBox.ReadOnly = false;
            Switch_Button.Text = "▶ 运行";
            RunningStatus_Label.Text = "当前状态：未运行";
            isRunning = false;

            return 0;
        }


        public int Restart()
        {
            EngineShutdown();
            EngineStartup();
            return 0;
        }

        public void Exit()
        {
            //如果后台服务器运行中则先停止服务再退出
            if (isRunning == true)
            {
                try
                {
                    tj.Stop();
                }
                finally
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        public void ResetConfig()
        {
            File.WriteAllBytes(@"config.json", Properties.Resources.DefaultConfig);

        }

        //////// END 手写方法 ///////

        private void Switch_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HELLO");
            //notifyIcon1.Visible = true;

            if (isRunning == true)
            {
                EngineShutdown();
            }
            else
            {
                EngineStartup();
            }

        }

        private void ChangeLocalPort_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalPortForm dlg = new LocalPortForm();
            dlg.ShowDialog(this);
            dlg.Dispose();
        }

        private void StratChome_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process chrome = new System.Diagnostics.Process();
            chrome.StartInfo.FileName = "chrome.exe";
            chrome.StartInfo.Arguments = $"--proxy-server=socks5://127.0.0.1:{local_port}";  //代理启动参数
            chrome.Start();
        }

        private void StratEdge_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process edge = new System.Diagnostics.Process();
            edge.StartInfo.FileName = "msedge.exe";
            edge.StartInfo.Arguments = $"--proxy-server=socks5://127.0.0.1:{local_port}";  //代理启动参数    
            edge.Start();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm dlg = new AboutForm();
            dlg.ShowDialog(this);
            dlg.Dispose();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 如果用户点击窗口关闭按钮则隐藏窗口
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void Exit_NotifyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ShowMainForm_NotifyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void Start_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineStartup();
        }

        private void ServerPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ServerPassword_CheckBox.Checked;
            if (isChecked)
            {
                ServerPassword_TextBox.PasswordChar = '\0';
            }
            else
            {
                ServerPassword_TextBox.PasswordChar = '●';
            }
        }

        private void Restart_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EngineShutdown();
            //EngineStartup();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Stop_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineShutdown();
        }

        private void ServerLatencyTest_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PingArguments = $"-t {ServerDomain_TextBox.Text}";
            System.Diagnostics.Process ping = new System.Diagnostics.Process();
            ping.StartInfo.FileName = "ping.exe";
            ping.StartInfo.Arguments = PingArguments;  //命令行启动参数       
            ping.Start();
        }

        private void ResetConfigFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您是否需要重置 config.json 配置文件？", "再次确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                File.WriteAllBytes(@"config.json", Properties.Resources.DefaultConfig);
                ReadJson();
            }
        }

    }

    // 内部类
    public class TrojanCore
    {
        System.Diagnostics.Process trojan = new System.Diagnostics.Process();

        public int Start()
        {
            if (System.Diagnostics.Process.GetProcessesByName("trojan").ToList().Count > 0)
            {
                MessageBox.Show("Trojan 网络代理已在运行");
            }
            else
            {
                //MessageBox.Show("正在启动 Trojan 网络代理");
                //System.Diagnostics.Process trojan = new System.Diagnostics.Process();
                trojan.StartInfo.FileName = "trojan.exe";
                trojan.StartInfo.UseShellExecute = false;
                trojan.StartInfo.CreateNoWindow = true;     //隐式运行CMD命令行窗口
                trojan.Start();                             //启动新进程
                int pid = trojan.Id;                        //获取新启动进程的PID
                //MessageBox.Show(Convert.ToString(pid));     //显示PID
            }
            return 0;
        }

        public int Stop()
        {
            trojan.Kill();
            return 0;
        }
    }

}
