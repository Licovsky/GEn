
using System.Security.Cryptography;

namespace Bosov_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void MakeHistogram(Label[] labels, int[] values)
        {
            // ¬ычислим масштаб, чтобы наибольший
            // значение прекрасно вписываетс€ в форму.
            int available_height = labels[0].Bottom - 5;
            int max = values.Max();
            float scale = available_height / (float)max;

            for (int i = 0; i < labels.Length; i++)
            {
                int height = (int)(scale * values[i]);
                labels[i].Top = labels[i].Bottom - height;
                labels[i].Height = height;
                
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        double _A = 6;
        double _B = 7;
        double _C = 3;
        double _Mm = Math.Pow(2, 12);
        double _Y = 4001;

        private double Rnd()
        {
            _Y = (_A * _Y * _Y + _B * _Y + _C) % _Mm;
            return (double) _Y/_Mm;
        }
       
        

        private void button1_Click_Click(object sender, EventArgs e)
        {
            // —делать массив дл€ хранени€ значений дл€ значений
            // между 2 и 12 с индексами от 0 до 10.

            int[] da = new int[5000];
            Random num = new Random();
            for (int i = 0; i < 5000; i++)
            {

     
                double new_value =Rnd();
                listBox1.Items.Add(new_value.ToString());
              


            }

            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}