namespace 计算机1702_09223_13222_仓库管理系统
{
    partial class 计算机1702_09223_13222_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计算机1702_09223_13222_admin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_info_check = new System.Windows.Forms.Button();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.cb_info = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.人员代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.籍贯 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_auth_check = new System.Windows.Forms.Button();
            this.tb_auth = new System.Windows.Forms.TextBox();
            this.cb_auth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_auth = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人员档案管理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料档案管理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理员权限 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.统计打印 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进仓管理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出仓管理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人员信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_info_check);
            this.groupBox2.Controls.Add(this.tb_info);
            this.groupBox2.Controls.Add(this.cb_info);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(669, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(98, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btn_info_check
            // 
            this.btn_info_check.Location = new System.Drawing.Point(19, 110);
            this.btn_info_check.Margin = new System.Windows.Forms.Padding(2);
            this.btn_info_check.Name = "btn_info_check";
            this.btn_info_check.Size = new System.Drawing.Size(56, 22);
            this.btn_info_check.TabIndex = 4;
            this.btn_info_check.Text = "查询";
            this.btn_info_check.UseVisualStyleBackColor = true;
            this.btn_info_check.Click += new System.EventHandler(this.btn_info_check_Click);
            // 
            // tb_info
            // 
            this.tb_info.Location = new System.Drawing.Point(4, 86);
            this.tb_info.Margin = new System.Windows.Forms.Padding(2);
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(90, 21);
            this.tb_info.TabIndex = 3;
            // 
            // cb_info
            // 
            this.cb_info.FormattingEnabled = true;
            this.cb_info.Items.AddRange(new object[] {
            "人员代码",
            "姓名",
            "身份证号"});
            this.cb_info.Location = new System.Drawing.Point(4, 45);
            this.cb_info.Margin = new System.Windows.Forms.Padding(2);
            this.cb_info.Name = "cb_info";
            this.cb_info.Size = new System.Drawing.Size(90, 20);
            this.cb_info.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "关键字";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询条件";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_info);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(659, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员信息";
            // 
            // dgv_info
            // 
            this.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_info.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.人员代码,
            this.密码,
            this.姓名,
            this.性别,
            this.出生日期,
            this.身份证号,
            this.籍贯,
            this.地址,
            this.联系电话,
            this.备注});
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_info.Location = new System.Drawing.Point(2, 16);
            this.dgv_info.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowTemplate.Height = 27;
            this.dgv_info.Size = new System.Drawing.Size(655, 376);
            this.dgv_info.TabIndex = 0;
            this.dgv_info.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_info_CellEndEdit);
            // 
            // 人员代码
            // 
            this.人员代码.HeaderText = "人员代码";
            this.人员代码.Name = "人员代码";
            // 
            // 密码
            // 
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 性别
            // 
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            // 
            // 出生日期
            // 
            this.出生日期.HeaderText = "出生日期";
            this.出生日期.Name = "出生日期";
            // 
            // 身份证号
            // 
            this.身份证号.HeaderText = "身份证号";
            this.身份证号.Name = "身份证号";
            // 
            // 籍贯
            // 
            this.籍贯.HeaderText = "籍贯";
            this.籍贯.Name = "籍贯";
            // 
            // 地址
            // 
            this.地址.HeaderText = "地址";
            this.地址.Name = "地址";
            // 
            // 联系电话
            // 
            this.联系电话.HeaderText = "联系电话";
            this.联系电话.Name = "联系电话";
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "人员权限管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_auth_check);
            this.groupBox4.Controls.Add(this.tb_auth);
            this.groupBox4.Controls.Add(this.cb_auth);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(670, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(98, 394);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "操作";
            // 
            // btn_auth_check
            // 
            this.btn_auth_check.Location = new System.Drawing.Point(19, 110);
            this.btn_auth_check.Margin = new System.Windows.Forms.Padding(2);
            this.btn_auth_check.Name = "btn_auth_check";
            this.btn_auth_check.Size = new System.Drawing.Size(56, 22);
            this.btn_auth_check.TabIndex = 4;
            this.btn_auth_check.Text = "查询";
            this.btn_auth_check.UseVisualStyleBackColor = true;
            this.btn_auth_check.Click += new System.EventHandler(this.btn_auth_check_Click);
            // 
            // tb_auth
            // 
            this.tb_auth.Location = new System.Drawing.Point(4, 86);
            this.tb_auth.Margin = new System.Windows.Forms.Padding(2);
            this.tb_auth.Name = "tb_auth";
            this.tb_auth.Size = new System.Drawing.Size(90, 21);
            this.tb_auth.TabIndex = 3;
            // 
            // cb_auth
            // 
            this.cb_auth.FormattingEnabled = true;
            this.cb_auth.Items.AddRange(new object[] {
            "人员代码"});
            this.cb_auth.Location = new System.Drawing.Point(4, 45);
            this.cb_auth.Margin = new System.Windows.Forms.Padding(2);
            this.cb_auth.Name = "cb_auth";
            this.cb_auth.Size = new System.Drawing.Size(90, 20);
            this.cb_auth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "关键字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "查询条件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_auth);
            this.groupBox3.Location = new System.Drawing.Point(5, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(659, 394);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "人员信息";
            // 
            // dgv_auth
            // 
            this.dgv_auth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_auth.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_auth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_auth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.人员档案管理,
            this.物料档案管理,
            this.管理员权限,
            this.统计打印,
            this.进仓管理,
            this.出仓管理});
            this.dgv_auth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_auth.Location = new System.Drawing.Point(2, 16);
            this.dgv_auth.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_auth.Name = "dgv_auth";
            this.dgv_auth.RowTemplate.Height = 27;
            this.dgv_auth.Size = new System.Drawing.Size(655, 376);
            this.dgv_auth.TabIndex = 0;
            this.dgv_auth.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_auth_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "人员代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // 人员档案管理
            // 
            this.人员档案管理.HeaderText = "人员档案管理";
            this.人员档案管理.Name = "人员档案管理";
            // 
            // 物料档案管理
            // 
            this.物料档案管理.HeaderText = "物料档案管理";
            this.物料档案管理.Name = "物料档案管理";
            // 
            // 管理员权限
            // 
            this.管理员权限.HeaderText = "管理员权限";
            this.管理员权限.Name = "管理员权限";
            // 
            // 统计打印
            // 
            this.统计打印.HeaderText = "统计打印";
            this.统计打印.Name = "统计打印";
            // 
            // 进仓管理
            // 
            this.进仓管理.HeaderText = "进仓管理";
            this.进仓管理.Name = "进仓管理";
            // 
            // 出仓管理
            // 
            this.出仓管理.HeaderText = "出仓管理";
            this.出仓管理.Name = "出仓管理";
            // 
            // 计算机1702_09223_13222_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "计算机1702_09223_13222_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算机1702_09223_13222_admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.计算机1702_09223_13222_admin_FormClosed);
            this.Load += new System.EventHandler(this.计算机1702_09223_13222_admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.ComboBox cb_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人员代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 籍贯;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.Button btn_info_check;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_auth_check;
        private System.Windows.Forms.TextBox tb_auth;
        private System.Windows.Forms.ComboBox cb_auth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_auth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人员档案管理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料档案管理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理员权限;
        private System.Windows.Forms.DataGridViewTextBoxColumn 统计打印;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进仓管理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出仓管理;
    }
}