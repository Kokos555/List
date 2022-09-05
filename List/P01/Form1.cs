using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> l = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pocet = Convert.ToInt32(textBox1.Text);
            Random cisla = new Random();
            int random_cislo = 0;
            for (int i = 0; i<pocet; i++)
            {
                random_cislo = cisla.Next(1, 101);
                l.Add(random_cislo);
            }
            for (int i = 0; i < l.Count; i++)
            {
                listBox1.Items.Add(l[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.Sort();
            string cisla = "";
            for (int i = 0; i < l.Count; i++)
            {
                cisla += l[i]+ ", ";
            }
            MessageBox.Show(string.Format("{0}",cisla));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l.Clear();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
