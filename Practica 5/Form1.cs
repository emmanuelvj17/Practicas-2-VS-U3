namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            while (num <= 20)
            {
                listBox1.Items.Add(num);
                num++;
            }


        }
    }
}