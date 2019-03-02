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
    public partial class PrimaryExamForm : Form
    {
        public PrimaryExamForm()
        {
            InitializeComponent();
        }
        int ExamSecond = 0;//考试用时
        private void timer1_Tick(object sender, EventArgs e)
        {
            //以秒为单位自测用时计量
            ExamSecond++;
            this.ExamTime.Text = ExamSecond.ToString();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            int Score = 0;
            if (this.Answer1.Text == "2000") Score = Score + 10;
            if (this.Answer21A.Checked) Score = Score + 10;
            if (this.Answer22A.Checked) Score = Score + 10;
            if (this.Answer23.Text == "Passwordchar") Score = Score + 10;
            if (this.Answer24.Text=="Text") Score = Score + 10;
            if (this.Answer3A.Checked && this.Answer3B .Checked &&
                this.Answer3C .Checked && !this.Answer3D .Checked )
            Score =Score +10;
            this .timer1 .Enabled =false ;//计时停止
            this .btnGrade .Enabled =false ;//评分锁定
            this .TotalScore .Text =Score .ToString ();//显示总分
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//调用Close方法关闭窗体PrimaryExamForm
        }

        private void PrimaryExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "确定要关闭当前窗体吗？是,请单击‘确定’\n按钮，否则，请单击‘取消’按钮。", "提示",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                PrimaryExamForm  SFrm = new PrimaryExamForm ();
                SFrm.Close();
            }
            else
                e.Cancel = true;
        }
    }
}
