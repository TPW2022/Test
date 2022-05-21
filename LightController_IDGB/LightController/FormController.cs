using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightController
{
    public partial class FormController : Form
    {
        IDBG Light = new IDBG() ;
        public FormController()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string msg = "";
            bool success=Light.Connect(textBoxIP.Text,1000,out msg);
            if (success)
                toolStripStatusLabel_recivedData.Text = "連線成功";
            else
                toolStripStatusLabel_recivedData.Text = "連線失敗！ "+msg;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Light.Disconnect();
            toolStripStatusLabel_recivedData.Text = "已斷線!";
        }

       

        private void buttonSend_Click(object sender, EventArgs e)
        {         
            //toolStripStatusLabel_recivedData.Text = Light.SetBrightness( (byte)numericUpDown_ch1Data.Value, (byte)numericUpDown_ch2Data.Value);
            Light.SetBrightness((byte)numericUpDown_ch1Data.Value, (byte)numericUpDown_ch2Data.Value, out string msg);
            toolStripStatusLabel_recivedData.Text = msg;
        }

        private void buttonSetting1_Click(object sender, EventArgs e)
        {           
            //toolStripStatusLabel_recivedData.Text = Light.SetBrightness(50,140);
            Light.SetBrightness(50, 140, out string msg);
            toolStripStatusLabel_recivedData.Text = msg;
        }

        private void buttonSetting2_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel_recivedData.Text = Light.SetBrightness(170, 0);
            Light.SetBrightness(170, 0, out string msg);
            toolStripStatusLabel_recivedData.Text = msg;
        }

        private void buttonSetting3_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel_recivedData.Text = Light.SetBrightness(0, 200);
            Light.SetBrightness(0, 200, out string msg);
            toolStripStatusLabel_recivedData.Text = msg;
        }

        private void buttonShowIP_Click(object sender, EventArgs e)
        {
            //textBoxNetworkSetting.Text  ="IP: "+ Light.Send("R200000") +Environment.NewLine;
            //textBoxNetworkSetting.Text +="Mask: "+ Light.Send("R210000") + Environment.NewLine;
            //textBoxNetworkSetting.Text += "Gateway: " + Light.Send("R220000") + Environment.NewLine;
            //textBoxNetworkSetting.Text += "Port: " + Light.Send("R230000") + Environment.NewLine;
            
            Light.Send("R200000", out string msg);
            textBoxNetworkSetting.Text = "IP: " + msg + Environment.NewLine;
            Light.Send("R210000", out  msg);
            textBoxNetworkSetting.Text += "Mask: " + msg + Environment.NewLine;
            Light.Send("R220000", out msg);
            textBoxNetworkSetting.Text += "Gateway: " + msg + Environment.NewLine;
            Light.Send("R230000", out msg);
            textBoxNetworkSetting.Text += "Port: " +msg + Environment.NewLine;
        }

        private void buttonSetIP_Click(object sender, EventArgs e)
        {
            IPAddress ip;
           
            if(!IPAddress.TryParse(textBoxIP.Text.Trim(), out ip))
            {
                MessageBox.Show(this,"IP格式錯誤！",this.Text);
            }
            string data = string.Format("{0:D3}.{1:D3}.{2:D3}.{3:D3}", ip.GetAddressBytes()[0], ip.GetAddressBytes()[1], ip.GetAddressBytes()[2], ip.GetAddressBytes()[3]);
            string cmd = string.Format("W20{0}", data);
            Light.Send(cmd,out string msg);
            toolStripStatusLabel_recivedData.Text = msg;
        }

        private void buttonSendCmd_Click(object sender, EventArgs e)
        {
            string cmd = textBoxCmd.Text.Trim();
            Light.Send(cmd, out string msg);
            toolStripStatusLabel_recivedData.Text =msg ;
        }

    }
}
