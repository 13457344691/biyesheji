using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 参考文献管理系统
{
    public partial class 参考文献档案管理 : Form
    {
        private BindingManagerBase Navigator;
        public 参考文献档案管理()
        {
            InitializeComponent();
        }

        private void 参考文献档案管理_Load(object sender, EventArgs e)
        {
            TextReadOnly(true);
            sqlDataAdapter1.Fill(dataSet11, "参考文献信息");
            Navigator = this.BindingContext[dataSet11, "参考文献信息"];
        }
        //------首记录－－－上一条－－－下一条－－－尾记录---------
        private void button1_Click(object sender, EventArgs e)
        {
            dataGrid1.UnSelect(Navigator.Position);
            Navigator.Position = 0;
            dataGrid1.Select(Navigator.Position);
            dataGrid1.CurrentRowIndex = Navigator.Position;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Navigator.Position != 0)
            {
                dataGrid1.UnSelect(Navigator.Position);
                Navigator.Position--;
                dataGrid1.Select(Navigator.Position);
                dataGrid1.CurrentRowIndex = Navigator.Position;
            }
            else
            {
                dataGrid1.UnSelect(Navigator.Position);
                Navigator.Position=0;
                dataGrid1.Select(Navigator.Position);
                dataGrid1.CurrentRowIndex = Navigator.Position;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Navigator.Position != Navigator.Count-1)
            {
                dataGrid1.UnSelect(Navigator.Position);
                Navigator.Position++;
                dataGrid1.Select(Navigator.Position);
                dataGrid1.CurrentRowIndex = Navigator.Position;
            }
            else
            {
                dataGrid1.UnSelect(Navigator.Position);
                Navigator.Position = Navigator.Count - 1;
                dataGrid1.Select(Navigator.Position);
                dataGrid1.CurrentRowIndex = Navigator.Position;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGrid1.UnSelect(Navigator.Position);
            Navigator.Position = Navigator.Count - 1;
            dataGrid1.Select(Navigator.Position);
            dataGrid1.CurrentRowIndex = Navigator.Position;
        }

//-----------------------------------------------------新增－－修改－－－删除－－－提交－－－取消－－－退出----------------------------------
        public void TextReadOnly(bool A)
        {
            textBox2.ReadOnly = A;
            textBox3.ReadOnly = A;
            textBox4.ReadOnly = A;
            textBox5.ReadOnly = A;
            textBox6.ReadOnly = A;
            textBox7.ReadOnly = A;
            textBox9.ReadOnly = A;
            textBox10.ReadOnly =A;
            textBox11.ReadOnly=A;
            comboBox2.Enabled = !A;
            comboBox3.Enabled = !A;
        }
        public void SetValue()
        {
            sqlConnection1.Open();
            SqlCommand com = new SqlCommand("select max(编号) as 最大编号 from 参考文献信息", sqlConnection1);
            int maxID = 1;
            object result = com.ExecuteScalar();
            if (result != System.DBNull.Value)
            {
                maxID = Convert.ToInt32(result) + 1;
            }
            int length=maxID.ToString().Length;
            switch (length)
            {
                case 1:
                    textBox3.Text = "000000" + maxID.ToString();
                    break;
                case 2:
                    textBox3.Text = "00000" + maxID.ToString();
                    break;
                case 3:
                    textBox3.Text = "0000" + maxID.ToString();
                    break;
                case 4:
                    textBox3.Text = "000" + maxID.ToString();
                    break;
                case 5:
                    textBox3.Text = "00" + maxID.ToString();
                    break;
                case 6:
                    textBox3.Text = "0" + maxID.ToString();
                    break;
                case 7:
                    textBox3.Text = maxID.ToString();
                    break;
            }
            sqlConnection1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Navigator.AddNew();
            SetValue();
            TextReadOnly(false);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除吗？", "删除数据", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (Navigator.Count > 0)
                {
                    Navigator.RemoveAt(Navigator.Position);
                    sqlDataAdapter1.Update(dataSet11, "参考文献信息");
                }
            }
            else
                MessageBox.Show("无删除数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextReadOnly(false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Navigator.CancelCurrentEdit();
            TextReadOnly(true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox3.Text==""||textBox4.Text==""||comboBox2.Text==""||comboBox3.Text=="")
            {
                MessageBox.Show("编号，书名，类型和书架是必填字段！请填写完整！","提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Navigator.EndCurrentEdit();
            if (dataSet11.GetChanges() != null)
            {
                sqlDataAdapter1.Update(dataSet11, "参考文献信息");
                TextReadOnly(true);
            }
            return;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//------------------------------------------------------------------－－－－--［搜索］－－－－－－－－－－－－－－－－－－－－－－－
        private void button10_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            string str="";
            if (comboBox4.Text == "模糊")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        str = "select * from 参考文献信息";
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        str = "select * from 参考文献信息 where "+comboBox1.Text+" like '%" + textBox1.Text + "%'";
                        break;
                    default:
                        str = "select * from 参考文献信息";
                        break;
                }
            }
            else
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        str = "select * from 参考文献信息";
                        break;
                    case 1: case 2: case 3: case 4:case 5: case 6:case 7: case 8: 
                        str = "select * from 参考文献信息 where " + comboBox1.Text + " ='" + textBox1.Text + "'";
                        break;
                    default:
                        str = "select * from 参考文献信息";
                        break;
                }
            }
            SqlDataAdapter myda = new SqlDataAdapter(str, sqlConnection1);
            dataSet11.Clear();
            myda.Fill(dataSet11, "参考文献信息");
            sqlConnection1.Close();
        }
        public static string shuJiaName, leiXing;
        private void comboBox3_DropDown(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
           
        }

    }
}