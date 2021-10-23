using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize1,vize2,final, ort;
            vize1 = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox3.Text);
            vize2 = Convert.ToDouble(textBox2.Text);


            ort = vize1 * 30 / 100 + vize2 * 30 / 100 + final * 40 / 100;

            

            if ((vize1 > 100) || (vize1 < 0) || (vize2 > 100) || (vize2 < 0) || (final > 100) || (final < 0))
            {
                MessageBox.Show(" Sınav değeri 0-100 arasında olmalıdır.");

            }
          else if ((ort <= 100) && (ort >= 90))
            {
                MessageBox.Show(" Ortalama: " +ort +  "  Harf Notu:AA");
            }
            else if ((ort <=89) && (ort >= 85))
            {
                MessageBox.Show("Ortalama: " + ort +  "Harf Notu:BA");
            }
            else if ((ort <= 84) && (ort >= 80))
            {
                MessageBox.Show("Ortalama: " + ort +  " Harf Notu:BB");
            }
            else if ((ort <= 79) && (ort >= 75))
            {
                MessageBox.Show("Ortalama: " + ort + " Harf Notu:CB");
            }
            else if ((ort <= 74) && (ort >= 65))
            {
                MessageBox.Show("Ortalama: " + ort + " Harf Notu:CC");
            }
            else if ((ort <= 64) && (ort >= 60))
            {
                MessageBox.Show("Ortalama: " + ort + " Harf Notu:DC");
            }
            else if ((ort <= 59) && (ort >= 50))
            {
                MessageBox.Show("Ortalama: " + ort + " Harf Notu:DD");
            }
            
            else if (final < 50)
            {
                MessageBox.Show("Ortalama: " + ort + " Harf Notu:FF");
            }
            else
            {
             
           MessageBox.Show("Ortalama: " + ort +  " Harf Notu:FF");
                
            }
        }
    }
}
