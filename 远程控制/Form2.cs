using Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 远程控制
{
    public partial class Form2 : Form
    {
        public Form2(RemoteMachine remoteMachine)
        {
            InitializeComponent();
            textBox1.Text = remoteMachine.DesktopName;
            textBox1.Enabled = false;
            textBox2.Text = remoteMachine.WWW;
            textBox3.Text = remoteMachine.Server;
            textBox4.Text = remoteMachine.UserName;
            textBox5.Text = remoteMachine.Password;
        }

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 操作成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "config.ini"));
                RemoteMachine remoteMachine = new RemoteMachine();
                remoteMachine.DesktopName = textBox1.Text;
                remoteMachine.WWW = textBox2.Text;
                remoteMachine.Server = textBox3.Text;
                remoteMachine.UserName = textBox4.Text;
                remoteMachine.Password = textBox5.Text;
                RemoteMachine.Save(remoteMachine, iniFile);
                MessageBox.Show("操作成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       //private void button2_Click(object sender, EventArgs e)
       // {
       //     try
       //     {
       //         IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "config.ini"));
       //         RemoteMachine remoteMachine = new RemoteMachine();
       //         remoteMachine.DesktopName = textBox1.Text;
       //         remoteMachine.WWW = textBox2.Text;
       //         remoteMachine.Server = textBox3.Text;
       //         remoteMachine.UserName = textBox4.Text;
       //         remoteMachine.Password = textBox5.Text;
       //         RemoteMachine.Save(remoteMachine, iniFile);
       //         MessageBox.Show("添加成功");
       //     }
       //     catch (Exception ex)
       //     {
       //         MessageBox.Show(ex.ToString());
       //     }
       //     this.DialogResult = DialogResult.OK;
       //     this.Close();
       // }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
