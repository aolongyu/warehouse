namespace 计算机1702_09223_13222_仓库管理系统
{
    partial class 计算机1702_09223_13222_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计算机1702_09223_13222_user));
            this.tp_in = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_user_in = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_in_remarks = new System.Windows.Forms.RichTextBox();
            this.tb_in_num = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_wlda = new System.Windows.Forms.TabPage();
            this.dgv_materials = new System.Windows.Forms.DataGridView();
            this.物料代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计量单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_out = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_user_out = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_out_remarks = new System.Windows.Forms.RichTextBox();
            this.tb_out_num = new System.Windows.Forms.TextBox();
            this.tp_print = new System.Windows.Forms.TabPage();
            this.lbl_user_print = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_out = new System.Windows.Forms.RadioButton();
            this.rb_in = new System.Windows.Forms.RadioButton();
            this.rb_ulda = new System.Windows.Forms.RadioButton();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_user_msg = new System.Windows.Forms.Label();
            this.cb_in = new System.Windows.Forms.ComboBox();
            this.cb_out = new System.Windows.Forms.ComboBox();
            this.tp_in.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_wlda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materials)).BeginInit();
            this.tp_out.SuspendLayout();
            this.tp_print.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_in
            // 
            this.tp_in.Controls.Add(this.cb_in);
            this.tp_in.Controls.Add(this.label10);
            this.tp_in.Controls.Add(this.lbl_user_in);
            this.tp_in.Controls.Add(this.label8);
            this.tp_in.Controls.Add(this.btn_in);
            this.tp_in.Controls.Add(this.label3);
            this.tp_in.Controls.Add(this.label2);
            this.tp_in.Controls.Add(this.label1);
            this.tp_in.Controls.Add(this.rtb_in_remarks);
            this.tp_in.Controls.Add(this.tb_in_num);
            this.tp_in.Location = new System.Drawing.Point(4, 22);
            this.tp_in.Name = "tp_in";
            this.tp_in.Padding = new System.Windows.Forms.Padding(3);
            this.tp_in.Size = new System.Drawing.Size(768, 400);
            this.tp_in.TabIndex = 1;
            this.tp_in.Text = "进仓管理";
            this.tp_in.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(364, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "进仓";
            // 
            // lbl_user_in
            // 
            this.lbl_user_in.AutoSize = true;
            this.lbl_user_in.Location = new System.Drawing.Point(713, 3);
            this.lbl_user_in.Name = "lbl_user_in";
            this.lbl_user_in.Size = new System.Drawing.Size(29, 12);
            this.lbl_user_in.TabIndex = 18;
            this.lbl_user_in.Text = "未知";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "当前用户：";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(305, 301);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(152, 29);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "进仓";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "备    注";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "数    量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "物料代码";
            // 
            // rtb_in_remarks
            // 
            this.rtb_in_remarks.Location = new System.Drawing.Point(369, 162);
            this.rtb_in_remarks.Name = "rtb_in_remarks";
            this.rtb_in_remarks.Size = new System.Drawing.Size(100, 96);
            this.rtb_in_remarks.TabIndex = 3;
            this.rtb_in_remarks.Text = "无";
            // 
            // tb_in_num
            // 
            this.tb_in_num.Location = new System.Drawing.Point(369, 106);
            this.tb_in_num.Name = "tb_in_num";
            this.tb_in_num.Size = new System.Drawing.Size(100, 21);
            this.tb_in_num.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_wlda);
            this.tabControl1.Controls.Add(this.tp_in);
            this.tabControl1.Controls.Add(this.tp_out);
            this.tabControl1.Controls.Add(this.tp_print);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_wlda
            // 
            this.tp_wlda.Controls.Add(this.dgv_materials);
            this.tp_wlda.Location = new System.Drawing.Point(4, 22);
            this.tp_wlda.Name = "tp_wlda";
            this.tp_wlda.Padding = new System.Windows.Forms.Padding(3);
            this.tp_wlda.Size = new System.Drawing.Size(768, 400);
            this.tp_wlda.TabIndex = 0;
            this.tp_wlda.Text = "物料档案";
            this.tp_wlda.UseVisualStyleBackColor = true;
            // 
            // dgv_materials
            // 
            this.dgv_materials.AllowUserToAddRows = false;
            this.dgv_materials.AllowUserToDeleteRows = false;
            this.dgv_materials.AllowUserToOrderColumns = true;
            this.dgv_materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_materials.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物料代码,
            this.物料名称,
            this.规格型号,
            this.计量单位,
            this.库存数量,
            this.备注});
            this.dgv_materials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_materials.Location = new System.Drawing.Point(3, 3);
            this.dgv_materials.Name = "dgv_materials";
            this.dgv_materials.ReadOnly = true;
            this.dgv_materials.RowTemplate.Height = 23;
            this.dgv_materials.Size = new System.Drawing.Size(762, 394);
            this.dgv_materials.TabIndex = 0;
            // 
            // 物料代码
            // 
            this.物料代码.HeaderText = "物料代码";
            this.物料代码.Name = "物料代码";
            this.物料代码.ReadOnly = true;
            // 
            // 物料名称
            // 
            this.物料名称.HeaderText = "物料名称";
            this.物料名称.Name = "物料名称";
            this.物料名称.ReadOnly = true;
            // 
            // 规格型号
            // 
            this.规格型号.HeaderText = "规格型号";
            this.规格型号.Name = "规格型号";
            this.规格型号.ReadOnly = true;
            // 
            // 计量单位
            // 
            this.计量单位.HeaderText = "计量单位";
            this.计量单位.Name = "计量单位";
            this.计量单位.ReadOnly = true;
            // 
            // 库存数量
            // 
            this.库存数量.HeaderText = "库存数量";
            this.库存数量.Name = "库存数量";
            this.库存数量.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // tp_out
            // 
            this.tp_out.Controls.Add(this.cb_out);
            this.tp_out.Controls.Add(this.label7);
            this.tp_out.Controls.Add(this.lbl_user_out);
            this.tp_out.Controls.Add(this.label9);
            this.tp_out.Controls.Add(this.btn_out);
            this.tp_out.Controls.Add(this.label4);
            this.tp_out.Controls.Add(this.label5);
            this.tp_out.Controls.Add(this.label6);
            this.tp_out.Controls.Add(this.rtb_out_remarks);
            this.tp_out.Controls.Add(this.tb_out_num);
            this.tp_out.Location = new System.Drawing.Point(4, 22);
            this.tp_out.Name = "tp_out";
            this.tp_out.Padding = new System.Windows.Forms.Padding(3);
            this.tp_out.Size = new System.Drawing.Size(768, 400);
            this.tp_out.TabIndex = 2;
            this.tp_out.Text = "出仓管理";
            this.tp_out.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(363, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "出仓";
            // 
            // lbl_user_out
            // 
            this.lbl_user_out.AutoSize = true;
            this.lbl_user_out.Location = new System.Drawing.Point(713, 3);
            this.lbl_user_out.Name = "lbl_user_out";
            this.lbl_user_out.Size = new System.Drawing.Size(29, 12);
            this.lbl_user_out.TabIndex = 16;
            this.lbl_user_out.Text = "未知";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "当前用户：";
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(304, 309);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(152, 29);
            this.btn_out.TabIndex = 8;
            this.btn_out.Text = "出仓";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "备    注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "数    量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "物料代码";
            // 
            // rtb_out_remarks
            // 
            this.rtb_out_remarks.Location = new System.Drawing.Point(368, 170);
            this.rtb_out_remarks.Name = "rtb_out_remarks";
            this.rtb_out_remarks.Size = new System.Drawing.Size(100, 96);
            this.rtb_out_remarks.TabIndex = 7;
            this.rtb_out_remarks.Text = "无";
            // 
            // tb_out_num
            // 
            this.tb_out_num.Location = new System.Drawing.Point(368, 114);
            this.tb_out_num.Name = "tb_out_num";
            this.tb_out_num.Size = new System.Drawing.Size(100, 21);
            this.tb_out_num.TabIndex = 6;
            // 
            // tp_print
            // 
            this.tp_print.Controls.Add(this.lbl_user_print);
            this.tp_print.Controls.Add(this.label12);
            this.tp_print.Controls.Add(this.groupBox1);
            this.tp_print.Controls.Add(this.btn_print);
            this.tp_print.Location = new System.Drawing.Point(4, 22);
            this.tp_print.Name = "tp_print";
            this.tp_print.Padding = new System.Windows.Forms.Padding(3);
            this.tp_print.Size = new System.Drawing.Size(768, 400);
            this.tp_print.TabIndex = 3;
            this.tp_print.Text = "统计打印";
            this.tp_print.UseVisualStyleBackColor = true;
            // 
            // lbl_user_print
            // 
            this.lbl_user_print.AutoSize = true;
            this.lbl_user_print.Location = new System.Drawing.Point(715, 3);
            this.lbl_user_print.Name = "lbl_user_print";
            this.lbl_user_print.Size = new System.Drawing.Size(29, 12);
            this.lbl_user_print.TabIndex = 18;
            this.lbl_user_print.Text = "未知";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(644, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "当前用户：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_out);
            this.groupBox1.Controls.Add(this.rb_in);
            this.groupBox1.Controls.Add(this.rb_ulda);
            this.groupBox1.Location = new System.Drawing.Point(133, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择要打印的项目";
            // 
            // rb_out
            // 
            this.rb_out.AutoSize = true;
            this.rb_out.Location = new System.Drawing.Point(61, 170);
            this.rb_out.Name = "rb_out";
            this.rb_out.Size = new System.Drawing.Size(71, 16);
            this.rb_out.TabIndex = 11;
            this.rb_out.Text = "出仓明细";
            this.rb_out.UseVisualStyleBackColor = true;
            // 
            // rb_in
            // 
            this.rb_in.AutoSize = true;
            this.rb_in.Location = new System.Drawing.Point(61, 130);
            this.rb_in.Name = "rb_in";
            this.rb_in.Size = new System.Drawing.Size(71, 16);
            this.rb_in.TabIndex = 10;
            this.rb_in.Text = "进仓明细";
            this.rb_in.UseVisualStyleBackColor = true;
            // 
            // rb_ulda
            // 
            this.rb_ulda.AutoSize = true;
            this.rb_ulda.Checked = true;
            this.rb_ulda.Location = new System.Drawing.Point(61, 86);
            this.rb_ulda.Name = "rb_ulda";
            this.rb_ulda.Size = new System.Drawing.Size(71, 16);
            this.rb_ulda.TabIndex = 9;
            this.rb_ulda.TabStop = true;
            this.rb_ulda.Text = "物料档案";
            this.rb_ulda.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(441, 172);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 12;
            this.btn_print.Text = "导出";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_user_msg
            // 
            this.lbl_user_msg.AutoSize = true;
            this.lbl_user_msg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_user_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_user_msg.Location = new System.Drawing.Point(180, 180);
            this.lbl_user_msg.Name = "lbl_user_msg";
            this.lbl_user_msg.Size = new System.Drawing.Size(469, 20);
            this.lbl_user_msg.TabIndex = 1;
            this.lbl_user_msg.Text = "您目前没有任何权限，请联系管理员：aolyu@qq.com";
            this.lbl_user_msg.Visible = false;
            // 
            // cb_in
            // 
            this.cb_in.FormattingEnabled = true;
            this.cb_in.Location = new System.Drawing.Point(369, 55);
            this.cb_in.Name = "cb_in";
            this.cb_in.Size = new System.Drawing.Size(100, 20);
            this.cb_in.TabIndex = 20;
            // 
            // cb_out
            // 
            this.cb_out.FormattingEnabled = true;
            this.cb_out.Location = new System.Drawing.Point(368, 63);
            this.cb_out.Name = "cb_out";
            this.cb_out.Size = new System.Drawing.Size(100, 20);
            this.cb_out.TabIndex = 18;
            // 
            // 计算机1702_09223_13222_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_user_msg);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "计算机1702_09223_13222_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算机1702_09223_13222_user";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.计算机1702_09223_13222_user_FormClosed);
            this.Load += new System.EventHandler(this.计算机1702_09223_13222_user_Load);
            this.tp_in.ResumeLayout(false);
            this.tp_in.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_wlda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materials)).EndInit();
            this.tp_out.ResumeLayout(false);
            this.tp_out.PerformLayout();
            this.tp_print.ResumeLayout(false);
            this.tp_print.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tp_in;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_wlda;
        private System.Windows.Forms.DataGridView dgv_materials;
        private System.Windows.Forms.TabPage tp_out;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_in_remarks;
        private System.Windows.Forms.TextBox tb_in_num;
        private System.Windows.Forms.Label lbl_user_out;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_out_remarks;
        private System.Windows.Forms.TextBox tb_out_num;
        private System.Windows.Forms.Label lbl_user_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计量单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.TabPage tp_print;
        private System.Windows.Forms.Label lbl_user_print;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_out;
        private System.Windows.Forms.RadioButton rb_in;
        private System.Windows.Forms.RadioButton rb_ulda;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_user_msg;
        private System.Windows.Forms.ComboBox cb_in;
        private System.Windows.Forms.ComboBox cb_out;
    }
}