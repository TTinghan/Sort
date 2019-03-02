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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void firstFormBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstForm PFrm = new FirstForm();
            PFrm.Show();
        }

        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AbtFrm = new AboutForm();
            AbtFrm.ShowDialog();
        }
    }
}
