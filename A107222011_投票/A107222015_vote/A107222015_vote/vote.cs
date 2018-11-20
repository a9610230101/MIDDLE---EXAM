using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A107222015_vote
{
    //專案: 社團調查及系聯會會長選舉計票系統
    //日期: 2018.11.20
    //姓名: A107222011 林紘毅

    public partial class vote : Form
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        int num7 = 0;
        int num8 = 0;
        int num9 = 0;
        int num10 = 0;
        int num11 = 0;
        int num12 = 0;
        public vote()
        {
            InitializeComponent();
        }
        private void check_Click(object sender, EventArgs e)
        {
            string stdName = name.Text;
            string stdId = "";
            int groupNum = 0;
            string stdGroup = "";
            if (name.Text == "")
            {
                MessageBox.Show("請輸入姓名!!");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    stdId = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    stdId = radioButton2.Text;
                }
                else if (radioButton3.Checked == true)
                {
                    stdId = radioButton3.Text;
                }
                else if (radioButton4.Checked == true)
                {
                    stdId = radioButton4.Text;
                }
                else if (radioButton5.Checked == true)
                {
                    stdId = radioButton5.Text;
                }
                else if (radioButton6.Checked == true)
                {
                    stdId = radioButton6.Text;
                }

                if (checkBox1.Checked == true)
                {
                    groupNum += 1;
                    stdGroup += checkBox1.Text;
                }
                if (checkBox2.Checked == true)
                {
                    groupNum += 1;
                    stdGroup += checkBox2.Text;
                }
                if (checkBox3.Checked == true)
                {
                    groupNum += 1;
                    stdGroup += checkBox3.Text;
                }
                if (checkBox4.Checked == true)
                {
                    groupNum += 1;
                    stdGroup += checkBox4.Text;
                }
                if (checkBox5.Checked == true)
                {
                    groupNum += 1;
                    stdGroup += checkBox5.Text;
                }
                if (checkBox6.Checked == true)
                {
                    groupNum += 1;
                    stdGroup += checkBox6.Text;
                }

                if (groupNum == 1)
                {
                    DialogResult dialogResult1 = MessageBox.Show("姓名:" + stdName + "\n身分:" + stdId + "\n社團:" + stdGroup, "請確認資料是否正確", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        stdData.Items.Add(stdName + ", " + stdId + ", " + stdGroup);
                        name.Text = "";
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                    }
                }
                else if (groupNum == 2)
                {
                    DialogResult dialogResult2 = MessageBox.Show("姓名:" + stdName + "\n身分:" + stdId + "\n社團:" + stdGroup.Substring(0, 3) + ", " + stdGroup.Substring(3, 3), "請確認資料是否正確", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        stdData.Items.Add(stdName + ", " + stdId + ", " + stdGroup);
                        name.Text = "";
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                    }
                }
                else if (groupNum == 3)
                {
                    DialogResult dialogResult3 = MessageBox.Show("姓名:" + stdName + "\n身分:" + stdId + "\n社團:" + stdGroup.Substring(0, 3) + ", " + stdGroup.Substring(3, 3) + ", " + stdGroup.Substring(6, 3), "請確認資料是否正確", MessageBoxButtons.YesNo);
                    if (dialogResult3 == DialogResult.Yes)
                    {
                        stdData.Items.Add(stdName + ", " + stdId + ", " + stdGroup);
                        name.Text = "";
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("至多選擇三個社團!!");
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            status.Items.Clear();
            try
            {
                int voteNum = int.Parse(num.Text);
                num.Text = "";
                if (voteNum > 0 && voteNum <= 12)
                {
                    switch (voteNum)
                    {
                        case 1:
                            num1 += 1;
                            break;
                        case 2:
                            num2 += 1;
                            break;
                        case 3:
                            num3 += 1;
                            break;
                        case 4:
                            num4 += 1;
                            break;
                        case 5:
                            num5 += 1;
                            break;
                        case 6:
                            num6 += 1;
                            break;
                        case 7:
                            num7 += 1;
                            break;
                        case 8:
                            num8 += 1;
                            break;
                        case 9:
                            num9 += 1;
                            break;
                        case 10:
                            num10 += 1;
                            break;
                        case 11:
                            num11 += 1;
                            break;
                        case 12:
                            num12 += 1;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入1~12的整數!!!");
                }
                status.Items.Add("1號候選人: " + num1 + " 票");
                status.Items.Add("2號候選人: " + num2 + " 票");
                status.Items.Add("3號候選人: " + num3 + " 票");
                status.Items.Add("4號候選人: " + num4 + " 票");
                status.Items.Add("5號候選人: " + num5 + " 票");
                status.Items.Add("6號候選人: " + num6 + " 票");
                status.Items.Add("7號候選人: " + num7 + " 票");
                status.Items.Add("8號候選人: " + num8 + " 票");
                status.Items.Add("9號候選人: " + num9 + " 票");
                status.Items.Add("10號候選人: " + num10 + " 票");
                status.Items.Add("11號候選人: " + num11 + " 票");
                status.Items.Add("12號候選人: " + num12 + " 票");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vote_Load(object sender, EventArgs e)
        {

        }
    }
}
