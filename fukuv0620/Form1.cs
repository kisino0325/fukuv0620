using System;
using System.Diagnostics.Eventing.Reader;

namespace fukuv0620
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int yosou;
            int answer = random.Next(51);
            MessageBox.Show($"{count}âÒñ⁄ÇÃíßêÌ");
            yosou = int.Parse(textBox1.Text);
            if (yosou == answer)
            {
                MessageBox.Show($"Bingo!!");
            }
            else if (yosou < answer)
            {
                MessageBox.Show($"chiisakatta");
            }
            else 
            {
                MessageBox.Show($"ookikatta");
            }
        }
    }
}
