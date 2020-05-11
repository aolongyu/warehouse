namespace 计算机1702_09223_13222_仓库管理系统
{
    partial class 计算机1702_09223_13222_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计算机1702_09223_13222_main));
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_user = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.llbl_reg = new System.Windows.Forms.LinkLabel();
            this.lbl_reg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(655, 267);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(133, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "邮箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // rb_user
            // 
            this.rb_user.AutoSize = true;
            this.rb_user.Checked = true;
            this.rb_user.Location = new System.Drawing.Point(655, 230);
            this.rb_user.Name = "rb_user";
            this.rb_user.Size = new System.Drawing.Size(71, 16);
            this.rb_user.TabIndex = 3;
            this.rb_user.TabStop = true;
            this.rb_user.Text = "操作人员";
            this.rb_user.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Location = new System.Drawing.Point(729, 230);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(59, 16);
            this.rb_admin.TabIndex = 4;
            this.rb_admin.Text = "管理员";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(688, 143);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 21);
            this.tb_email.TabIndex = 1;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(688, 182);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(100, 21);
            this.tb_pwd.TabIndex = 2;
            // 
            // llbl_reg
            // 
            this.llbl_reg.AutoSize = true;
            this.llbl_reg.Location = new System.Drawing.Point(726, 315);
            this.llbl_reg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbl_reg.Name = "llbl_reg";
            this.llbl_reg.Size = new System.Drawing.Size(65, 12);
            this.llbl_reg.TabIndex = 7;
            this.llbl_reg.TabStop = true;
            this.llbl_reg.Text = "没有账号？";
            this.llbl_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_reg_LinkClicked);
            // 
            // lbl_reg
            // 
            this.lbl_reg.Location = new System.Drawing.Point(0, 0);
            this.lbl_reg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(75, 18);
            this.lbl_reg.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 451);
            this.panel1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(653, 315);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // 计算机1702_09223_13222_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llbl_reg);
            this.Controls.Add(this.lbl_reg);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.rb_admin);
            this.Controls.Add(this.rb_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "计算机1702_09223_13222_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算机1702_09223_13222_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.计算机1702_09223_13222_main_FormClosed);
            this.Load += new System.EventHandler(this.计算机1702_09223_13222_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_user;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.LinkLabel llbl_reg;
        private System.Windows.Forms.Label lbl_reg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

