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
    public partial class 计算机1702_09223_13222_reg : Form
    {
        bool formClosed = false;
        计算机1702_09223_13222_main form_main;

        public 计算机1702_09223_13222_reg(计算机1702_09223_13222_main form)
        {
            InitializeComponent();
            form_main = form;
            tb_email.LostFocus += new EventHandler(txt_LostFocus); //失去焦点后发生事件
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string email = this.tb_email.Text;
            string pwd = this.tb_pwd.Text;
            string name = this.tb_name.Text;
            string sex = this.cb_sex.Text;
            string hometown = this.tb_hometown.Text;    // 籍贯
            string born = this.date_born.Text;  // 出生日期
            born = born.Replace("年", "-");
            born = born.Replace("月", "-");
            born = born.Replace("日", "");
            string tel = this.tb_tel.Text;
            string idcard = this.tb_idcard.Text;    // 身份证号
            string address = this.tb_address.Text;  // 地址
            string remarks = this.rtb_remarks.Text; // 备注
            Console.WriteLine("email:" + email);
            Console.WriteLine("pwd:" + pwd);
            Console.WriteLine("name:" + name);
            Console.WriteLine("sex:" + sex);
            Console.WriteLine("hometown:" + hometown);
            Console.WriteLine("born:" + born);
            Console.WriteLine("tel:" + tel);
            Console.WriteLine("idcard:" + idcard);
            Console.WriteLine("address:" + address);
            Console.WriteLine("remarks:" + remarks);
            /**
             * 信息合法验证
             * 注册信息插入到数据库操作
             */
            /**
             * 验证代码
             */

            string parmlist = "2 ";
            parmlist += "email " + email;
            parmlist += " pwd " + pwd;
            parmlist += " name " + name;
            parmlist += " sex " + sex;
            parmlist += " born " + born;
            parmlist += " hometown " + hometown;
            parmlist += " tel " + tel;
            parmlist += " idcard " + idcard;
            parmlist += " address " + address;
            parmlist += " remarks " + remarks;
            //Client.sendMsg = parmlist;
            string now = Client.recvMsg;
            string regAble = Tools.getNowrecvMsg(parmlist);
            if(email.Equals("") || pwd.Equals("") || name.Equals("") || sex.Equals("") || born.Equals("") || hometown.Equals("") || tel.Equals("") || idcard.Equals("") || address.Equals("") || remarks.Equals(""))
            {
                MessageBox.Show("有信息为空，请填补完毕后再次注册");
                return;
            }
            if ("true".Equals(regAble))
            {
                MessageBox.Show("恭喜，注册成功");
                jumpToLogin();  // 注册成功回到登录界面
            }
            else
            {   // 注册失败
                MessageBox.Show("对不起，注册失败");
            }
        }

        private void 计算机1702_09223_13222_reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!formClosed)    // 关闭注册窗口回到登录界面
            {
                jumpToLogin(); 
            }
        }

        private void jumpToLogin()  // 跳转到登录界面
        {
            formClosed = true;
            form_main.Show();
            this.Close();
        }

        void txt_LostFocus(object sender, EventArgs e)
        {
            string email = this.tb_email.Text;
            if (!"".Equals(email))
            {
                string parmlist = "1 " + "email " + email;
                string temp = Client.recvMsg;
                string nowrecvMsg = Tools.getNowrecvMsg(parmlist);
                if("true".Equals(nowrecvMsg))
                {
                    this.lbl_reg_exist.ForeColor = Color.Red;
                    this.lbl_reg_exist.Text = "已注册";
                }
                else
                {
                    this.lbl_reg_exist.ForeColor = Color.Green;
                    this.lbl_reg_exist.Text = "可用";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.tb_email.Text;
            if("".Equals(email))
            {
                MessageBox.Show("请输入邮箱", "提示");
            }
            else
            {
                string sendMsg = "d";
                sendMsg += " email " + email;
                string recvMsg = Tools.getNowrecvMsg(sendMsg);
                this.btn_yzm.Visible = false;
                this.btn_reg.Visible = true;
            }
        }

        private void tb_idcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能数字或字母
            if ((e.KeyChar != '\b') && (!Char.IsLetter(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tb_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能数字
            if ((e.KeyChar != '\b') && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
