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
    public partial class 计算机1702_09223_13222_forget : Form
    {
        bool flag = true;
        计算机1702_09223_13222_main form_main;

        public 计算机1702_09223_13222_forget(计算机1702_09223_13222_main form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void 计算机1702_09223_13222_forget_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                flag = false;
                form_main.Show();
                this.Close();
            }
        }

        string yzm1 = "";

        private void btn_forget_getYzm_Click(object sender, EventArgs e)
        {
            string email = this.tb_forget_email.Text;
            string sendMsg = "d email " + email;
            yzm1 = Tools.getNowrecvMsg(sendMsg);
            this.tb_forget_yzm.Visible = true;
            this.tb_forget_pwd1.Visible = true;
            this.tb_forget_pwd2.Visible = true;
            this.lbl_forget_yzm.Visible = true;
            this.lbl_forget_pwd1.Visible = true;
            this.lbl_forget_pwd2.Visible = true;
            this.btn_forget_Ok.Visible = true;
        }

        private void btn_forget_Ok_Click(object sender, EventArgs e)
        {
            string email = this.tb_forget_email.Text;
            string yzm = this.tb_forget_yzm.Text;
            string pwd1 = this.tb_forget_pwd1.Text;
            string pwd2 = this.tb_forget_pwd2.Text;
            if(yzm.Equals(yzm1))
            {

                if (pwd1.Equals(pwd2))
                {
                    string sendMsg = "e";
                    sendMsg += " email " + email;
                    sendMsg += " pwd " + pwd1;
                    string recvMsg = Tools.getNowrecvMsg(sendMsg);
                    if("true".Equals(recvMsg))
                    {
                        MessageBox.Show("设置成功", "提示");
                        flag = false;
                        form_main.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("设置失败", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("请正确输入密码", "提示");
                }
            }
            else
            {
                MessageBox.Show("验证码错误", "提示");
            }
        }
    }
}
