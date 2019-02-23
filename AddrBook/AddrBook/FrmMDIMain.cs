﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddrBook
{
    public partial class FrmMDIMain : Form
    {

        //FrmListView 
        public FrmMDIMain()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FrmMDIMain_Load(object sender, EventArgs e)
        {
            TreeNode node1 = new TreeNode("화일");
            node1.Tag = 1;
            node1.ImageIndex = 0;
            node1.SelectedImageIndex = 0;
            node1.Expand();

            TreeNode node11 = new TreeNode("Calculator");
            node11.ImageIndex = 1;
            node11.SelectedImageIndex = 0;
            node11.Tag = 11;
            
            TreeNode node12 = new TreeNode("Web-Crawler");
            node12.ImageIndex = 2;
            node12.SelectedImageIndex = 1;
            node12.Tag = 12;

            TreeNode node13 = new TreeNode("View Log");
            node13.ImageIndex = 3;
            node13.SelectedImageIndex = 2;
            node13.Tag = 13;

            TreeNode node14 = new TreeNode("Exit");
            node14.ImageIndex = 4;
            node14.SelectedImageIndex = 3;
            node14.Tag = 14;

            node1.Nodes.Add(node11);
            node1.Nodes.Add(node12);
            node1.Nodes.Add(node13);
            node1.Nodes.Add(node14);

            TreeNode node2 = new TreeNode("주소록");
            node2.ImageIndex = 0;
            node2.SelectedImageIndex = 0;
            node2.Tag = 2;
            node2.Expand();

            TreeNode node21 = new TreeNode("ListView이용");
            node2.ImageIndex = 1;
            node2.SelectedImageIndex = 1;
            node2.Tag = 21;

            TreeNode node22 = new TreeNode("DataGrid이용");
            node2.ImageIndex = 1;
            node2.SelectedImageIndex = 1;
            node2.Tag = 22;

            node2.Nodes.Add(node21);
            node2.Nodes.Add(node22);

            treeView1.Nodes.Add(node1);
            treeView1.Nodes.Add(node2);

        }

        private void FrmMDIMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
