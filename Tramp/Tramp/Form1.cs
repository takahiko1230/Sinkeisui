using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tramp
{

    public partial class Form1 : Form
    {
        private string[] str = new string[] { "○", "●", "◎", "△", "■", "○", "●", "◎", "△", "■" };

        //数と記号を関連付ける
        IDictionary<int, string> dict = new Dictionary<int, string>();

        //1枚目のカード
        string oneCard;
        //二枚目のカード
        string twoCard;

        bool check = true;

        Button bt1;
        Button bt2;

        //試行回数
        int numCount=0;
        //正解個数
        int trueCheck = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //開始する
        private void button11_Click(object sender, EventArgs e)
        {
            RandomScore rm = new RandomScore();
            List<int> val = rm.RandomPlay();

            //文字を配置する
            int k = 0;

            foreach (int valScore in val)
            {
                dict[val[k]] = str[k];
                k++;
            }
            label1.Text = "開始しました。";
            button11.Enabled = false;
        }

        //2枚表に返したときに行う
        public void CheckCard()
        {
            if (oneCard != twoCard)
            {
                check = false;
            }
            if (oneCard == twoCard)
            {
                bt1.Enabled = false;
                bt2.Enabled = false;
                check = true;
                trueCheck += 1;
                textBox2.Text= String.Format("{0}個正解中", trueCheck.ToString());
            }
            oneCard = null;
            twoCard = null;
            numCount += 1;
            textBox1.Text = String.Format("{0}回目",numCount.ToString());
            //全部終了時に表示
            if (trueCheck == 5)
            {
                textBox2.Text = "おめでとうございます！";
            }
        }

        //ボタン1をクリックしたとき
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (check == false)
                {
                    bt1.Text = "";
                    bt2.Text = "";
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button1;
                    oneCard = dict[0];
                    bt1.Text = dict[0];
                    return;

                }
                if (twoCard == null && button1.Text == "")
                {
                    bt2 = button1;
                    twoCard = dict[0];
                    bt2.Text = dict[0];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = "";
                    bt2.Text = "";
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button2;
                    oneCard = dict[1];
                    bt1.Text = dict[1];
                    return;
                }
                if (twoCard == null && button2.Text == "")
                {
                    bt2 = button2;
                    twoCard = dict[1];
                    bt2.Text = dict[1];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button3;
                    oneCard = dict[2];
                    bt1.Text = dict[2];
                    return;

                }
                if (twoCard == null && button3.Text == "")
                {
                    bt2 = button3;
                    twoCard = dict[2];
                    bt2.Text = dict[2];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button4;
                    oneCard = dict[3];
                    bt1.Text = dict[3];
                    return;

                }
                if (twoCard == null && button4.Text == "")
                {
                    bt2 = button4;
                    twoCard = dict[3];
                    bt2.Text = dict[3];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button5;
                    oneCard = dict[4];
                    bt1.Text = dict[4];
                    return;

                }
                if (twoCard == null && button5.Text == "")
                {
                    bt2 = button5;
                    twoCard = dict[4];
                    bt2.Text = dict[4];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button6;
                    oneCard = dict[5];
                    bt1.Text = dict[5];
                    return;

                }
                if (twoCard == null && button6.Text == "")
                {
                    bt2 = button6;
                    twoCard = dict[5];
                    bt2.Text = dict[5];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button7;
                    oneCard = dict[6];
                    bt1.Text = dict[6];
                    return;

                }
                if (twoCard == null && button7.Text == "")
                {
                    bt2 = button7;
                    twoCard = dict[6];
                    bt2.Text = dict[6];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button8;
                    oneCard = dict[7];
                    bt1.Text = dict[7];
                    return;

                }
                if (twoCard == null && button8.Text == "")
                {
                    bt2 = button8;
                    twoCard = dict[7];
                    bt2.Text = dict[7];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button9;
                    oneCard = dict[8];
                    bt1.Text = dict[8];
                    return;

                }
                if (twoCard == null && button9.Text == "")
                {
                    bt2 = button9;
                    twoCard = dict[8];
                    bt2.Text = dict[8];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    bt1.Text = null;
                    bt2.Text = null;
                    check = true;
                }
                if (oneCard == null)
                {
                    bt1 = button10;
                    oneCard = dict[9];
                    bt1.Text = dict[9];
                    return;

                }
                if (twoCard == null)
                {
                    bt2 = button10;
                    twoCard = dict[9];
                    bt2.Text = dict[9];
                    CheckCard();
                }
            }
            catch (Exception)
            {
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
