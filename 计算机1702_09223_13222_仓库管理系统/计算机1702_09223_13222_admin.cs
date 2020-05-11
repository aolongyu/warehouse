using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算机1702_09223_13222_仓库管理系统
{
    public partial class 计算机1702_09223_13222_admin : Form
    {
        bool flag = true;
        计算机1702_09223_13222_main form_main;

        public 计算机1702_09223_13222_admin(计算机1702_09223_13222_main form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void 计算机1702_09223_13222_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                flag = false;
                form_main.Show();
                this.Close();
            }
        }

        private void 计算机1702_09223_13222_admin_Load(object sender, EventArgs e)
        {
            init_1();   // 加载的时候初始化 DataGridView
            init_2();
        }

        private void init_1()
        {
            string sendMsg = "3";
            dgv_show(sendMsg, this.dgv_info, 10);
        }

        private void init_2()
        {
            string sendMsg = "5";
            dgv_show(sendMsg, this.dgv_auth, 7);
        }

        private void btn_info_check_Click(object sender, EventArgs e)
        {
            string check_way = this.cb_info.Text;   // 模糊查询方式
            string way = "";
            if(check_way.Equals("人员代码"))
            {
                way = "0";
            }
            else if(check_way.Equals("姓名"))
            {
                way = "1";
            }
            else if(check_way.Equals("身份证号"))
            {
                way = "2";
            }
            string check_keyWords = this.tb_info.Text;  // 模糊查询关键词
            string sendMsg = "4 way " + way + " keyWords " + check_keyWords;
            dgv_show(sendMsg, this.dgv_info, 10);
        }

        private void dgv_show(string sendMsg, DataGridView dgv, int col)
        {
            /**
             * @param sendMsg 发送到服务器的字符串
             * @param dgv DataGridView
             */
            string recvMsg = Tools.getNowrecvMsg(sendMsg);
            //MessageBox.Show(col.ToString() + recvMsg);
            string[,] info = Tools.parseStr(recvMsg); // 将接受的数据转成二维数组赋值到info
            int row = Tools.getRow();
            dgv.Rows.Clear();
            for (int i = 0; i < row; ++i) // 添加到dataGridViews中
            {
                int index = 0;
                if (col == 10)
                {
                    index = this.dgv_info.Rows.Add();
                }
                if(col == 7)
                {
                    index = this.dgv_auth.Rows.Add();
                }
                for (int j = 0; j < col; ++j)
                {
                    dgv.Rows[index].Cells[j].Value = info[i, j];
                }
            }
        }

        private void btn_auth_check_Click(object sender, EventArgs e)
        {
            string check_keyWords = this.tb_auth.Text;  // 模糊查询关键词
            string sendMsg = "6 keyWords " + check_keyWords;
            dgv_show(sendMsg, this.dgv_auth, 7);
        }

        private void dgv_info_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            index = dgv_info.CurrentRow.Index;  // 获取当前行的 行号
            string email = dgv_info.Rows[index].Cells[0].Value.ToString();
            string pwd = dgv_info.Rows[index].Cells[1].Value.ToString();
            string name = dgv_info.Rows[index].Cells[2].Value.ToString();
            string sex = dgv_info.Rows[index].Cells[3].Value.ToString();
            string born = dgv_info.Rows[index].Cells[4].Value.ToString();
            string hometown = dgv_info.Rows[index].Cells[5].Value.ToString();
            string tel = dgv_info.Rows[index].Cells[6].Value.ToString();
            string idcard = dgv_info.Rows[index].Cells[7].Value.ToString();
            string address = dgv_info.Rows[index].Cells[8].Value.ToString();
            string remarks = dgv_info.Rows[index].Cells[9].Value.ToString();

            string parmlist = "7";
            parmlist += " email " + email;
            parmlist += " pwd " + pwd;
            parmlist += " name " + name;
            parmlist += " sex " + sex;
            parmlist += " born " + born;
            parmlist += " hometown " + hometown;
            parmlist += " tel " + tel;
            parmlist += " idcard " + idcard;
            parmlist += " address " + address;
            parmlist += " remarks " + remarks;
            string now = Client.recvMsg;
            string recvMsg = Tools.getNowrecvMsg(parmlist);
            //MessageBox.Show(parmlist);
        }

        private void dgv_auth_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            index = dgv_auth.CurrentRow.Index;  // 获取当前行的 行号
            string args_01 = dgv_auth.Rows[index].Cells[0].Value.ToString();
            string args_02 = dgv_auth.Rows[index].Cells[1].Value.ToString();
            string args_03 = dgv_auth.Rows[index].Cells[2].Value.ToString();
            string args_04 = dgv_auth.Rows[index].Cells[3].Value.ToString();
            string args_05 = dgv_auth.Rows[index].Cells[4].Value.ToString();
            string args_06 = dgv_auth.Rows[index].Cells[5].Value.ToString();
            string args_07 = dgv_auth.Rows[index].Cells[6].Value.ToString();

            string parmlist = "g";
            parmlist += " args_01 " + args_01;
            parmlist += " args_02 " + args_02;
            parmlist += " args_03 " + args_03;
            parmlist += " args_04 " + args_04;
            parmlist += " args_05 " + args_05;
            parmlist += " args_06 " + args_06;
            parmlist += " args_07 " + args_07;
            string now = Client.recvMsg;
            string recvMsg = Tools.getNowrecvMsg(parmlist);
            //MessageBox.Show(parmlist);
        }
    }
}
