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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //直接插入排序
        private void button1_Click(object sender, EventArgs e)
        {                                       //temp用于记录插入元素
            int j,temp;                         //j是寻找插入位置的指针
           
            string[] sf = textBox1.Text.Trim().Split(new char[] { ',' });
            int[] num = new int[10];
            for (int i = 0; i < 10;i++ )
                num[i] = Convert.ToInt32(sf[i]);
            for (int i = 1; i < num.Length; i++)//约定第一个元素为有序
            {
                temp = num[i];                  //将插入元素存于变量temp中
                j = i - 1;                 
                //从后往前查找插入位置，同时将已排序记录向后移动
                while (j >= 0 && temp < num[j])
                {
                    num[j + 1] = num[j];        //移动记录
                    j--;
                }
                num[j + 1] = temp;              //将插入元素插入到合适位置
            }
                   
            foreach (int i in num)               //打印排序后的元素
            {
                Console.Write(i+"");
                textBox2.Text += i.ToString()+",";//排序结果显示在TextBox中
            }
            
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
