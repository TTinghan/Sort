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
    public partial class SixthForm : Form
    {
        public SixthForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
      
        //快速排序
        private void button1_Click(object sender, EventArgs e)
        {
           
            string[] sf = textBox1.Text.Trim().Split(new char[] { ',' });
            //string r = "(";
                QuickSortt Quick = new QuickSortt();

    
            int[] R = new int[10];
            for (int i = 0; i < 10; i++)
               R[i] = Convert.ToInt32(sf[i]);
                Quick.QuickSort(R,0,R.Length -1);
                foreach (int i in R )
                {
                    Console .Write (i+"");
                    textBox2.Text += i.ToString() + ",";

                }

            }
   
        }
    }

   
