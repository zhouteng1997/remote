﻿namespace 远程控制
{
    partial class Form1
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
            this.Lj = new System.Windows.Forms.Button();
            this.Tj = new System.Windows.Forms.Button();
            this.Bj = new System.Windows.Forms.Button();
            this.Sc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.服务器 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.域名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lj
            // 
            this.Lj.Location = new System.Drawing.Point(781, 463);
            this.Lj.Margin = new System.Windows.Forms.Padding(2);
            this.Lj.Name = "Lj";
            this.Lj.Size = new System.Drawing.Size(60, 29);
            this.Lj.TabIndex = 2;
            this.Lj.Text = "连接";
            this.Lj.UseVisualStyleBackColor = true;
            this.Lj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tj
            // 
            this.Tj.Location = new System.Drawing.Point(21, 18);
            this.Tj.Margin = new System.Windows.Forms.Padding(2);
            this.Tj.Name = "Tj";
            this.Tj.Size = new System.Drawing.Size(55, 26);
            this.Tj.TabIndex = 3;
            this.Tj.Text = "添加";
            this.Tj.UseVisualStyleBackColor = true;
            this.Tj.Click += new System.EventHandler(this.Tj_Click);
            // 
            // Bj
            // 
            this.Bj.Location = new System.Drawing.Point(121, 18);
            this.Bj.Margin = new System.Windows.Forms.Padding(2);
            this.Bj.Name = "Bj";
            this.Bj.Size = new System.Drawing.Size(59, 26);
            this.Bj.TabIndex = 3;
            this.Bj.Text = "编辑";
            this.Bj.UseVisualStyleBackColor = true;
            this.Bj.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sc
            // 
            this.Sc.Location = new System.Drawing.Point(218, 18);
            this.Sc.Margin = new System.Windows.Forms.Padding(2);
            this.Sc.Name = "Sc";
            this.Sc.Size = new System.Drawing.Size(61, 26);
            this.Sc.TabIndex = 3;
            this.Sc.Text = "删除";
            this.Sc.UseVisualStyleBackColor = true;
            this.Sc.Click += new System.EventHandler(this.Sc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.服务器,
            this.域名,
            this.ip,
            this.账号,
            this.密码});
            this.dataGridView1.Location = new System.Drawing.Point(11, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(995, 297);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 386);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "共享磁盘";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(138, 386);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "共享打印机";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(226, 386);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 16);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "共享端口";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // 服务器
            // 
            this.服务器.DataPropertyName = "DesktopName";
            this.服务器.HeaderText = "服务器";
            this.服务器.Name = "服务器";
            this.服务器.ReadOnly = true;
            this.服务器.Width = 200;
            // 
            // 域名
            // 
            this.域名.DataPropertyName = "WWW";
            this.域名.HeaderText = "域名";
            this.域名.Name = "域名";
            this.域名.ReadOnly = true;
            this.域名.Width = 200;
            // 
            // ip
            // 
            this.ip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ip.DataPropertyName = "Server";
            this.ip.HeaderText = "ip";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Width = 200;
            // 
            // 账号
            // 
            this.账号.DataPropertyName = "UserName";
            this.账号.HeaderText = "账号";
            this.账号.Name = "账号";
            this.账号.ReadOnly = true;
            this.账号.Width = 150;
            // 
            // 密码
            // 
            this.密码.DataPropertyName = "Password";
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            this.密码.ReadOnly = true;
            this.密码.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 503);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sc);
            this.Controls.Add(this.Bj);
            this.Controls.Add(this.Tj);
            this.Controls.Add(this.Lj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "远程连接";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Lj;
        private System.Windows.Forms.Button Tj;
        private System.Windows.Forms.Button Bj;
        private System.Windows.Forms.Button Sc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服务器;
        private System.Windows.Forms.DataGridViewTextBoxColumn 域名;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
    }
}

