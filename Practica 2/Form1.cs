namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, count = 0, lim;
            num = int.Parse(textBox1.Text);
            lim = int.Parse(textBox2.Text);

            do
            {
                listBox1.Items.Add(num + " * " + count + " = " + num * count);
                count++;
            } while (count <= lim);
        }
    }
}