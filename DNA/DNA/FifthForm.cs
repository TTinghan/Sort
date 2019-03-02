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
    public partial class FifthForm : Form
    {
        public FifthForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //希尔排序
        private void button2_Click(object sender, EventArgs e)
        {
            int j, temp;
            string[] sf = textBox1.Text.Trim().Split(new char[] { ',' });
           
            int[] R = new int[10];
            for (int i = 0; i < 10; i++)
                R[i] = Convert.ToInt32(sf[i]);
           
            for (int d = R .Length /2;d >=1;d=d/2)
            {
                for (int i = d; i< R.Length ; i++)
                {
                    temp = R[i];
                    j = i - d;
                    while (j >= 0 && temp < R[j])
                    {
                        R[j + d] = R[j];
                        j = j - d;
                    }
                    R[j + d] = temp;

                }
            }
            foreach (int i in R)
            {
                Console.Write(i+"");
                textBox2.Text += i.ToString() + ",";
            }
        }
    }
}
