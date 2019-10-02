using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private List<TabPage> tabPages = new List<TabPage>();

        /// <summary>
        /// 树节点被鼠标单击时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //|| 或者    && 并且
            if(e.Node.Name== "StudentsList"|| e.Node.Name == "ClassList" || e.Node.Name == "HeadTeacherList"|| e.Node.Name == "TeacherList")
            {
                if (!tabPages.Exists(x => x.Text == e.Node.Text))
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Text = e.Node.Text;
                    this.tabCtrl_Content.TabPages.Add(tabPage);
                    tabPages.Add(tabPage);
                }
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //点击后向树节点添加一个任节点。
        }
    }
}
