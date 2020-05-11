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
    public partial class 计算机1702_09223_13222_main : Form
    {
        public 计算机1702_09223_13222_main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = this.tb_email.Text;
            string pwd = this.tb_pwd.Text;
            int role = 0;
            if(rb_admin.Checked)
            {
                role = 1;
            }
            /**
             * 验证 email, pwd
             */
            string sendMsg = "0 email " + email + " pwd " + pwd + " role " + role;
            string recvMsg = Tools.getNowrecvMsg(sendMsg);
            if ("true".Equals(recvMsg))
            {
                Tools.userId = email;
                string _sendMsg = "b email " + email;
                string _recvMsg = Tools.getNowrecvMsg(_sendMsg);
                string[,] info = Tools.parseStr(_recvMsg);
                Tools.userName = info[0, 0];
                if (role == 1)
                {
                    计算机1702_09223_13222_admin form_admin = new 计算机1702_09223_13222_admin(this);
                    form_admin.Show();
                }
                else
                {
                    计算机1702_09223_13222_user form_user = new 计算机1702_09223_13222_user(this);
                    form_user.Show();
                }
                this.Hide();
                this.tb_pwd.Text = "";
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "error");
            }
        }

        private void 计算机1702_09223_13222_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 计算机1702_09223_13222_main_Load(object sender, EventArgs e)
        {
            string check = Client.recvMsg;  // 检查是否连接上
        }

        private void llbl_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            计算机1702_09223_13222_reg form_reg = new 计算机1702_09223_13222_reg(this);
            form_reg.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            计算机1702_09223_13222_forget form_forget = new 计算机1702_09223_13222_forget(this);
            form_forget.Show();
            this.Hide();
        }
    }
}
