using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace 计算机1702_09223_13222_仓库管理系统
{
    public class Client
    {
        private byte[] result = new byte[1024];  //创建字节数组
        private string SendMessage = ""; //发送的信息
        private string recvMessage = ""; //接受的信息
        private Socket clientSocket;
        private static Lazy<Client> lazy = new Lazy<Client>(() => new Client());
        private Client()
        {
            //设定服务器IP地址
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 80));     //配置服务器IP：端口    
                Console.WriteLine("连接服务器成功！");
            }
            catch
            {
                Console.WriteLine("连接服务器失败，请按回车键退出！");
                return;
            }
            //通过clientSocket接收数据
            Thread thread = new Thread(new ThreadStart(ReadRecv)); /// 创建线程不断读取数据
            thread.Start();
            Thread threadSend = new Thread(new ThreadStart(SendMes));
            threadSend.Start();
        }
        public void ReadRecv()
        {
            while (true)
            {
                int receiveLength = clientSocket.Receive(result);
                recvMessage = Encoding.GetEncoding("GBK").GetString(result, 0, receiveLength).ToString();
            }
        }
        public void SendMes()
        {
            while (true)
            {
                if (!"".Equals(SendMessage))
                {
                    clientSocket.Send(Encoding.GetEncoding("GBK").GetBytes(SendMessage));
                    SendMessage = "";
                }
            }
        }
        public static Client getClient
        {
            get
            {
                return lazy.Value;
            }
        }

        public static string recvMsg
        {
            get
            {
                String Ans = lazy.Value.recvMessage;
                if (!Ans.Equals(""))
                {
                    lazy.Value.recvMessage = "";

                }
                return Ans;
            }
        }
        public static string sendMsg
        {
            get
            {
                return lazy.Value.SendMessage;
            }
            set
            {
                lazy.Value.SendMessage = value;

            }
        }
    }
}
