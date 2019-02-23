using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class FrmMain : Form
    {
        Random r = new Random(37);

        public FrmMain()
        {
            InitializeComponent();
            lstv1.Columns.Add("Name");
            lstv1.Columns.Add("Depth");
        }

        void TreeToList()
        {
            lstv1.Items.Clear();
            foreach(TreeNode node in trv1.Nodes)
            {
                TreeToList(node);
            }
        }

        void TreeToList(TreeNode node)
        {
            lstv1.Items.Add(new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach(TreeNode n in node.Nodes)
            {
                TreeToList(n);
            }
        }

        private void addRoot_Click(object sender, EventArgs e)
        {
            trv1.Nodes.Add(r.Next().ToString());
            TreeToList();
        }

        private void addChild_Click(object sender, EventArgs e)
        {
            if(trv1.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드 없음.", "트리뷰테스트", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            trv1.SelectedNode.Nodes.Add(r.Next().ToString());
            trv1.SelectedNode.Expand();
            TreeToList();
        }
    }
}
