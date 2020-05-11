namespace 计算机1702_09223_13222_仓库管理系统
{
    partial class 计算机1702_09223_13222_forget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_forget_email = new System.Windows.Forms.TextBox();
            this.lbl_forget_email = new System.Windows.Forms.Label();
            this.lbl_forget_yzm = new System.Windows.Forms.Label();
            this.lbl_forget_pwd1 = new System.Windows.Forms.Label();
            this.lbl_forget_pwd2 = new System.Windows.Forms.Label();
            this.tb_forget_yzm = new System.Windows.Forms.TextBox();
            this.tb_forget_pwd1 = new System.Windows.Forms.TextBox();
            this.tb_forget_pwd2 = new System.Windows.Forms.TextBox();
            this.btn_forget_getYzm = new System.Windows.Forms.Button();
            this.btn_forget_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_forget_email
            // 
            this.tb_forget_email.Location = new System.Drawing.Point(335, 76);
            this.tb_forget_email.Name = "tb_forget_email";
            this.tb_forget_email.Size = new System.Drawing.Size(100, 21);
            this.tb_forget_email.TabIndex = 0;
            // 
            // lbl_forget_email
            // 
            this.lbl_forget_email.AutoSize = true;
            this.lbl_forget_email.Location = new System.Drawing.Point(277, 79);
            this.lbl_forget_email.Name = "lbl_forget_email";
            this.lbl_forget_email.Size = new System.Drawing.Size(53, 12);
            this.lbl_forget_email.TabIndex = 1;
            this.lbl_forget_email.Text = "邮    箱";
            // 
            // lbl_forget_yzm
            // 
            this.lbl_forget_yzm.AutoSize = true;
            this.lbl_forget_yzm.Location = new System.Drawing.Point(277, 122);
            this.lbl_forget_yzm.Name = "lbl_forget_yzm";
            this.lbl_forget_yzm.Size = new System.Drawing.Size(53, 12);
            this.lbl_forget_yzm.TabIndex = 2;
            this.lbl_forget_yzm.Text = "验 证 码";
            // 
            // lbl_forget_pwd1
            // 
            this.lbl_forget_pwd1.AutoSize = true;
            this.lbl_forget_pwd1.Location = new System.Drawing.Point(277, 166);
            this.lbl_forget_pwd1.Name = "lbl_forget_pwd1";
            this.lbl_forget_pwd1.Size = new System.Drawing.Size(53, 12);
            this.lbl_forget_pwd1.TabIndex = 3;
            this.lbl_forget_pwd1.Text = "新 密 码";
            this.lbl_forget_pwd1.Visible = false;
            // 
            // lbl_forget_pwd2
            // 
            this.lbl_forget_pwd2.AutoSize = true;
            this.lbl_forget_pwd2.Location = new System.Drawing.Point(277, 211);
            this.lbl_forget_pwd2.Name = "lbl_forget_pwd2";
            this.lbl_forget_pwd2.Size = new System.Drawing.Size(53, 12);
            this.lbl_forget_pwd2.TabIndex = 4;
            this.lbl_forget_pwd2.Text = "确认密码";
            this.lbl_forget_pwd2.Visible = false;
            // 
            // tb_forget_yzm
            // 
            this.tb_forget_yzm.Location = new System.Drawing.Point(335, 119);
            this.tb_forget_yzm.Name = "tb_forget_yzm";
            this.tb_forget_yzm.Size = new System.Drawing.Size(100, 21);
            this.tb_forget_yzm.TabIndex = 5;
            // 
            // tb_forget_pwd1
            // 
            this.tb_forget_pwd1.Location = new System.Drawing.Point(335, 163);
            this.tb_forget_pwd1.Name = "tb_forget_pwd1";
            this.tb_forget_pwd1.PasswordChar = '*';
            this.tb_forget_pwd1.Size = new System.Drawing.Size(100, 21);
            this.tb_forget_pwd1.TabIndex = 6;
            this.tb_forget_pwd1.Visible = false;
            // 
            // tb_forget_pwd2
            // 
            this.tb_forget_pwd2.Location = new System.Drawing.Point(335, 208);
            this.tb_forget_pwd2.Name = "tb_forget_pwd2";
            this.tb_forget_pwd2.PasswordChar = '*';
            this.tb_forget_pwd2.Size = new System.Drawing.Size(100, 21);
            this.tb_forget_pwd2.TabIndex = 7;
            this.tb_forget_pwd2.Visible = false;
            // 
            // btn_forget_getYzm
            // 
            this.btn_forget_getYzm.Location = new System.Drawing.Point(459, 117);
            this.btn_forget_getYzm.Name = "btn_forget_getYzm";
            this.btn_forget_getYzm.Size = new System.Drawing.Size(75, 23);
            this.btn_forget_getYzm.TabIndex = 8;
            this.btn_forget_getYzm.Text = "获取验证码";
            this.btn_forget_getYzm.UseVisualStyleBackColor = true;
            this.btn_forget_getYzm.Click += new System.EventHandler(this.btn_forget_getYzm_Click);
            // 
            // btn_forget_Ok
            // 
            this.btn_forget_Ok.Location = new System.Drawing.Point(346, 256);
            this.btn_forget_Ok.Name = "btn_forget_Ok";
            this.btn_forget_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_forget_Ok.TabIndex = 9;
            this.btn_forget_Ok.Text = "确认修改";
            this.btn_forget_Ok.UseVisualStyleBackColor = true;
            this.btn_forget_Ok.Visible = false;
            this.btn_forget_Ok.Click += new System.EventHandler(this.btn_forget_Ok_Click);
            // 
            // 计算机1702_09223_13222_forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_forget_Ok);
            this.Controls.Add(this.btn_forget_getYzm);
            this.Controls.Add(this.tb_forget_pwd2);
            this.Controls.Add(this.tb_forget_pwd1);
            this.Controls.Add(this.tb_forget_yzm);
            this.Controls.Add(this.lbl_forget_pwd2);
            this.Controls.Add(this.lbl_forget_pwd1);
            this.Controls.Add(this.lbl_forget_yzm);
            this.Controls.Add(this.lbl_forget_email);
            this.Controls.Add(this.tb_forget_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "计算机1702_09223_13222_forget";
            this.Text = "计算机1702_09223_13222_forget";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.计算机1702_09223_13222_forget_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_forget_email;
        private System.Windows.Forms.Label lbl_forget_email;
        private System.Windows.Forms.Label lbl_forget_yzm;
        private System.Windows.Forms.Label lbl_forget_pwd1;
        private System.Windows.Forms.Label lbl_forget_pwd2;
        private System.Windows.Forms.TextBox tb_forget_yzm;
        private System.Windows.Forms.TextBox tb_forget_pwd1;
        private System.Windows.Forms.TextBox tb_forget_pwd2;
        private System.Windows.Forms.Button btn_forget_getYzm;
        private System.Windows.Forms.Button btn_forget_Ok;
    }
}