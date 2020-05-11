using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算机1702_09223_13222_仓库管理系统
{
    class Tools
    {
        static int row;
        public static string userId = "";
        public static string userName = "";
        public static void WriteCVS(string fileName,string title,string data)//path and Titile
        {
            if (!File.Exists(fileName)) //当文件不存在时创建文件
            {
                //创建文件流(创建文件)
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                //创建流写入对象，并绑定文件流
                StreamWriter sw = new StreamWriter(fs);
                //实例化字符串流
                StringBuilder sb = new StringBuilder();
                //将数据添加进字符串流中（如果数据标题有变更，修改此处）

                //刷新文件流
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            //将数据写入文件

            //实例化文件写入对象
            StreamWriter swd = new StreamWriter(fileName, true, Encoding.Default);
            StringBuilder sbd = new StringBuilder();
            //将需要保存的数据添加到字符串流中
            sbd.Append(title);
            sbd.Append(data);
            swd.WriteLine(sbd);
            swd.Flush();
            swd.Close();
        }
        public static string getNowrecvMsg(string parmlist)
        {
            Client.sendMsg = parmlist;

            string nowrecvMsg;
            while ((nowrecvMsg = Client.recvMsg).Equals(""))
            {
                ;//等待它不为空
            }
            if (nowrecvMsg.Equals("empty"))
                return "";
            return nowrecvMsg;
        }


        public static string[,] parseStr(String recvMsg)
        {     //解析服务端传来的数据（字符串），返回二维数组
            string[,] str = new String[66,66];
            char[] chr = recvMsg.ToCharArray();

            row = 0;
            int col = 0;
            String temp = "";

            for (int i = 0; i < recvMsg.Length; i++)
            {
                if (chr[i] == ',')
                {
                    str[row,col] = temp;
                    col++;
                    temp = "";
                    continue;
                }
                if (chr[i] == '#')
                {
                    str[row,col] = temp;
                    row++;
                    col = 0;
                    temp = "";
                    continue;
                }
                temp += chr[i];
            }
            return str;
        }

        public static int getRow()
        {
            return row;
        }

    }

}
