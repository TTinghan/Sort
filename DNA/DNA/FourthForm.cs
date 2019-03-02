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
    public partial class FourthForm : Form
    {
        public FourthForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //冒泡排序
        private void button2_Click(object sender, EventArgs e)
        {
            string[] sf = textBox1.Text.Trim().Split(new char[] { ',' });
           // string r = "(";

            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(sf[i]);
            for (int j = 1; j < arr.Length ; j++)
            {                                        //外层循环每次把参与排序的最大数排在最后
                for (int i = 0; i< arr.Length - j; i++)
                {                                   //内层循环负责对比相邻的两个数，并把大的排在后面
                    if (arr [i] > arr [i + 1])
                    {                               //如果前一个数大于后一个数，则交换两个数
                        int a = arr [i];
                        arr[i] = arr[i + 1];
                        arr [i + 1] = a;
                    }
                }
            }
            foreach (int i in arr)
            {                                      //用一个循环访问数组里的元素并打印
                Console.Write(i+"");
                textBox2.Text += i.ToString() + ",";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

       
