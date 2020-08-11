namespace TrojanFormsApp
{
    partial class LocalPortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPortForm));
            this.LocalPort_Label = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Local_Port_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Local_Port_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalPort_Label
            // 
            this.LocalPort_Label.AutoSize = true;
            this.LocalPort_Label.Location = new System.Drawing.Point(56, 58);
            this.LocalPort_Label.Name = "LocalPort_Label";
            this.LocalPort_Label.Size = new System.Drawing.Size(56, 17);
            this.LocalPort_Label.TabIndex = 0;
            this.LocalPort_Label.Text = "本地端口";
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(241, 54);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 25);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "确定";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Local_Port_numericUpDown
            // 
            this.Local_Port_numericUpDown.Location = new System.Drawing.Point(121, 55);
            this.Local_Port_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Local_Port_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Local_Port_numericUpDown.Name = "Local_Port_numericUpDown";
            this.Local_Port_numericUpDown.Size = new System.Drawing.Size(101, 23);
            this.Local_Port_numericUpDown.TabIndex = 4;
            // 
            // LocalPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 132);
            this.Controls.Add(this.Local_Port_numericUpDown);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.LocalPort_Label);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalPortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "本地 Socks5 端口设置";
            ((System.ComponentModel.ISupportInitialize)(this.Local_Port_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocalPort_Label;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.NumericUpDown Local_Port_numericUpDown;
    }
}