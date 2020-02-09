using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacijeZadatak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
               
            int prvi = 0;
            int drugi = 0;
            if (int.TryParse(textBox1.Text, out prvi))
            {

                if (int.TryParse(textBox2.Text, out drugi))
                {
                    MessageBox.Show("Rezultat je  " + (prvi + drugi));
                }
                else
                {
                    MessageBox.Show("Morate upisati broj");
                }
            }
            else
            {
                MessageBox.Show("Morate upisati broj");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            int prvi = 0;
            int drugi = 0;
            if (int.TryParse(textBox1.Text, out prvi))
            {

                if (int.TryParse(textBox2.Text, out drugi))
                {
                    MessageBox.Show("Rezultat je  " + (prvi - drugi));
                }
                else
                {
                    MessageBox.Show("Morate upisati broj");
                }
            }
            else
            {
                MessageBox.Show("Morate upisati broj");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int prvi = 0;
            int drugi = 0;
            if (int.TryParse(textBox1.Text, out prvi))
            {

                if (int.TryParse(textBox2.Text, out drugi))
                {
                    MessageBox.Show("Rezultat je  " + (prvi * drugi));
                }
                else
                {
                    MessageBox.Show("Morate upisati broj");
                }
            }
            else
            {
                MessageBox.Show("Morate upisati broj");
            }
        }
    }
}

