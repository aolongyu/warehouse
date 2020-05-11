using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算机1702_09223_13222_仓库管理系统
{
    public partial class 计算机1702_09223_13222_user : Form
    {
        bool formClosed = false;
        计算机1702_09223_13222_main form_main;

        public 计算机1702_09223_13222_user(计算机1702_09223_13222_main form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void 计算机1702_09223_13222_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!formClosed)
            {
                formClosed = true;
                form_main.Show();
                this.Close();
            }
        }

        private void 计算机1702_09223_13222_user_Load(object sender, EventArgs e)
        {
            init_auth();
            init_cb();
            lbl_user_in.Text = Tools.userName;  // 赋值用户名;
            lbl_user_out.Text = Tools.userName;
            lbl_user_print.Text = Tools.userName;
        }

        private void init_cb()
        {
            string sendMsg = "h";
            string recvMsg = Tools.getNowrecvMsg(sendMsg);
            string[,] info = Tools.parseStr(recvMsg);
            int row = Tools.getRow();
            for(int i = 0; i < row; ++i)
            {
                this.cb_in.Items.Add(info[i, 0]);
                this.cb_out.Items.Add(info[i, 0]);
            }
        }

        private void init_auth()
        {
            string sendMsg = "f";
            sendMsg += " email " + Tools.userId;
            string recvMsg = Tools.getNowrecvMsg(sendMsg);
            string[,] info = Tools.parseStr(recvMsg); // 将接受的数据转成二维数组赋值到info
            int row = Tools.getRow();
            int num = 4;
            if(info[0, 2].Equals("0"))
            {
                num--;
                this.tabControl1.TabPages.Remove(this.tp_wlda);
            }
            else
            {
                init_dgv();
            }
            if(info[0, 5].Equals("0"))
            {
                num--;
                this.tabControl1.TabPages.Remove(this.tp_in);
            }
            if(info[0, 6].Equals("0"))
            {
                num--;
                this.tabControl1.TabPages.Remove(this.tp_out);
            }
            if(info[0, 4].Equals("0"))
            {
                num--;
                this.tabControl1.TabPages.Remove(this.tp_print);
            }
            if(num <= 0)
            {
                this.tabControl1.Visible = false;
                this.lbl_user_msg.Visible = true;
                //MessageBox.Show("您目前没有任何权限，请联系管理员：aolyu@qq.com", "提示");
            }
        }

        private void init_dgv()
        {
            string sendMsg = "8";
            dgv_show(sendMsg, this.dgv_materials, 6);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            string type = "进仓";  // 
            string id = this.cb_in.Text; // 物料代码
            string user_id = Tools.userId; // 操作人员代码
            string num = this.tb_in_num.Text;   // 数量
            string remarks = this.rtb_in_remarks.Text;  // 备注

            if ("".Equals(id) || "".Equals(num))
            {
                MessageBox.Show("请将入仓信息填写完整", "提示");
            }

            string sendMsg = "9";
            sendMsg += " type " + type;
            sendMsg += " id " + id;
            sendMsg += " user_id " + user_id;
            sendMsg += " num " + num;
            sendMsg += " remarks " + remarks;
            string recvMsg = Tools.getNowrecvMsg(sendMsg);
            if("true".Equals(recvMsg))
            {
                MessageBox.Show("入仓成功", "提示");
                this.cb_in.Text = "";
                this.tb_in_num.Text = "";
                this.rtb_in_remarks.Text = "无";
                init_auth();
            }
            else
            {
                MessageBox.Show("入仓失败", "提示");
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            string type = "出仓";  //
            string id = this.cb_out.Text; // 物料代码
            string user_id = Tools.userId; // 操作人员代码
            string num = this.tb_out_num.Text;   // 数量
            string remarks = this.rtb_out_remarks.Text;  // 备注

            if("".Equals(id) || "".Equals(num))
            {
                MessageBox.Show("请将入仓信息填写完整", "提示");
            }

            string sendMsg = "a";
            
            sendMsg += " type " + type;
            sendMsg += " id " + id;
            sendMsg += " user_id " + user_id;
            sendMsg += " num " + num;
            sendMsg += " remarks " + remarks;
            string recvMsg = Tools.getNowrecvMsg(sendMsg);
            if ("true".Equals(recvMsg))
            {
                MessageBox.Show("出仓成功", "提示");
                this.cb_out.Text = "";
                this.tb_out_num.Text = "";
                this.rtb_out_remarks.Text = "无";
                init_auth();
            }
            else
            {
                MessageBox.Show("出仓失败", "提示");
            }
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
                    index = this.dgv_materials.Rows.Add();
                }
                if (col == 6)
                {
                    index = this.dgv_materials.Rows.Add();
                }
                for (int j = 0; j < col; ++j)
                {
                    dgv.Rows[index].Cells[j].Value = info[i, j];
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            string Path = "";
            if (fb.ShowDialog() == DialogResult.OK)
                Path = fb.SelectedPath;
            //MessageBox.Show(Path);
            string fileName = Path;
            string sendMsg = "";
            string recvMsg = "";
            string title = "";
            if(rb_ulda.Checked) // 导出物料档案
            {
                fileName += "//物料档案" + Tools.userId + ".csv";
                sendMsg += "c pro 0";
                recvMsg = Tools.getNowrecvMsg(sendMsg);
                recvMsg = recvMsg.Replace("#", "\r\n");
                Tools.WriteCVS(fileName, "物料代码,物料名称,规格型号,计量单位,库存数量,备注\r\n", recvMsg);
            }
            else if(rb_in.Checked)  // 导出进仓明细
            {
                fileName += "//进仓明细" + Tools.userId + ".csv";
                sendMsg += "c pro 1";
                recvMsg = Tools.getNowrecvMsg(sendMsg);
                recvMsg = recvMsg.Replace("#", "\r\n");
                Tools.WriteCVS(fileName, "单号,类型,物料代码,操作人员代码,日期,数量,备注\r\n", recvMsg);
            }
            else if(rb_out.Checked) // 导出出仓明细
            {
                fileName += "//出仓明细" + Tools.userId + ".csv";
                sendMsg += "c pro 2";
                recvMsg = Tools.getNowrecvMsg(sendMsg);
                recvMsg = recvMsg.Replace("#", "\r\n");
                Tools.WriteCVS(fileName, "单号,类型,物料代码,操作人员代码,日期,数量,备注\r\n", recvMsg);
            }
            else
            {
                MessageBox.Show("请选择导出项目", "提示");
            }
            
            
        }
    }
}
