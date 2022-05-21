namespace LightController
{
    partial class FormController
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSetting3 = new System.Windows.Forms.Button();
            this.buttonSetting2 = new System.Windows.Forms.Button();
            this.buttonSetting1 = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.numericUpDown_ch2Data = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ch1Data = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_recivedData = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNetworkSetting = new System.Windows.Forms.TextBox();
            this.buttonShowIP = new System.Windows.Forms.Button();
            this.buttonSetIP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.buttonSendCmd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ch2Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ch1Data)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetting3);
            this.groupBox1.Controls.Add(this.buttonSetting2);
            this.groupBox1.Controls.Add(this.buttonSetting1);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.numericUpDown_ch2Data);
            this.groupBox1.Controls.Add(this.numericUpDown_ch1Data);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "亮度";
            // 
            // buttonSetting3
            // 
            this.buttonSetting3.Location = new System.Drawing.Point(25, 138);
            this.buttonSetting3.Name = "buttonSetting3";
            this.buttonSetting3.Size = new System.Drawing.Size(211, 23);
            this.buttonSetting3.TabIndex = 2;
            this.buttonSetting3.Text = "CH1: 0, CH2: 200";
            this.buttonSetting3.UseVisualStyleBackColor = true;
            this.buttonSetting3.Click += new System.EventHandler(this.buttonSetting3_Click);
            // 
            // buttonSetting2
            // 
            this.buttonSetting2.Location = new System.Drawing.Point(25, 109);
            this.buttonSetting2.Name = "buttonSetting2";
            this.buttonSetting2.Size = new System.Drawing.Size(211, 23);
            this.buttonSetting2.TabIndex = 2;
            this.buttonSetting2.Text = "CH1: 170, CH2: 0";
            this.buttonSetting2.UseVisualStyleBackColor = true;
            this.buttonSetting2.Click += new System.EventHandler(this.buttonSetting2_Click);
            // 
            // buttonSetting1
            // 
            this.buttonSetting1.Location = new System.Drawing.Point(25, 80);
            this.buttonSetting1.Name = "buttonSetting1";
            this.buttonSetting1.Size = new System.Drawing.Size(211, 23);
            this.buttonSetting1.TabIndex = 2;
            this.buttonSetting1.Text = "CH1: 50, CH2: 140";
            this.buttonSetting1.UseVisualStyleBackColor = true;
            this.buttonSetting1.Click += new System.EventHandler(this.buttonSetting1_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(25, 51);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(211, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // numericUpDown_ch2Data
            // 
            this.numericUpDown_ch2Data.Location = new System.Drawing.Point(170, 23);
            this.numericUpDown_ch2Data.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_ch2Data.Name = "numericUpDown_ch2Data";
            this.numericUpDown_ch2Data.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown_ch2Data.TabIndex = 1;
            // 
            // numericUpDown_ch1Data
            // 
            this.numericUpDown_ch1Data.Location = new System.Drawing.Point(56, 23);
            this.numericUpDown_ch1Data.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_ch1Data.Name = "numericUpDown_ch1Data";
            this.numericUpDown_ch1Data.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown_ch1Data.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "CH2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CH1";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 50);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(93, 51);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_recivedData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(555, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_recivedData
            // 
            this.toolStripStatusLabel_recivedData.AutoToolTip = true;
            this.toolStripStatusLabel_recivedData.Name = "toolStripStatusLabel_recivedData";
            this.toolStripStatusLabel_recivedData.Size = new System.Drawing.Size(540, 17);
            this.toolStripStatusLabel_recivedData.Spring = true;
            this.toolStripStatusLabel_recivedData.Text = "RecivedData";
            this.toolStripStatusLabel_recivedData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(27, 20);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(95, 22);
            this.textBoxIP.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxNetworkSetting);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Controls.Add(this.textBoxIP);
            this.groupBox2.Controls.Add(this.buttonDisconnect);
            this.groupBox2.Controls.Add(this.buttonShowIP);
            this.groupBox2.Controls.Add(this.buttonSetIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 267);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP/IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "修改IP後控制器電源需重開，新IP才會生效。";
            // 
            // textBoxNetworkSetting
            // 
            this.textBoxNetworkSetting.Location = new System.Drawing.Point(9, 137);
            this.textBoxNetworkSetting.Multiline = true;
            this.textBoxNetworkSetting.Name = "textBoxNetworkSetting";
            this.textBoxNetworkSetting.Size = new System.Drawing.Size(236, 105);
            this.textBoxNetworkSetting.TabIndex = 5;
            this.textBoxNetworkSetting.Text = "Network setting";
            // 
            // buttonShowIP
            // 
            this.buttonShowIP.Location = new System.Drawing.Point(93, 88);
            this.buttonShowIP.Name = "buttonShowIP";
            this.buttonShowIP.Size = new System.Drawing.Size(112, 23);
            this.buttonShowIP.TabIndex = 1;
            this.buttonShowIP.Text = "ShowNetworkSetting";
            this.buttonShowIP.UseVisualStyleBackColor = true;
            this.buttonShowIP.Click += new System.EventHandler(this.buttonShowIP_Click);
            // 
            // buttonSetIP
            // 
            this.buttonSetIP.Location = new System.Drawing.Point(12, 89);
            this.buttonSetIP.Name = "buttonSetIP";
            this.buttonSetIP.Size = new System.Drawing.Size(75, 23);
            this.buttonSetIP.TabIndex = 1;
            this.buttonSetIP.Text = "SetIP";
            this.buttonSetIP.UseVisualStyleBackColor = true;
            this.buttonSetIP.Click += new System.EventHandler(this.buttonSetIP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCmd);
            this.groupBox3.Controls.Add(this.buttonSendCmd);
            this.groupBox3.Location = new System.Drawing.Point(14, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command";
            // 
            // textBoxCmd
            // 
            this.textBoxCmd.Location = new System.Drawing.Point(17, 26);
            this.textBoxCmd.Name = "textBoxCmd";
            this.textBoxCmd.Size = new System.Drawing.Size(216, 22);
            this.textBoxCmd.TabIndex = 0;
            // 
            // buttonSendCmd
            // 
            this.buttonSendCmd.Location = new System.Drawing.Point(80, 54);
            this.buttonSendCmd.Name = "buttonSendCmd";
            this.buttonSendCmd.Size = new System.Drawing.Size(89, 23);
            this.buttonSendCmd.TabIndex = 2;
            this.buttonSendCmd.Text = "Send";
            this.buttonSendCmd.UseVisualStyleBackColor = true;
            this.buttonSendCmd.Click += new System.EventHandler(this.buttonSendCmd_Click);
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 306);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormController";
            this.Text = "LightController_IDGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ch2Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ch1Data)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSetting3;
        private System.Windows.Forms.Button buttonSetting2;
        private System.Windows.Forms.Button buttonSetting1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.NumericUpDown numericUpDown_ch2Data;
        private System.Windows.Forms.NumericUpDown numericUpDown_ch1Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_recivedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonShowIP;
        private System.Windows.Forms.Button buttonSetIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.Button buttonSendCmd;
        private System.Windows.Forms.TextBox textBoxNetworkSetting;
        private System.Windows.Forms.Label label4;
    }
}

