namespace Practica_3
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_num = float.Parse(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = " ";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {

                Total += Convert.ToSingle(item);

            }

            textBox2.Text = Total.ToString();
        }
    }
}