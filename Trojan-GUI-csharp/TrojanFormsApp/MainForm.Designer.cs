namespace TrojanFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Switch_Button = new System.Windows.Forms.Button();
            this.ServerConfig_GroupBox = new System.Windows.Forms.GroupBox();
            this.Prot_Label = new System.Windows.Forms.Label();
            this.ServerProt_TextBox = new System.Windows.Forms.TextBox();
            this.ServerPassword_TextBox = new System.Windows.Forms.TextBox();
            this.ServerDomain_TextBox = new System.Windows.Forms.TextBox();
            this.ServerPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.ServerDomian_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StratChome_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StratEdge_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网络ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NetworkConnectivityDiagnosis_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerLatencyTest_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetConfigFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMainForm_NotifyIconStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_NotifyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalPort_TextBox = new System.Windows.Forms.TextBox();
            this.LocalPort_Label = new System.Windows.Forms.Label();
            this.RunningStatus_Label = new System.Windows.Forms.Label();
            this.ServerConfig_GroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Switch_Button
            // 
            this.Switch_Button.Location = new System.Drawing.Point(312, 234);
            this.Switch_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Switch_Button.Name = "Switch_Button";
            this.Switch_Button.Size = new System.Drawing.Size(88, 32);
            this.Switch_Button.TabIndex = 0;
            this.Switch_Button.Text = "▶ 运行";
            this.Switch_Button.UseVisualStyleBackColor = true;
            this.Switch_Button.Click += new System.EventHandler(this.Switch_Button_Click);
            // 
            // ServerConfig_GroupBox
            // 
            this.ServerConfig_GroupBox.Controls.Add(this.Prot_Label);
            this.ServerConfig_GroupBox.Controls.Add(this.ServerProt_TextBox);
            this.ServerConfig_GroupBox.Controls.Add(this.ServerPassword_TextBox);
            this.ServerConfig_GroupBox.Controls.Add(this.ServerDomain_TextBox);
            this.ServerConfig_GroupBox.Controls.Add(this.ServerPassword_CheckBox);
            this.ServerConfig_GroupBox.Controls.Add(this.ServerDomian_Label);
            this.ServerConfig_GroupBox.Location = new System.Drawing.Point(36, 47);
            this.ServerConfig_GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerConfig_GroupBox.Name = "ServerConfig_GroupBox";
            this.ServerConfig_GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ServerConfig_GroupBox.Size = new System.Drawing.Size(363, 155);
            this.ServerConfig_GroupBox.TabIndex = 1;
            this.ServerConfig_GroupBox.TabStop = false;
            this.ServerConfig_GroupBox.Text = "服务器";
            // 
            // Prot_Label
            // 
            this.Prot_Label.AutoSize = true;
            this.Prot_Label.Location = new System.Drawing.Point(254, 48);
            this.Prot_Label.Name = "Prot_Label";
            this.Prot_Label.Size = new System.Drawing.Size(11, 17);
            this.Prot_Label.TabIndex = 8;
            this.Prot_Label.Text = ":";
            // 
            // ServerProt_TextBox
            // 
            this.ServerProt_TextBox.Location = new System.Drawing.Point(267, 45);
            this.ServerProt_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerProt_TextBox.Name = "ServerProt_TextBox";
            this.ServerProt_TextBox.Size = new System.Drawing.Size(46, 23);
            this.ServerProt_TextBox.TabIndex = 6;
            this.ServerProt_TextBox.Text = "443";
            // 
            // ServerPassword_TextBox
            // 
            this.ServerPassword_TextBox.Location = new System.Drawing.Point(108, 90);
            this.ServerPassword_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerPassword_TextBox.Name = "ServerPassword_TextBox";
            this.ServerPassword_TextBox.PasswordChar = '●';
            this.ServerPassword_TextBox.Size = new System.Drawing.Size(205, 23);
            this.ServerPassword_TextBox.TabIndex = 5;
            // 
            // ServerDomain_TextBox
            // 
            this.ServerDomain_TextBox.Location = new System.Drawing.Point(108, 45);
            this.ServerDomain_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerDomain_TextBox.Name = "ServerDomain_TextBox";
            this.ServerDomain_TextBox.Size = new System.Drawing.Size(144, 23);
            this.ServerDomain_TextBox.TabIndex = 4;
            this.ServerDomain_TextBox.Text = "example.com";
            // 
            // ServerPassword_CheckBox
            // 
            this.ServerPassword_CheckBox.AutoSize = true;
            this.ServerPassword_CheckBox.Location = new System.Drawing.Point(49, 92);
            this.ServerPassword_CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerPassword_CheckBox.Name = "ServerPassword_CheckBox";
            this.ServerPassword_CheckBox.Size = new System.Drawing.Size(51, 21);
            this.ServerPassword_CheckBox.TabIndex = 1;
            this.ServerPassword_CheckBox.Text = "密码";
            this.ServerPassword_CheckBox.UseVisualStyleBackColor = true;
            this.ServerPassword_CheckBox.CheckedChanged += new System.EventHandler(this.ServerPassword_CheckBox_CheckedChanged);
            // 
            // ServerDomian_Label
            // 
            this.ServerDomian_Label.AutoSize = true;
            this.ServerDomian_Label.Location = new System.Drawing.Point(32, 48);
            this.ServerDomian_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerDomian_Label.Name = "ServerDomian_Label";
            this.ServerDomian_Label.Size = new System.Drawing.Size(68, 17);
            this.ServerDomian_Label.TabIndex = 0;
            this.ServerDomian_Label.Text = "服务器域名";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.启动ToolStripMenuItem,
            this.网络ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start_ToolStripMenuItem,
            this.Stop_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.Exit_ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "状态";
            // 
            // Start_ToolStripMenuItem
            // 
            this.Start_ToolStripMenuItem.Name = "Start_ToolStripMenuItem";
            this.Start_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Start_ToolStripMenuItem.Text = "运行";
            this.Start_ToolStripMenuItem.Click += new System.EventHandler(this.Start_ToolStripMenuItem_Click);
            // 
            // Stop_ToolStripMenuItem
            // 
            this.Stop_ToolStripMenuItem.Name = "Stop_ToolStripMenuItem";
            this.Stop_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Stop_ToolStripMenuItem.Text = "停止";
            this.Stop_ToolStripMenuItem.Click += new System.EventHandler(this.Stop_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Exit_ToolStripMenuItem.Text = "退出";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StratChome_ToolStripMenuItem,
            this.StratEdge_ToolStripMenuItem});
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.启动ToolStripMenuItem.Text = "启动";
            // 
            // StratChome_ToolStripMenuItem
            // 
            this.StratChome_ToolStripMenuItem.Name = "StratChome_ToolStripMenuItem";
            this.StratChome_ToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.StratChome_ToolStripMenuItem.Text = "代理启动 [Chorme]";
            this.StratChome_ToolStripMenuItem.Click += new System.EventHandler(this.StratChome_ToolStripMenuItem_Click);
            // 
            // StratEdge_ToolStripMenuItem
            // 
            this.StratEdge_ToolStripMenuItem.Name = "StratEdge_ToolStripMenuItem";
            this.StratEdge_ToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.StratEdge_ToolStripMenuItem.Text = "代理启动 [Edge Chromium]";
            this.StratEdge_ToolStripMenuItem.Click += new System.EventHandler(this.StratEdge_ToolStripMenuItem_Click);
            // 
            // 网络ToolStripMenuItem
            // 
            this.网络ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NetworkConnectivityDiagnosis_ToolStripMenuItem,
            this.ServerLatencyTest_ToolStripMenuItem});
            this.网络ToolStripMenuItem.Name = "网络ToolStripMenuItem";
            this.网络ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.网络ToolStripMenuItem.Text = "网络";
            // 
            // NetworkConnectivityDiagnosis_ToolStripMenuItem
            // 
            this.NetworkConnectivityDiagnosis_ToolStripMenuItem.Name = "NetworkConnectivityDiagnosis_ToolStripMenuItem";
            this.NetworkConnectivityDiagnosis_ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.NetworkConnectivityDiagnosis_ToolStripMenuItem.Text = "测试谷歌连通性";
            // 
            // ServerLatencyTest_ToolStripMenuItem
            // 
            this.ServerLatencyTest_ToolStripMenuItem.Name = "ServerLatencyTest_ToolStripMenuItem";
            this.ServerLatencyTest_ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ServerLatencyTest_ToolStripMenuItem.Text = "测试代理服务器延迟";
            this.ServerLatencyTest_ToolStripMenuItem.Click += new System.EventHandler(this.ServerLatencyTest_ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetConfigFile_ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // ResetConfigFile_ToolStripMenuItem
            // 
            this.ResetConfigFile_ToolStripMenuItem.Name = "ResetConfigFile_ToolStripMenuItem";
            this.ResetConfigFile_ToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ResetConfigFile_ToolStripMenuItem.Text = "重置 config.json 配置文件";
            this.ResetConfigFile_ToolStripMenuItem.Click += new System.EventHandler(this.ResetConfigFile_ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.About_ToolStripMenuItem.Text = "关于";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Trojan-GUI-csharp";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.ShowMainForm_NotifyIconToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMainForm_NotifyIconStripMenuItem,
            this.Exit_NotifyIconToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // ShowMainForm_NotifyIconStripMenuItem
            // 
            this.ShowMainForm_NotifyIconStripMenuItem.Name = "ShowMainForm_NotifyIconStripMenuItem";
            this.ShowMainForm_NotifyIconStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ShowMainForm_NotifyIconStripMenuItem.Text = "显示主窗口";
            this.ShowMainForm_NotifyIconStripMenuItem.Click += new System.EventHandler(this.ShowMainForm_NotifyIconToolStripMenuItem_Click);
            // 
            // Exit_NotifyIconToolStripMenuItem
            // 
            this.Exit_NotifyIconToolStripMenuItem.Name = "Exit_NotifyIconToolStripMenuItem";
            this.Exit_NotifyIconToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.Exit_NotifyIconToolStripMenuItem.Text = "退出";
            this.Exit_NotifyIconToolStripMenuItem.Click += new System.EventHandler(this.Exit_NotifyIconToolStripMenuItem_Click);
            // 
            // LocalPort_TextBox
            // 
            this.LocalPort_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LocalPort_TextBox.Location = new System.Drawing.Point(95, 239);
            this.LocalPort_TextBox.Name = "LocalPort_TextBox";
            this.LocalPort_TextBox.Size = new System.Drawing.Size(62, 23);
            this.LocalPort_TextBox.TabIndex = 6;
            // 
            // LocalPort_Label
            // 
            this.LocalPort_Label.AutoSize = true;
            this.LocalPort_Label.Location = new System.Drawing.Point(33, 242);
            this.LocalPort_Label.Name = "LocalPort_Label";
            this.LocalPort_Label.Size = new System.Drawing.Size(56, 17);
            this.LocalPort_Label.TabIndex = 7;
            this.LocalPort_Label.Text = "本地端口";
            // 
            // RunningStatus_Label
            // 
            this.RunningStatus_Label.AutoSize = true;
            this.RunningStatus_Label.Location = new System.Drawing.Point(184, 242);
            this.RunningStatus_Label.Name = "RunningStatus_Label";
            this.RunningStatus_Label.Size = new System.Drawing.Size(104, 17);
            this.RunningStatus_Label.TabIndex = 2;
            this.RunningStatus_Label.Text = "当前状态：未运行";
            this.RunningStatus_Label.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 304);
            this.Controls.Add(this.LocalPort_Label);
            this.Controls.Add(this.LocalPort_TextBox);
            this.Controls.Add(this.RunningStatus_Label);
            this.Controls.Add(this.ServerConfig_GroupBox);
            this.Controls.Add(this.Switch_Button);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrojanCS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ServerConfig_GroupBox.ResumeLayout(false);
            this.ServerConfig_GroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Switch_Button;
        private System.Windows.Forms.GroupBox ServerConfig_GroupBox;
        private System.Windows.Forms.TextBox ServerProt_TextBox;
        private System.Windows.Forms.TextBox ServerPassword_TextBox;
        private System.Windows.Forms.TextBox ServerDomain_TextBox;
        private System.Windows.Forms.CheckBox ServerPassword_CheckBox;
        private System.Windows.Forms.Label ServerDomian_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Start_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Stop_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 网络ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NetworkConnectivityDiagnosis_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.Label Prot_Label;
        private System.Windows.Forms.ToolStripMenuItem ResetConfigFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServerLatencyTest_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StratChome_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StratEdge_ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowMainForm_NotifyIconStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_NotifyIconToolStripMenuItem;
        private System.Windows.Forms.TextBox LocalPort_TextBox;
        private System.Windows.Forms.Label LocalPort_Label;
        private System.Windows.Forms.Label RunningStatus_Label;
    }
}

