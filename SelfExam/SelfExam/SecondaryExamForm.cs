using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelfExam
{
    public partial class SecondaryExamForm : Form
    {
        public SecondaryExamForm()
        {
            InitializeComponent();
        }

        private void SecondaryExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "确定要关闭当前窗体吗？是,请单击‘确定’\n按钮，否则，请单击‘取消’按钮。", "提示",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SecondaryExamForm SFrm = new SecondaryExamForm();
                SFrm.Close();
            }
            else
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //从指定文件创建位图
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName, false);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //创建一个SaveFileDiaLog类的实例
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //设置相应属性
            saveFileDialog1.Title = "保存图片";
            saveFileDialog1.Filter = "图片类型(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            saveFileDialog1.ShowDialog();//显示对话框
        }
    }
}
