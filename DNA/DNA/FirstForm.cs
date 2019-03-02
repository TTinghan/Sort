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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm PFrm = new SecondForm();
            PFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThirdForm PFrm = new ThirdForm();
            PFrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FourthForm PFrm = new FourthForm();
            PFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FifthForm PFrm = new FifthForm();
            PFrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SixthForm PFrm = new SixthForm();
            PFrm.Show();
        }
    }
}
