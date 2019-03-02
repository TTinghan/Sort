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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出系统
            Application.Exit();
        }

        private void 初级自测试题PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //隐藏父窗体上的标题文本
            this.label1.Visible = false;
            //隐藏父窗体上的修饰图片
            this.pictureBox1.Visible = false;
            //隐藏父窗体上的版权文本
            this.label2.Visible = false;
            //将MainForm窗体设置为父窗体，此行代码功能与步骤（1）等效，二者可取其一
            //this.IsMdiContainer = true;
            //实例化PrimaryExamForm
            PrimaryExamForm  PFrm = new PrimaryExamForm ();
            //调用方法Show方法，显示窗体PFrm
            //补充代码：将MainForm窗体作为父窗体
            PFrm.MdiParent = this;
            //调用Show方法，显示窗体PFrm
            PFrm.Show();
        }
        private void 中级自测试题SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //隐藏父窗体上的标题文本
            this.label1.Visible = false;
            //隐藏父窗体上的修饰图片
            this.pictureBox1.Visible = false;
            //隐藏父窗体上的版权文本
            this.label2.Visible = false;
            //将MainForm窗体设置为父窗体，此行代码功能与步骤（1）等效，二者可取其一
            //this.IsMdiContainer = true;
            //实例化PrimaryExamForm
            SecondaryExamForm PFrm = new SecondaryExamForm ();
            //调用方法Show方法，显示窗体PFrm
            PFrm.MdiParent = this;
            //调用Show方法，显示窗体PFrm
            PFrm.Show();
        }

        private void 高级自测试题AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //隐藏父窗体上的标题文本
            this.label1.Visible = false;
            //隐藏父窗体上的修饰图片
            this.pictureBox1.Visible = false;
            //隐藏父窗体上的版权文本
            this.label2.Visible = false;
            //将MainForm窗体设置为父窗体，此行代码功能与步骤（1）等效，二者可取其一
            //this.IsMdiContainer = true;
            //实例化PrimaryExamForm
            AdvacedExamForm  PFrm = new AdvacedExamForm ();
            //调用方法Show方法，显示窗体PFrm
            PFrm.MdiParent = this;
            //调用Show方法，显示窗体PFrm
            PFrm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //利用MdiChildren遍历所有子窗体，并依次关闭
            Form[] CFrmList = this.MdiChildren;
            foreach (Form CFrm in CFrmList)
            {
                CFrm.Close();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            String sltItem = this.toolStripComboBox1.Text;
            switch (sltItem)
            {
                case ("层叠排列"):
                    LayoutMdi(MdiLayout.Cascade);
                    break;
                case ("水平平铺"):
                    LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case ("垂直平铺"):
                    LayoutMdi(MdiLayout.TileVertical);
                    break;
                case ("图标排列"):
                    LayoutMdi(MdiLayout.ArrangeIcons);
                    break;
            }
        }

        private void 关于系统AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AbtFrm = new AboutForm();
            //模态方式打开窗口
            AbtFrm.ShowDialog();
        }
    }
}
