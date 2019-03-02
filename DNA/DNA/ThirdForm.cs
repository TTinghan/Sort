using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNA
{
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //直接选择排序
        private void button2_Click(object sender, EventArgs e)
        {
            int k, temp;
            string[] sf = textBox1.Text.Trim().Split(new char[] { ',' });
           // string r = "(";

            int[] R = new int[10];
            for (int i = 0; i < 10; i++)
                R [i] = Convert.ToInt32(sf[i]);
            for (int i = 0; i < R.Length - 1; i++)
            {
                k = i;                 //k用于记录一趟排序中最小元素的索引号
                for (int j = i + 1; j < R.Length; j++)
                {
                    if (R[j] < R[k])   //只要发现比R[j]小的元素
                    {                  //就把这个元素的索引号记录在变量k内
                        k = j;
                    }
                }
                if (i != k)
                {                      //交换R[i]和R[k]的值，把最小元素依次放在最左边
                    temp = R[i];
                    R[i] = R[k];
                    R[k] = temp;
                }
            }
            foreach (int i in R)       //打印所有元素
            {
                Console.Write(i+"");
                textBox2.Text += i.ToString() + ",";
            }
            Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
