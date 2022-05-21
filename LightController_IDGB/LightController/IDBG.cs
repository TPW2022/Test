using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace LightController
{
    public class IDBG
    {
        IPAddress LightAddress;
        Socket MySocket;
        Byte[] CommandBytes = new Byte[200];
        Byte[] ReceivedBytes = new Byte[200];
        int PortNum;
        public bool IsConnected;

        public IDBG()
        {

        }
        public bool Connect(string ipAddress,int port,out string errorMsg)
        {          
           return  Connect(IPAddress.Parse(ipAddress), port,out errorMsg);
        }

        public bool Connect(IPAddress ipAddress,int port,out string errorMsg)
        {
            IsConnected = false;
            errorMsg = "";
            LightAddress = ipAddress;
            PortNum = port;
            
            try
            {
                // 先使用 ping 來確定 連線是否正常 
                Ping tPingControl = new Ping();
                PingReply tReply = tPingControl.Send(LightAddress);
                tPingControl.Dispose();

                if (tReply.Status == IPStatus.Success)
                {
                    // 建立Server 端點
                    IPEndPoint serverEP = new IPEndPoint(LightAddress, PortNum);
                    // 建立 Socket , 並使用 TCP/IP 協定
                    MySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    MySocket.Connect(serverEP);
                    IsConnected = true;
                }
                else
                {
                    errorMsg = "Ping "+LightAddress.ToString()+" failed!";
                    IsConnected = false;
                }

            }
            catch (Exception ex)
            {
                errorMsg = "光源未連線! "+ ex.Message;
                IsConnected = false;
            }
            return IsConnected;
        }

        private string SendReceive(string cmd)
        {
           // Byte[] receivedBytes;
            string receiveData = "";

            if (MySocket == null || !MySocket.Connected )
                return ("連線已中斷! CMD:"+cmd);

            // Command: W11cc####cc####
            // [Descriptions]
            // W11:  調整光源亮度
            // cc####: channel + 亮度值(範圍: 0000-0255)
            // Example: W11010024020000
            CommandBytes = Encoding.ASCII.GetBytes(cmd);
            //MySocket.Send(Command);
            //Thread.Sleep(100);
            // mySocket.Receive(receiveData);
                    
            MySocket.Send(CommandBytes);
            int bytes = 0;
            bytes = MySocket.Receive(ReceivedBytes);
            receiveData=Encoding.ASCII.GetString(ReceivedBytes,0,bytes);
            return receiveData;           
            
        }
        /// <summary>
        /// 連線-傳送指令-斷線
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public  bool Send(string cmd,out string msg)
        {
            bool result = true;
            if (!IsConnected)
            {
                if(this.LightAddress==null)
                {
                    throw new Exception("LightAddress未設定!");
                }
                Connect(this.LightAddress, this.PortNum, out string errorMsg);
            }
           

             msg = SendReceive(cmd);
            if(msg.StartsWith("W"))
            {
                if (IDBG_ResponseData.W11.ContainsKey(msg))
                    msg= IDBG_ResponseData.W11[msg];
               
            }
            else if(msg.StartsWith("R"))
            {
                if (IDBG_ResponseData.All.ContainsKey(msg.Substring(msg.Length - 4)))
                    msg= IDBG_ResponseData.All[msg];
                else
                    msg= msg.Substring(3);
            }
            else if (IDBG_ResponseData.All.ContainsKey(msg.Substring(msg.Length - 4)))
            {               
                    msg= IDBG_ResponseData.All[msg];               
            }
            else
            {
                result = false;
            }
            Disconnect();//設定完立即斷線，避免不正常關閉導致光源控制器需重開才能連線。
            return result;
        }
        /// <summary>
        /// 設定光源亮度, 回傳設定結果。(自動連線並斷線)
        /// </summary>
        /// <param name="ch1Value">(0~255)</param>
        /// <param name="ch2Value">(0~255)</param>
        /// <returns></returns>
        public bool SetBrightness(byte ch1Value,byte ch2Value,out string msg)
        {
           
            string cmd = string.Format("W1101{0:D4}02{1:D4}", ch1Value, ch2Value);
            return Send(cmd,out msg);
        }
        /// <summary>
        /// 關閉光源
        /// </summary>
        /// <returns></returns>
        public bool LightOff(out string msg)
        {
           
            return SetBrightness(0, 0,out msg);
        }
        
        public void Disconnect()
        {
            try
            {
                if (MySocket != null && IsConnected)
                {
                    MySocket.Disconnect(false);//使用Disconnect(true)會卡住
                }
                  
            }
            finally
            {               
                IsConnected = false;
            }
        }

        public void Dispose()
        {
            Disconnect();
            MySocket.Close();
        }
    }
}
