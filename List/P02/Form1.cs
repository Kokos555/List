using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random cisla = new Random();
            List<int> l = new List<int>();
            int pocet = Convert.ToInt32(textBox1.Text);
            int k = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < pocet; i++)
            {
                int random_cislo = cisla.Next(-5, 20);
                l.Add(random_cislo);
            }
            
            for(int i = 0; i < l.Count; i++)
            {
                listBox1.Items.Add(l[i]);
            }
        }
    }
}
