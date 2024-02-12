namespace A2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNode_Click(object sender, EventArgs e)
        {
            var node = new TreeNode();
            node.Text = nodeText.Text;

            treeView1.Nodes.Add(node);
        }

        private void delNode_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode as TreeNode;
            if (node != null)
            {
                treeView1.Nodes.Remove(node);
            }
        }

        private void addChild_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode as TreeNode;
            if (node != null)
            {
                var childNode = new TreeNode();
                childNode.Text = childNodeText.Text;
                node.Nodes.Add(childNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = treeView1.SelectedNode as TreeNode;
            if (node != null)
            {
                activeNodeText.Text = node.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.ShowLines = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.ShowRootLines = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.ShowPlusMinus = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.HotTracking = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.HideSelection = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.FullRowSelect = checkBox6.Checked;
        }

        private void clearNodes_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
