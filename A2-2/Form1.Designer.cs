namespace A2_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Node1");
            TreeNode treeNode2 = new TreeNode("Node0", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Node4");
            TreeNode treeNode4 = new TreeNode("Node3", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Node2", new TreeNode[] { treeNode4 });
            treeView1 = new TreeView();
            label1 = new Label();
            nodeText = new TextBox();
            addNode = new Button();
            groupBox1 = new GroupBox();
            addChild = new Button();
            childNodeText = new TextBox();
            label3 = new Label();
            delNode = new Button();
            activeNodeText = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            clearNodes = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 301);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Node2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode5 });
            treeView1.Size = new Size(558, 440);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 1;
            label1.Text = "Node";
            // 
            // nodeText
            // 
            nodeText.Location = new Point(79, 6);
            nodeText.Name = "nodeText";
            nodeText.Size = new Size(271, 34);
            nodeText.TabIndex = 2;
            // 
            // addNode
            // 
            addNode.Location = new Point(356, 6);
            addNode.Name = "addNode";
            addNode.Size = new Size(94, 34);
            addNode.TabIndex = 3;
            addNode.Text = "Add";
            addNode.UseVisualStyleBackColor = true;
            addNode.Click += addNode_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addChild);
            groupBox1.Controls.Add(childNodeText);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(delNode);
            groupBox1.Controls.Add(activeNodeText);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 146);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Child";
            // 
            // addChild
            // 
            addChild.Location = new Point(457, 79);
            addChild.Name = "addChild";
            addChild.Size = new Size(94, 34);
            addChild.TabIndex = 5;
            addChild.Text = "Add";
            addChild.UseVisualStyleBackColor = true;
            addChild.Click += addChild_Click;
            // 
            // childNodeText
            // 
            childNodeText.Location = new Point(132, 80);
            childNodeText.Name = "childNodeText";
            childNodeText.Size = new Size(319, 34);
            childNodeText.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 6;
            label3.Text = "Child Node";
            // 
            // delNode
            // 
            delNode.Location = new Point(457, 26);
            delNode.Name = "delNode";
            delNode.Size = new Size(94, 34);
            delNode.TabIndex = 5;
            delNode.Text = "Del";
            delNode.UseVisualStyleBackColor = true;
            delNode.Click += delNode_Click;
            // 
            // activeNodeText
            // 
            activeNodeText.Location = new Point(132, 27);
            activeNodeText.Name = "activeNodeText";
            activeNodeText.Size = new Size(319, 34);
            activeNodeText.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 5;
            label2.Text = "Active Node";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(18, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 32);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "ShowLines";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(183, 198);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(167, 32);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "ShowRootLines";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(393, 198);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(170, 32);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "ShowPlusMinus";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(18, 246);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(139, 32);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "HotTracking";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Location = new Point(183, 246);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(155, 32);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "HideSelection";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(393, 246);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(154, 32);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "FullRowSelect";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // clearNodes
            // 
            clearNodes.Location = new Point(469, 9);
            clearNodes.Name = "clearNodes";
            clearNodes.Size = new Size(94, 34);
            clearNodes.TabIndex = 11;
            clearNodes.Text = "Clear";
            clearNodes.UseVisualStyleBackColor = true;
            clearNodes.Click += clearNodes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(clearNodes);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(addNode);
            Controls.Add(nodeText);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private TextBox nodeText;
        private Button addNode;
        private GroupBox groupBox1;
        private Button addChild;
        private TextBox childNodeText;
        private Label label3;
        private Button delNode;
        private TextBox activeNodeText;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button clearNodes;
    }
}
