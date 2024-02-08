namespace A2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(133, 13);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 0;
            label1.Text = "C# Dasturlash tili kursi qabuli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 1;
            label2.Text = "Qatnashuvchi F.I.O.:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 39);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 185);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 3;
            label3.Text = "Qatnashuvchi jinsi:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(341, 182);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 36);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkak";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(471, 181);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 36);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ayol";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 374);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(472, 36);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Men kursning barcha shartlariga roziman";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(21, 425);
            button1.Name = "button1";
            button1.Size = new Size(532, 89);
            button1.TabIndex = 7;
            button1.Text = "Qatnashish";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "C#: 2-amaliy dars";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private Button button1;
    }
}
