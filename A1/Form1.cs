namespace A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Assalomu alaykum, {textBox1.Text}");
            //MessageBox.Show($"Bu asosiy xabar matni", "Bu sarlavha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
