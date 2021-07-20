using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point _startPoint;


        private void Form1_Load(object sender, EventArgs e)
        {
            this._startPoint = this.label7.Location;

        }
#region "設定radioButton 並需要設定依期間的選單不顯示與顯示"

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {//如果按鈕選擇依期間 則顯示選擇日期
            label5.Visible = true;
            label6.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {//如果按鈕選擇全年度 則不顯示選擇日期
            label5.Visible = false;
            label6.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }
        #endregion

#region "設定combox1值改變後,comboBox的CC數也會跟連動"


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//選擇用途
        {
            comboBox2.Items.Clear();//選擇用途之後將汽缸CC數的選項清空
            comboBox2.Text = "";
            if (comboBox1.SelectedItem.ToString() == "機車")
            {
                comboBox2.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                comboBox2.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                comboBox2.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                comboBox2.Items.Add("501-600");
                comboBox2.Items.Add("601-1200");
                comboBox2.Items.Add("1201-1800");
                comboBox2.Items.Add("1801或以上");
            }//將所有機車CC數選項放進去
            if (comboBox1.SelectedItem.ToString() == "貨車")
            {
                comboBox2.Items.Add("500以下");
                comboBox2.Items.Add("501-600");
                comboBox2.Items.Add("601-1200");
                comboBox2.Items.Add("1201-1800");
                comboBox2.Items.Add("1801-2400");
                comboBox2.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                comboBox2.Items.Add("3001-3600");
                comboBox2.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                comboBox2.Items.Add("4201-4800");
                comboBox2.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                comboBox2.Items.Add("5401-6000");
                comboBox2.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                comboBox2.Items.Add("6601-7200");
                comboBox2.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                comboBox2.Items.Add("7801-8400");
                comboBox2.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                comboBox2.Items.Add("9001-9600");
                comboBox2.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                comboBox2.Items.Add("10201以上");
            }//同上
            if (comboBox1.SelectedItem.ToString() == "大客車")
            {
                comboBox2.Items.Add("600以下");
                comboBox2.Items.Add("601-1200");
                comboBox2.Items.Add("1201-1800");
                comboBox2.Items.Add("1801-2400");
                comboBox2.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                comboBox2.Items.Add("3001-3600");
                comboBox2.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                comboBox2.Items.Add("4201-4800");
                comboBox2.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                comboBox2.Items.Add("5401-6000");
                comboBox2.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                comboBox2.Items.Add("6601-7200");
                comboBox2.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                comboBox2.Items.Add("7801-8400");
                comboBox2.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                comboBox2.Items.Add("9001-9600");
                comboBox2.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                comboBox2.Items.Add("10201以上");
            }//同上
            if (comboBox1.SelectedItem.ToString() == "自用小客車")
            {
                comboBox2.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                comboBox2.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                comboBox2.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                comboBox2.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                comboBox2.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                comboBox2.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                comboBox2.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                comboBox2.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                comboBox2.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                comboBox2.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                comboBox2.Items.Add("7801以上");
            }//同上
            if (comboBox1.SelectedItem.ToString() == "營業用小客車")
            {
                comboBox2.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                comboBox2.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                comboBox2.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                comboBox2.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                comboBox2.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                comboBox2.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                comboBox2.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                comboBox2.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                comboBox2.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                comboBox2.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                comboBox2.Items.Add("7801以上");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //沒有作用
        }
#endregion

#region "設定取消重填按鈕,清除所有選項"

        private void button2_Click(object sender, EventArgs e)
        {//清除所有已經選擇的選項
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            label7.Text = "";
            comboBox2.Items.Clear();
            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
        }
#endregion

#region"設定確認送出按鈕,這裡處理分類為無跨年度,有跨年度(程式長慎入)
        private void button1_Click(object sender, EventArgs e)   
        {
            int ansss = 0;//計算是否有錯誤,若計算錯誤以視窗提醒
            if (dateTimePicker1.Value.Year == dateTimePicker2.Value.Year && dateTimePicker1.Value.Month == dateTimePicker2.Value.Month && dateTimePicker1.Value.Day == dateTimePicker2.Value.Day && radioButton2.Checked == true)
            {
                MessageBox.Show("請選擇日期!");//沒輸入日期
                ansss++;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("請選擇用途!");//沒輸入用途
                ansss++;
            }
            else
            {
                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("請選擇CC數!");//沒輸入CC數
                    ansss++;
                }
            }
            if (ansss == 0)   //此處若計算正確的話
            {
                int loop = 1;//要輪迴幾次
                int leapyear = 0;//閏年
                if (radioButton2.Checked == true) loop += dateTimePicker2.Value.Year - dateTimePicker1.Value.Year;//如果依期間有跨年度
                if (loop == 1)//年度沒有跨越 (如2021-2021)
                {
                    TimeSpan time = new TimeSpan(dateTimePicker2.Value.Ticks - dateTimePicker1.Value.Ticks);//相差天數
                    int totalday = time.Days + 1;//計算天數
                    if (radioButton1.Checked == true)//如果是全年度
                    {
                        totalday = 365;
                    }
                    int g = 0;//存取CC數所選選項的金額
                    if (comboBox1.SelectedItem.ToString() == "機車")
                    {
                        if (comboBox2.SelectedIndex == 0)//150
                        {
                            g = 0;
                        }
                        if (comboBox2.SelectedIndex == 1)//150
                        {
                            g = 800;
                        }
                        if (comboBox2.SelectedIndex == 2)//150
                        {
                            g = 1620;
                        }
                        if (comboBox2.SelectedIndex == 3)//150
                        {
                            g = 2160;
                        }
                        if (comboBox2.SelectedIndex == 4)//150
                        {
                            g = 4320;
                        }
                        if (comboBox2.SelectedIndex == 5)//150
                        {
                            g = 7120;
                        }
                        if (comboBox2.SelectedIndex == 6)//150
                        {
                            g = 11230;
                        }
                    }//CC數選擇
                    if (comboBox1.SelectedItem.ToString() == "貨車")
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            g = 900;
                        }
                        if (comboBox2.SelectedIndex == 1)
                        {
                            g = 1080;
                        }
                        if (comboBox2.SelectedIndex == 2)
                        {
                            g = 1800;
                        }
                        if (comboBox2.SelectedIndex == 3)
                        {
                            g = 2700;
                        }
                        if (comboBox2.SelectedIndex == 4)
                        {
                            g = 3600;
                        }
                        if (comboBox2.SelectedIndex == 5)
                        {
                            g = 4500;
                        }
                        if (comboBox2.SelectedIndex == 6)
                        {
                            g = 5400;
                        }
                        if (comboBox2.SelectedIndex == 7)
                        {
                            g = 6300;
                        }
                        if (comboBox2.SelectedIndex == 8)
                        {
                            g = 7200;
                        }
                        if (comboBox2.SelectedIndex == 9)
                        {
                            g = 8100;
                        }
                        if (comboBox2.SelectedIndex == 10)
                        {
                            g = 9000;
                        }
                        if (comboBox2.SelectedIndex == 11)
                        {
                            g = 9900;
                        }
                        if (comboBox2.SelectedIndex == 12)
                        {
                            g = 10800;
                        }
                        if (comboBox2.SelectedIndex == 13)
                        {
                            g = 11700;
                        }
                        if (comboBox2.SelectedIndex == 14)
                        {
                            g = 12600;
                        }
                        if (comboBox2.SelectedIndex == 15)
                        {
                            g = 13500;
                        }
                        if (comboBox2.SelectedIndex == 16)
                        {
                            g = 14400;
                        }
                        if (comboBox2.SelectedIndex == 17)
                        {
                            g = 15300;
                        }
                        if (comboBox2.SelectedIndex == 18)
                        {
                            g = 16200;
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "大客車")
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            g = 1080;
                        }
                        if (comboBox2.SelectedIndex == 1)
                        {
                            g = 1800;
                        }
                        if (comboBox2.SelectedIndex == 2)
                        {
                            g = 2700;
                        }
                        if (comboBox2.SelectedIndex == 3)
                        {
                            g = 3600;
                        }
                        if (comboBox2.SelectedIndex == 4)
                        {
                            g = 4500;
                        }
                        if (comboBox2.SelectedIndex == 5)
                        {
                            g = 5400;
                        }
                        if (comboBox2.SelectedIndex == 6)
                        {
                            g = 6300;
                        }
                        if (comboBox2.SelectedIndex == 7)
                        {
                            g = 7200;
                        }
                        if (comboBox2.SelectedIndex == 8)
                        {
                            g = 8100;
                        }
                        if (comboBox2.SelectedIndex == 9)
                        {
                            g = 9000;
                        }
                        if (comboBox2.SelectedIndex == 10)
                        {
                            g = 9900;
                        }
                        if (comboBox2.SelectedIndex == 11)
                        {
                            g = 10800;
                        }
                        if (comboBox2.SelectedIndex == 12)
                        {
                            g = 11700;
                        }
                        if (comboBox2.SelectedIndex == 13)
                        {
                            g = 12600;
                        }
                        if (comboBox2.SelectedIndex == 14)
                        {
                            g = 13500;
                        }
                        if (comboBox2.SelectedIndex == 15)
                        {
                            g = 14400;
                        }
                        if (comboBox2.SelectedIndex == 16)
                        {
                            g = 15300;
                        }
                        if (comboBox2.SelectedIndex == 17)
                        {
                            g = 16200;
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "自用小客車")
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            g = 1620;
                        }
                        if (comboBox2.SelectedIndex == 1)
                        {
                            g = 2160;
                        }
                        if (comboBox2.SelectedIndex == 2)
                        {
                            g = 4320;
                        }
                        if (comboBox2.SelectedIndex == 3)
                        {
                            g = 7120;
                        }
                        if (comboBox2.SelectedIndex == 4)
                        {
                            g = 11230;
                        }
                        if (comboBox2.SelectedIndex == 5)
                        {
                            g = 15210;
                        }
                        if (comboBox2.SelectedIndex == 6)
                        {
                            g = 28220;
                        }
                        if (comboBox2.SelectedIndex == 7)
                        {
                            g = 46170;
                        }
                        if (comboBox2.SelectedIndex == 8)
                        {
                            g = 69690;
                        }
                        if (comboBox2.SelectedIndex == 9)
                        {
                            g = 117000;
                        }
                        if (comboBox2.SelectedIndex == 10)
                        {
                            g = 151200;
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "營業用小客車")
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            g = 900;
                        }
                        if (comboBox2.SelectedIndex == 1)
                        {
                            g = 1260;
                        }
                        if (comboBox2.SelectedIndex == 2)
                        {
                            g = 2160;
                        }
                        if (comboBox2.SelectedIndex == 3)
                        {
                            g = 3060;
                        }
                        if (comboBox2.SelectedIndex == 4)
                        {
                            g = 6480;
                        }
                        if (comboBox2.SelectedIndex == 5)
                        {
                            g = 9900;
                        }
                        if (comboBox2.SelectedIndex == 6)
                        {
                            g = 16380;
                        }
                        if (comboBox2.SelectedIndex == 7)
                        {
                            g = 24300;
                        }
                        if (comboBox2.SelectedIndex == 8)
                        {
                            g = 33660;
                        }
                        if (comboBox2.SelectedIndex == 9)
                        {
                            g = 44460;
                        }
                        if (comboBox2.SelectedIndex == 10)
                        {
                            g = 56700;
                        }
                    }
                    int count = g * totalday / 365;//計算今天全年度的公式
                    if (radioButton1.Checked == true)//如果是全年度的話 就會是2021/1/1~2021/12/31
                    {
                        label7.Text += $"使用期間:{dateTimePicker1.Value.Year - 1911}/01/01 ~ {dateTimePicker1.Value.Year - 1911}/12/31\r\n";
                    }
                    else//如果不是
                    {
                        label7.Text += $"使用期間:{dateTimePicker1.Value.Year - 1911}/{dateTimePicker1.Value.Month}/{dateTimePicker1.Value.Day}~{dateTimePicker2.Value.Year - 1911}/{dateTimePicker2.Value.Month}/{dateTimePicker2.Value.Day}\r\n";
                    }
                    label7.Text += $"計算天數:{totalday}天\r\n";//計算天數輸出
                    label7.Text += $"汽缸CC數:{comboBox2.SelectedItem}\r\n";//汽缸數輸出
                    label7.Text += $"用途:{comboBox1.SelectedItem}\r\n";//用途輸出
                    if (leapyear != 0)//如果是閏年
                    {
                        label7.Text += $"計算公式: {g}*{totalday}/366 = {count}元\r\n";//輸出閏年的計算公式
                        leapyear--;
                    }
                    else//如果不是閏年
                    {
                        label7.Text += $"計算公式: {g}*{totalday}/365 = {count}元\r\n";
                    }
                    label7.Text += $"應納稅額:共{count}元\r\n";//輸出應納稅額的金額
                }
                else if (loop == 2)//如果只有跨一個年
                {
                    int allcount = 0;//跨一年總計
                    int round = 0;//因為有跨年所以有分上下年
                    DateTimePicker aa = new DateTimePicker();//設置尾picker1年的最後一天12/31
                    DateTimePicker bb = new DateTimePicker();//設置picker2年的第一天1/1
                    aa.Value = new DateTime(dateTimePicker1.Value.Year, 12, 31, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);//設置尾picker1年的最後一天12/31
                    bb.Value = new DateTime(dateTimePicker2.Value.Year, 1, 1, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);//設置picker2年的第一天1/1
                    while (loop != 0)//執行次數
                    {
                        TimeSpan time = new TimeSpan();//先宣告天數差的差異
                        if (round == 0)
                        {
                            time = new TimeSpan(aa.Value.Ticks - dateTimePicker1.Value.Ticks);//天數差異 (例如 2020/12/31-2020/12/1 的差異)
                        }
                        else
                        {
                            time = new TimeSpan(dateTimePicker2.Value.Ticks - bb.Value.Ticks);//天數差異 (同上 但是 2021/1/31 - 2021/1/1)
                        }
                        int totalday = time.Days + 1;//計算天數
                        int g = 0;//存取CC數所選選項的金額
                        if (comboBox1.SelectedItem.ToString() == "機車")
                        {
                            if (comboBox2.SelectedIndex == 0)//150
                            {
                                g = 0;
                            }
                            if (comboBox2.SelectedIndex == 1)//150
                            {
                                g = 800;
                            }
                            if (comboBox2.SelectedIndex == 2)//150
                            {
                                g = 1620;
                            }
                            if (comboBox2.SelectedIndex == 3)//150
                            {
                                g = 2160;
                            }
                            if (comboBox2.SelectedIndex == 4)//150
                            {
                                g = 4320;
                            }
                            if (comboBox2.SelectedIndex == 5)//150
                            {
                                g = 7120;
                            }
                            if (comboBox2.SelectedIndex == 6)//150
                            {
                                g = 11230;
                            }
                        }//CC數選擇
                        if (comboBox1.SelectedItem.ToString() == "貨車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 900;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 1080;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 1800;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 2700;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 3600;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 4500;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 5400;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 6300;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 7200;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 8100;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 9000;
                            }
                            if (comboBox2.SelectedIndex == 11)
                            {
                                g = 9900;
                            }
                            if (comboBox2.SelectedIndex == 12)
                            {
                                g = 10800;
                            }
                            if (comboBox2.SelectedIndex == 13)
                            {
                                g = 11700;
                            }
                            if (comboBox2.SelectedIndex == 14)
                            {
                                g = 12600;
                            }
                            if (comboBox2.SelectedIndex == 15)
                            {
                                g = 13500;
                            }
                            if (comboBox2.SelectedIndex == 16)
                            {
                                g = 14400;
                            }
                            if (comboBox2.SelectedIndex == 17)
                            {
                                g = 15300;
                            }
                            if (comboBox2.SelectedIndex == 18)
                            {
                                g = 16200;
                            }
                        }//同上
                        if (comboBox1.SelectedItem.ToString() == "大客車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 1080;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 1800;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 2700;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 3600;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 4500;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 5400;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 6300;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 7200;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 8100;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 9000;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 9900;
                            }
                            if (comboBox2.SelectedIndex == 11)
                            {
                                g = 10800;
                            }
                            if (comboBox2.SelectedIndex == 12)
                            {
                                g = 11700;
                            }
                            if (comboBox2.SelectedIndex == 13)
                            {
                                g = 12600;
                            }
                            if (comboBox2.SelectedIndex == 14)
                            {
                                g = 13500;
                            }
                            if (comboBox2.SelectedIndex == 15)
                            {
                                g = 14400;
                            }
                            if (comboBox2.SelectedIndex == 16)
                            {
                                g = 15300;
                            }
                            if (comboBox2.SelectedIndex == 17)
                            {
                                g = 16200;
                            }
                        }//同上
                        if (comboBox1.SelectedItem.ToString() == "自用小客車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 1620;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 2160;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 4320;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 7120;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 11230;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 15210;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 28220;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 46170;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 69690;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 117000;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 151200;
                            }
                        }//同上
                        if (comboBox1.SelectedItem.ToString() == "營業用小客車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 900;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 1260;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 2160;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 3060;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 6480;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 9900;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 16380;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 24300;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 33660;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 44460;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 56700;
                            }
                        }//同上
                        int count = 0;//計算金額
                        if (round == 0)//因為第一次跟第二次不同 所以分開判斷是否為閏年
                        {
                            if (DateTime.IsLeapYear(dateTimePicker1.Value.Year))
                            {
                                count = g * totalday / 366;//計算公式(閏年)
                                leapyear++;
                            }
                            else
                            {
                                count = g * totalday / 365;//非閏年
                            }
                        }
                        else//因為第一次跟第二次不同 所以分開判斷是否為閏年
                        {
                            if (DateTime.IsLeapYear(dateTimePicker2.Value.Year))
                            {
                                count = g * totalday / 366;//計算公式(閏年)
                                leapyear++;
                            }
                            else
                            {
                                count = g * totalday / 365;//非閏年
                            }
                        }
                        if (radioButton1.Checked == true)//這是如果是全年度的話 會執行的
                        {
                            label7.Text += $"使用期間:{dateTimePicker1.Value.Year - 1911}/01/01 ~ {dateTimePicker1.Value.Year - 1911}/12/31\r\n";
                        }
                        else//如果不是全年度
                        {
                            if (round == 0)//第一次
                            {
                                label7.Text += $"使用期間:{dateTimePicker1.Value.Year - 1911}/{dateTimePicker1.Value.Month}/{dateTimePicker1.Value.Day}~{aa.Value.Year - 1911}/{aa.Value.Month}/{aa.Value.Day}\r\n";//輸出使用期間
                                round++;
                            }
                            else//第二次
                            {
                                label7.Text += $"使用期間:{bb.Value.Year - 1911}/{bb.Value.Month}/{bb.Value.Day}~{dateTimePicker2.Value.Year - 1911}/{dateTimePicker2.Value.Month}/{dateTimePicker2.Value.Day}\r\n";
                            }
                        }
                        label7.Text += $"計算天數:{totalday}天\r\n";//同全年度的輸出
                        label7.Text += $"汽缸CC數:{comboBox2.SelectedItem}\r\n";//同全年度的輸出
                        label7.Text += $"用途:{comboBox1.SelectedItem}\r\n";//同全年度的輸出
                        if (leapyear != 0)
                        {
                            label7.Text += $"計算公式: {g}*{totalday}/366 = {count}元\r\n";//同全年度的輸出
                            leapyear--;
                        }
                        else
                        {
                            label7.Text += $"計算公式: {g}*{totalday}/365 = {count}元\r\n";//同全年度的輸出
                        }
                        label7.Text += $"應納稅額:共{count}元\r\n";//同全年度的輸出
                        label7.Text += "\r\n";//同全年度的輸出
                        loop--;//因為有兩個年 所以執行兩次(2-1 1-1 最後0跳出)
                        allcount += count;//總計金額
                    }
                    label7.Text += $"全部應納稅額: 共 {allcount} 元";//輸出兩年度總計金額
                }
                else//如果跨不只一年
                {
                    int allcount = 0;//跨每年總計
                    int round = 0;//因為有跨年所以有分上下年
                    DateTimePicker aa = new DateTimePicker();//設置尾picker1年的最後一天12/31
                    DateTimePicker bb = new DateTimePicker();//設置picker2年的第一天1/1
                    aa.Value = new DateTime(dateTimePicker1.Value.Year, 12, 31, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);
                    bb.Value = new DateTime(dateTimePicker2.Value.Year, 1, 1, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
                    DateTimePicker cc = new DateTimePicker();//設置中間全年的????/1/1
                    DateTimePicker dd = new DateTimePicker();//設置中間全年的????/12/31

                    int qqq = loop - 2;//中間全年要出現的次數
                    loop -= qqq;//上下兩次都要輸出
                    int qqw = 0;//第一次執行完執行中間全年的
                    while (loop != 0)
                    {
                        TimeSpan time = new TimeSpan();//宣告天數差異
                        if (round == 0)
                        {
                            time = new TimeSpan(aa.Value.Ticks - dateTimePicker1.Value.Ticks);//天數差異 (例如 2020/12/31-2020/12/1 的差異)
                        }
                        else
                        {
                            time = new TimeSpan(dateTimePicker2.Value.Ticks - bb.Value.Ticks);//天數差異 (同上 但是 2021/1/31 - 2021/1/1)
                        }
                        int totalday = time.Days + 1;//計算天數
                        int g = 0;//CC數的金額
                        if (comboBox1.SelectedItem.ToString() == "機車")
                        {
                            if (comboBox2.SelectedIndex == 0)//150
                            {
                                g = 0;
                            }
                            if (comboBox2.SelectedIndex == 1)//150
                            {
                                g = 800;
                            }
                            if (comboBox2.SelectedIndex == 2)//150
                            {
                                g = 1620;
                            }
                            if (comboBox2.SelectedIndex == 3)//150
                            {
                                g = 2160;
                            }
                            if (comboBox2.SelectedIndex == 4)//150
                            {
                                g = 4320;
                            }
                            if (comboBox2.SelectedIndex == 5)//150
                            {
                                g = 7120;
                            }
                            if (comboBox2.SelectedIndex == 6)//150
                            {
                                g = 11230;
                            }
                        }
                        if (comboBox1.SelectedItem.ToString() == "貨車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 900;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 1080;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 1800;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 2700;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 3600;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 4500;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 5400;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 6300;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 7200;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 8100;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 9000;
                            }
                            if (comboBox2.SelectedIndex == 11)
                            {
                                g = 9900;
                            }
                            if (comboBox2.SelectedIndex == 12)
                            {
                                g = 10800;
                            }
                            if (comboBox2.SelectedIndex == 13)
                            {
                                g = 11700;
                            }
                            if (comboBox2.SelectedIndex == 14)
                            {
                                g = 12600;
                            }
                            if (comboBox2.SelectedIndex == 15)
                            {
                                g = 13500;
                            }
                            if (comboBox2.SelectedIndex == 16)
                            {
                                g = 14400;
                            }
                            if (comboBox2.SelectedIndex == 17)
                            {
                                g = 15300;
                            }
                            if (comboBox2.SelectedIndex == 18)
                            {
                                g = 16200;
                            }
                        }
                        if (comboBox1.SelectedItem.ToString() == "大客車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 1080;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 1800;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 2700;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 3600;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 4500;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 5400;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 6300;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 7200;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 8100;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 9000;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 9900;
                            }
                            if (comboBox2.SelectedIndex == 11)
                            {
                                g = 10800;
                            }
                            if (comboBox2.SelectedIndex == 12)
                            {
                                g = 11700;
                            }
                            if (comboBox2.SelectedIndex == 13)
                            {
                                g = 12600;
                            }
                            if (comboBox2.SelectedIndex == 14)
                            {
                                g = 13500;
                            }
                            if (comboBox2.SelectedIndex == 15)
                            {
                                g = 14400;
                            }
                            if (comboBox2.SelectedIndex == 16)
                            {
                                g = 15300;
                            }
                            if (comboBox2.SelectedIndex == 17)
                            {
                                g = 16200;
                            }
                        }
                        if (comboBox1.SelectedItem.ToString() == "自用小客車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 1620;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 2160;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 4320;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 7120;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 11230;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 15210;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 28220;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 46170;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 69690;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 117000;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 151200;
                            }
                        }
                        if (comboBox1.SelectedItem.ToString() == "營業用小客車")
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                g = 900;
                            }
                            if (comboBox2.SelectedIndex == 1)
                            {
                                g = 1260;
                            }
                            if (comboBox2.SelectedIndex == 2)
                            {
                                g = 2160;
                            }
                            if (comboBox2.SelectedIndex == 3)
                            {
                                g = 3060;
                            }
                            if (comboBox2.SelectedIndex == 4)
                            {
                                g = 6480;
                            }
                            if (comboBox2.SelectedIndex == 5)
                            {
                                g = 9900;
                            }
                            if (comboBox2.SelectedIndex == 6)
                            {
                                g = 16380;
                            }
                            if (comboBox2.SelectedIndex == 7)
                            {
                                g = 24300;
                            }
                            if (comboBox2.SelectedIndex == 8)
                            {
                                g = 33660;
                            }
                            if (comboBox2.SelectedIndex == 9)
                            {
                                g = 44460;
                            }
                            if (comboBox2.SelectedIndex == 10)
                            {
                                g = 56700;
                            }
                        }
                        int count = 0;//計算金額
                        if (round == 0)//第一次
                        {
                            if (DateTime.IsLeapYear(dateTimePicker1.Value.Year))
                            {
                                count = g * totalday / 366;//計算公式(閏年)
                                leapyear++;
                            }
                            else
                            {
                                count = g * totalday / 365;//計算公式(非閏年)
                            }
                        }
                        else//第二次
                        {
                            if (DateTime.IsLeapYear(dateTimePicker2.Value.Year))
                            {
                                count = g * totalday / 366;//計算公式(閏年)
                                leapyear++;
                            }
                            else
                            {
                                count = g * totalday / 365;//計算公式(非閏年);
                            }
                        }
                        if (radioButton1.Checked == true)//這是如果是全年度的話 會執行的
                        {  //以下-1911來處理民國輸出
                            label7.Text += $"使用期間:{dateTimePicker1.Value.Year - 1911}/01/01 ~ {dateTimePicker1.Value.Year - 1911}/12/31\r\n";
                        }
                        else//正常都會跳到這
                        {
                            if (round == 0)//第一次
                            {
                                label7.Text += $"使用期間:{dateTimePicker1.Value.Year - 1911}/{dateTimePicker1.Value.Month}/{dateTimePicker1.Value.Day}~{aa.Value.Year - 1911}/{aa.Value.Month}/{aa.Value.Day}\r\n";//輸出使用期間
                                round++;
                            }
                            else//第二次
                            {
                                label7.Text += $"使用期間:{bb.Value.Year - 1911}/{bb.Value.Month}/{bb.Value.Day}~{dateTimePicker2.Value.Year - 1911}/{dateTimePicker2.Value.Month}/{dateTimePicker2.Value.Day}\r\n";//輸出使用期間
                            }
                        }
                        label7.Text += $"計算天數:{totalday}天\r\n";//同上
                        label7.Text += $"汽缸CC數:{comboBox2.SelectedItem}\r\n";//同上
                        label7.Text += $"用途:{comboBox1.SelectedItem}\r\n";//同上
                        if (leapyear != 0)//是否為閏年
                        {
                            label7.Text += $"計算公式: {g}*{totalday}/366 = {count}元\r\n";//同上
                            leapyear--;
                        }
                        else
                        {
                            label7.Text += $"計算公式: {g}*{totalday}/365 = {count}元\r\n";//同上
                        }
                        label7.Text += $"應納稅額:共{count}元\r\n";//同上
                        label7.Text += "\r\n";//同上
                        loop--;
                        qqw++;//這裡是判斷中間一整年的
                        allcount += count;
                        if (qqw == 1)
                        {
                            for (int i = 1; i < qqq + 1; i++)//中間有幾年就輸出幾次幾年的全年度 (以下程式都跟全年度的相同)
                            {
                                cc.Value = new DateTime(dateTimePicker1.Value.Year + i, 1, 1);//設定XXXX/1/1
                                dd.Value = new DateTime(dateTimePicker1.Value.Year + i, 12, 31);//設定XXXX/12/31
                                time = new TimeSpan(dd.Value.Ticks - cc.Value.Ticks);//使用期間
                                totalday = time.Days + 1;//計算天數
                                if (radioButton1.Checked == true)//如果是全年度
                                {
                                    totalday = 365;
                                }
                                g = 0;//判斷CC數金額
                                if (comboBox1.SelectedItem.ToString() == "機車")
                                {
                                    if (comboBox2.SelectedIndex == 0)//150
                                    {
                                        g = 0;
                                    }
                                    if (comboBox2.SelectedIndex == 1)//150
                                    {
                                        g = 800;
                                    }
                                    if (comboBox2.SelectedIndex == 2)//150
                                    {
                                        g = 1620;
                                    }
                                    if (comboBox2.SelectedIndex == 3)//150
                                    {
                                        g = 2160;
                                    }
                                    if (comboBox2.SelectedIndex == 4)//150
                                    {
                                        g = 4320;
                                    }
                                    if (comboBox2.SelectedIndex == 5)//150
                                    {
                                        g = 7120;
                                    }
                                    if (comboBox2.SelectedIndex == 6)//150
                                    {
                                        g = 11230;
                                    }
                                }
                                if (comboBox1.SelectedItem.ToString() == "貨車")
                                {
                                    if (comboBox2.SelectedIndex == 0)
                                    {
                                        g = 900;
                                    }
                                    if (comboBox2.SelectedIndex == 1)
                                    {
                                        g = 1080;
                                    }
                                    if (comboBox2.SelectedIndex == 2)
                                    {
                                        g = 1800;
                                    }
                                    if (comboBox2.SelectedIndex == 3)
                                    {
                                        g = 2700;
                                    }
                                    if (comboBox2.SelectedIndex == 4)
                                    {
                                        g = 3600;
                                    }
                                    if (comboBox2.SelectedIndex == 5)
                                    {
                                        g = 4500;
                                    }
                                    if (comboBox2.SelectedIndex == 6)
                                    {
                                        g = 5400;
                                    }
                                    if (comboBox2.SelectedIndex == 7)
                                    {
                                        g = 6300;
                                    }
                                    if (comboBox2.SelectedIndex == 8)
                                    {
                                        g = 7200;
                                    }
                                    if (comboBox2.SelectedIndex == 9)
                                    {
                                        g = 8100;
                                    }
                                    if (comboBox2.SelectedIndex == 10)
                                    {
                                        g = 9000;
                                    }
                                    if (comboBox2.SelectedIndex == 11)
                                    {
                                        g = 9900;
                                    }
                                    if (comboBox2.SelectedIndex == 12)
                                    {
                                        g = 10800;
                                    }
                                    if (comboBox2.SelectedIndex == 13)
                                    {
                                        g = 11700;
                                    }
                                    if (comboBox2.SelectedIndex == 14)
                                    {
                                        g = 12600;
                                    }
                                    if (comboBox2.SelectedIndex == 15)
                                    {
                                        g = 13500;
                                    }
                                    if (comboBox2.SelectedIndex == 16)
                                    {
                                        g = 14400;
                                    }
                                    if (comboBox2.SelectedIndex == 17)
                                    {
                                        g = 15300;
                                    }
                                    if (comboBox2.SelectedIndex == 18)
                                    {
                                        g = 16200;
                                    }
                                }
                                if (comboBox1.SelectedItem.ToString() == "大客車")
                                {
                                    if (comboBox2.SelectedIndex == 0)
                                    {
                                        g = 1080;
                                    }
                                    if (comboBox2.SelectedIndex == 1)
                                    {
                                        g = 1800;
                                    }
                                    if (comboBox2.SelectedIndex == 2)
                                    {
                                        g = 2700;
                                    }
                                    if (comboBox2.SelectedIndex == 3)
                                    {
                                        g = 3600;
                                    }
                                    if (comboBox2.SelectedIndex == 4)
                                    {
                                        g = 4500;
                                    }
                                    if (comboBox2.SelectedIndex == 5)
                                    {
                                        g = 5400;
                                    }
                                    if (comboBox2.SelectedIndex == 6)
                                    {
                                        g = 6300;
                                    }
                                    if (comboBox2.SelectedIndex == 7)
                                    {
                                        g = 7200;
                                    }
                                    if (comboBox2.SelectedIndex == 8)
                                    {
                                        g = 8100;
                                    }
                                    if (comboBox2.SelectedIndex == 9)
                                    {
                                        g = 9000;
                                    }
                                    if (comboBox2.SelectedIndex == 10)
                                    {
                                        g = 9900;
                                    }
                                    if (comboBox2.SelectedIndex == 11)
                                    {
                                        g = 10800;
                                    }
                                    if (comboBox2.SelectedIndex == 12)
                                    {
                                        g = 11700;
                                    }
                                    if (comboBox2.SelectedIndex == 13)
                                    {
                                        g = 12600;
                                    }
                                    if (comboBox2.SelectedIndex == 14)
                                    {
                                        g = 13500;
                                    }
                                    if (comboBox2.SelectedIndex == 15)
                                    {
                                        g = 14400;
                                    }
                                    if (comboBox2.SelectedIndex == 16)
                                    {
                                        g = 15300;
                                    }
                                    if (comboBox2.SelectedIndex == 17)
                                    {
                                        g = 16200;
                                    }
                                }
                                if (comboBox1.SelectedItem.ToString() == "自用小客車")
                                {
                                    if (comboBox2.SelectedIndex == 0)
                                    {
                                        g = 1620;
                                    }
                                    if (comboBox2.SelectedIndex == 1)
                                    {
                                        g = 2160;
                                    }
                                    if (comboBox2.SelectedIndex == 2)
                                    {
                                        g = 4320;
                                    }
                                    if (comboBox2.SelectedIndex == 3)
                                    {
                                        g = 7120;
                                    }
                                    if (comboBox2.SelectedIndex == 4)
                                    {
                                        g = 11230;
                                    }
                                    if (comboBox2.SelectedIndex == 5)
                                    {
                                        g = 15210;
                                    }
                                    if (comboBox2.SelectedIndex == 6)
                                    {
                                        g = 28220;
                                    }
                                    if (comboBox2.SelectedIndex == 7)
                                    {
                                        g = 46170;
                                    }
                                    if (comboBox2.SelectedIndex == 8)
                                    {
                                        g = 69690;
                                    }
                                    if (comboBox2.SelectedIndex == 9)
                                    {
                                        g = 117000;
                                    }
                                    if (comboBox2.SelectedIndex == 10)
                                    {
                                        g = 151200;
                                    }
                                }
                                if (comboBox1.SelectedItem.ToString() == "營業用小客車")
                                {
                                    if (comboBox2.SelectedIndex == 0)
                                    {
                                        g = 900;
                                    }
                                    if (comboBox2.SelectedIndex == 1)
                                    {
                                        g = 1260;
                                    }
                                    if (comboBox2.SelectedIndex == 2)
                                    {
                                        g = 2160;
                                    }
                                    if (comboBox2.SelectedIndex == 3)
                                    {
                                        g = 3060;
                                    }
                                    if (comboBox2.SelectedIndex == 4)
                                    {
                                        g = 6480;
                                    }
                                    if (comboBox2.SelectedIndex == 5)
                                    {
                                        g = 9900;
                                    }
                                    if (comboBox2.SelectedIndex == 6)
                                    {
                                        g = 16380;
                                    }
                                    if (comboBox2.SelectedIndex == 7)
                                    {
                                        g = 24300;
                                    }
                                    if (comboBox2.SelectedIndex == 8)
                                    {
                                        g = 33660;
                                    }
                                    if (comboBox2.SelectedIndex == 9)
                                    {
                                        g = 44460;
                                    }
                                    if (comboBox2.SelectedIndex == 10)
                                    {
                                        g = 56700;
                                    }
                                }
                                if (DateTime.IsLeapYear(cc.Value.Year))//是否為閏年
                                {
                                    count = g * totalday / 366;//計算公式(閏年)
                                    leapyear++;
                                }
                                else//如果不是
                                {
                                    count = g * totalday / 365;
                                }
                                //以下輸出
                                label7.Text += $"使用期間:{cc.Value.Year - 1911}/01/01 ~ {cc.Value.Year - 1911}/12/31\r\n";
                                label7.Text += $"計算天數:{totalday}天\r\n";
                                label7.Text += $"汽缸CC數:{comboBox2.SelectedItem}\r\n";
                                label7.Text += $"用途:{comboBox1.SelectedItem}\r\n";
                                if (leapyear != 0)//是否是閏年
                                {
                                    label7.Text += $"計算公式: {g}*{totalday}/366 = {count}元\r\n";
                                    leapyear--;
                                }
                                else
                                {
                                    label7.Text += $"計算公式: {g}*{totalday}/365 = {count}元\r\n";
                                }
                                label7.Text += $"應納稅額:共{count}元\r\n";
                                label7.Text += "\r\n";
                                allcount += count;//加入進總金額
                            }
                        }
                    }
                    label7.Text += $"全部應納稅額: 共 {allcount} 元";//輸出總金額
                }
                this.vScrollBar1.Maximum = this.label7.Text.Length * 4 / 3;
            }

        }

        #endregion

#region "其他設定"
        private void vScrollBar1_ValueChanged(object sender, EventArgs e)  //設定輸出結果欄位的上下卷軸,可容納更多內容
        {
            var newPoint = new Point(
                this.label7.Location.X,
                this._startPoint.Y - this.vScrollBar1.Value);
            this.label7.Location = newPoint;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  //稅務表超連結
        {
            this.linkLabel1.LinkVisited = true;

            //連接至URL
            System.Diagnostics.Process.Start("http://law-out.mof.gov.tw/LawContent.aspx?id=FL006130");

        }
 #endregion 
    }
}


