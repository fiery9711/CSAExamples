namespace A2_1
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupItems = new ComboBox();
            groupFooterAlign = new ComboBox();
            groupHeaderAlign = new ComboBox();
            label5 = new Label();
            groupFooter = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupSubTitle = new TextBox();
            groupHeader = new TextBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button9 = new Button();
            subItemText = new TextBox();
            label7 = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            itemChecked = new CheckBox();
            itemGroup = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            label9 = new Label();
            label10 = new Label();
            itemText = new TextBox();
            listViewAlignment = new ComboBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupItems);
            groupBox1.Controls.Add(groupFooterAlign);
            groupBox1.Controls.Add(groupHeaderAlign);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupFooter);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupSubTitle);
            groupBox1.Controls.Add(groupHeader);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Groups";
            // 
            // button3
            // 
            button3.Location = new Point(361, 33);
            button3.Name = "button3";
            button3.Size = new Size(40, 36);
            button3.TabIndex = 12;
            button3.Text = "#";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 33);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(275, 33);
            button1.Name = "button1";
            button1.Size = new Size(40, 36);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupItems
            // 
            groupItems.FormattingEnabled = true;
            groupItems.Location = new Point(6, 33);
            groupItems.Name = "groupItems";
            groupItems.Size = new Size(263, 36);
            groupItems.TabIndex = 10;
            groupItems.SelectedValueChanged += groupItems_SelectedValueChanged;
            // 
            // groupFooterAlign
            // 
            groupFooterAlign.FormattingEnabled = true;
            groupFooterAlign.Items.AddRange(new object[] { "Left", "Right", "Center" });
            groupFooterAlign.Location = new Point(225, 234);
            groupFooterAlign.Name = "groupFooterAlign";
            groupFooterAlign.Size = new Size(176, 36);
            groupFooterAlign.TabIndex = 9;
            groupFooterAlign.Text = "Left";
            // 
            // groupHeaderAlign
            // 
            groupHeaderAlign.FormattingEnabled = true;
            groupHeaderAlign.Items.AddRange(new object[] { "Left", "Right", "Center" });
            groupHeaderAlign.Location = new Point(11, 234);
            groupHeaderAlign.Name = "groupHeaderAlign";
            groupHeaderAlign.Size = new Size(183, 36);
            groupHeaderAlign.TabIndex = 8;
            groupHeaderAlign.Text = "Left";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 203);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 7;
            label5.Text = "FooterAligment";
            // 
            // groupFooter
            // 
            groupFooter.Location = new Point(95, 158);
            groupFooter.Name = "groupFooter";
            groupFooter.Size = new Size(306, 34);
            groupFooter.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 203);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 5;
            label4.Text = "HeaderAligment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 161);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 4;
            label3.Text = "Footer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 3;
            label2.Text = "SubTitle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 84);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 2;
            label1.Text = "Header";
            // 
            // groupSubTitle
            // 
            groupSubTitle.Location = new Point(95, 119);
            groupSubTitle.Name = "groupSubTitle";
            groupSubTitle.Size = new Size(306, 34);
            groupSubTitle.TabIndex = 1;
            // 
            // groupHeader
            // 
            groupHeader.Location = new Point(95, 81);
            groupHeader.Name = "groupHeader";
            groupHeader.Size = new Size(306, 34);
            groupHeader.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 367);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(412, 374);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(subItemText);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(itemChecked);
            groupBox2.Controls.Add(itemGroup);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(itemText);
            groupBox2.Location = new Point(430, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 729);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items";
            // 
            // button8
            // 
            button8.Location = new Point(292, 295);
            button8.Name = "button8";
            button8.Size = new Size(40, 36);
            button8.TabIndex = 20;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(246, 294);
            button9.Name = "button9";
            button9.Size = new Size(40, 36);
            button9.TabIndex = 19;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // subItemText
            // 
            subItemText.Location = new Point(95, 255);
            subItemText.Name = "subItemText";
            subItemText.Size = new Size(237, 34);
            subItemText.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 255);
            label7.Name = "label7";
            label7.Size = new Size(46, 28);
            label7.TabIndex = 17;
            label7.Text = "Text";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(6, 355);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 368);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 215);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 15;
            label6.Text = "SubItems";
            // 
            // itemChecked
            // 
            itemChecked.AutoSize = true;
            itemChecked.Location = new Point(6, 166);
            itemChecked.Name = "itemChecked";
            itemChecked.Size = new Size(108, 32);
            itemChecked.TabIndex = 14;
            itemChecked.Text = "Checked";
            itemChecked.UseVisualStyleBackColor = true;
            // 
            // itemGroup
            // 
            itemGroup.FormattingEnabled = true;
            itemGroup.Location = new Point(95, 81);
            itemGroup.Name = "itemGroup";
            itemGroup.Size = new Size(237, 36);
            itemGroup.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(292, 33);
            button5.Name = "button5";
            button5.Size = new Size(40, 36);
            button5.TabIndex = 11;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(246, 32);
            button6.Name = "button6";
            button6.Size = new Size(40, 36);
            button6.TabIndex = 2;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 125);
            label9.Name = "label9";
            label9.Size = new Size(46, 28);
            label9.TabIndex = 3;
            label9.Text = "Text";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 84);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 2;
            label10.Text = "Group";
            // 
            // itemText
            // 
            itemText.Location = new Point(95, 125);
            itemText.Name = "itemText";
            itemText.Size = new Size(237, 34);
            itemText.TabIndex = 1;
            // 
            // listViewAlignment
            // 
            listViewAlignment.FormattingEnabled = true;
            listViewAlignment.Items.AddRange(new object[] { "Default", "Top", "Left", "SnapToGrid" });
            listViewAlignment.Location = new Point(162, 308);
            listViewAlignment.Name = "listViewAlignment";
            listViewAlignment.Size = new Size(251, 36);
            listViewAlignment.TabIndex = 13;
            listViewAlignment.Text = "Top";
            listViewAlignment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 315);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 13;
            label8.Text = "Alignment";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(label8);
            Controls.Add(listViewAlignment);
            Controls.Add(groupBox2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox groupSubTitle;
        private TextBox groupHeader;
        private ListView listView1;
        private ComboBox groupFooterAlign;
        private ComboBox groupHeaderAlign;
        private Label label5;
        private TextBox groupFooter;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox groupItems;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Label label9;
        private Label label10;
        private TextBox itemText;
        private TextBox subItemText;
        private Label label7;
        private ListBox listBox1;
        private Label label6;
        private CheckBox itemChecked;
        private ComboBox itemGroup;
        private Button button8;
        private Button button9;
        private ComboBox listViewAlignment;
        private Label label8;
    }
}
