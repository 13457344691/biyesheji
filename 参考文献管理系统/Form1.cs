using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace 参考文献管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        //----------------------查询MDI子窗体是否存在-----------------------------
        public bool childFraShow(string childName)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.Name == childName)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }
         
       

        private void 参考文献类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 参考文献档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.childFraShow("参考文献档案管理") == true)
            {
                return;
            }
            参考文献档案管理 f2 = new 参考文献档案管理();
            f2.MdiParent = this;
            f2.Show();
            label4.Visible = false;
            pictureBox1.Visible = false;
        }

        private void 出版社管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 参考文献注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      

        private void 参考文献征定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 管理员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 参考文献ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 参考文献管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void 管理员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 读者类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 读者档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 退出系统QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭窗体吗？", "确认", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
                label4.Visible = true;
                pictureBox1.Visible = true;
           }
            else
                e.Cancel = true;
        }

    

      
//-------------------------------日期----------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            toolStripStatusLabel2.Text = time.Year.ToString() + "年" + time.Month.ToString() + "月" + time.Day.ToString() + "日";
            toolStripStatusLabel3.Text = System.DateTime.Now.ToLongTimeString();//  time.Hour.ToString() +"时"+ time.Minute.ToString() +"分"+ time.Second.ToString()+"秒";
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Mp10.ssk";
            this.skinEngine1.Active = true;

            label4.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            音乐ToolStripMenuItem.CheckOnClick = true;
            音乐ToolStripMenuItem.Checked =true;
            this.系统管理ToolStripMenuItem.Enabled = false;
            this.参考文献管理ToolStripMenuItem.Enabled = false;
         
            this.读者管理ToolStripMenuItem.Enabled = false;
            
        }
        public int power;
        private void button1_Click(object sender, EventArgs e)
        {

            sqlConnection1.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入用户名和密码，然后再登录!");
                return;
            }

            string sql = "select 权限 from 管理员信息 where 姓名='" + textBox1.Text.Trim() + "' and 密码='" + textBox2.Text.Trim() + "'";
            SqlCommand mycom = null;
            try
            {
                mycom = new SqlCommand(sql, sqlConnection1);
                SqlDataReader mydr = mycom.ExecuteReader();
                if (mydr.HasRows)
                {
                    mydr.Read();
                    power = Convert.ToInt32(mydr[0]);
                    
                    switch (power)
                    {
                        case 220:
                            this.读者管理ToolStripMenuItem.Enabled = true; break;
                        case 330:
                            this.读者管理ToolStripMenuItem.Enabled = true;
                            this.参考文献管理ToolStripMenuItem.Enabled = true; break;
                        case 110:
                            this.读者管理ToolStripMenuItem.Enabled = true;
                          
                            this.参考文献管理ToolStripMenuItem.Enabled = true;
                            this.系统管理ToolStripMenuItem.Enabled = true; break;

                        default:
                            MessageBox.Show("你没有使使用本系统的权限"); break;
                    }
                    MessageBox.Show("登录成功！");
                    panel1.Hide();
                    label4.Visible = true;
                    pictureBox1.Visible = true;
                  
                    mydr.Close();

                }
                else
                    MessageBox.Show("没有这个用户或密码不正确，请重新登录！");

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message, "错误");
            }

            sqlConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void 音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "D:\\C#\\重要文件\\参考文献管理系统\\参考文献管理系统\\感动天感动地.mp3";
                if (音乐ToolStripMenuItem.Checked == true)
                {
                    axWindowsMediaPlayer2.URL = str;
                }
                else
                    axWindowsMediaPlayer2.URL = "";
            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message, "错误"); 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

       

        

        

      

       
    }
}