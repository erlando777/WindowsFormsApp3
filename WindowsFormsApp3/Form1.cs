using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static double[] Masyvas = new double[10];
        int vieta = 0;
        private object label;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            richTextBox1.Clear();
            string skaicius = textBox1.Text;
            if (String.IsNullOrWhiteSpace(skaicius) || String.IsNullOrEmpty(skaicius))
            {
                MessageBox.Show("Blogi duomenys.");
            }
            else if(Convert.ToInt32(skaicius) <= 0)
            {
                MessageBox.Show("Jūsų skaičius nėra teigiamas.");
            }
            else {
                int kiekis = Convert.ToInt32(skaicius);
                richTextBox1.Text = "Čia jūsų eglutė: \n";
                int x = 1, tarp = 0;
                for(int i = 0; i < kiekis; i++)
                {
                    if(x == 1 && x != kiekis)
                    {
                        int tarpai = kiekis - 1;
                        while(tarpai > 0)
                        {
                            richTextBox1.Text += " ";
                            tarpai--;
                        }
                        richTextBox1.Text += "* \n";
                    }
                    if(x != 1 && x != kiekis)
                    {
                        int tarpai1 = kiekis - x;
                        while(tarpai1 > 0)
                        {
                            richTextBox1.Text += " ";
                            tarpai1--;
                        }
                        tarp = x;
                        while(tarp > 0)
                        {
                            richTextBox1.Text += "* ";
                            tarp--;
                        }
                        richTextBox1.Text += "\n";
                        x++;
                    }
                    if(x == kiekis)
                    {
                        while (x > 0)
                        {
                            richTextBox1.Text += "* ";
                            x--;
                        }
                        break;
                    }
                    x++;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            richTextBox1.Clear();
            string tekstas = textBox2.Text;
            if (String.IsNullOrEmpty(tekstas) || String.IsNullOrWhiteSpace(tekstas))
            {
                MessageBox.Show("Blogi duomenys");

            }
            else
            {
                textBox2.Clear();
                
                double skaicius = Convert.ToDouble(tekstas);
                if (vieta < 10)
                {
                    Masyvas[vieta] = skaicius;
                }
                else
                {
                    MessageBox.Show("Masyve jau yra 10 elementų");
                    Environment.Exit(0);
                    
                }
                if (vieta == 9)
                {
                    label6.Text = "Jau užpildėte visus 10 elementų, atsakymas apačioje: ";
                    double suma = 0;
                    for (int i = 0; i < Masyvas.Length-1; i++)
                    {
                        suma += Masyvas[i];
                    }
                    richTextBox1.Text += "Suma lygi: \n" + suma + "\n\n";

                }
                else
                {
                    label6.Text = "Kad užduotis būtų įvykdyta, reikia įvesti dar: " + (Masyvas.Length - vieta - 1) + " elementa/us.";
                    //MessageBox.Show("Masyve dar trūksta skaičių. Prašome įvesti papildomą skaičių.");
                }

                vieta++;
                int n = Masyvas.Length;
                richTextBox1.Text += "Jūsų masyvo nariai: \n";
                for (int i = 0; i < vieta; i++)
                {
                    richTextBox1.Text += Masyvas[i] + " " ;
                }
                richTextBox1.Text += "\nElementų skaičius: " + vieta;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
