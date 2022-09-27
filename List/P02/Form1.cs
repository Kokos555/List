using List_metody;
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
        int k;
        List<int> l ;
        private void button1_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(textBox1.Text);
            k = Convert.ToInt32(textBox2.Text);
            l= list.Generovani(pocet, -5, 20);
            list.vypis(listBox1, l);
            list.lambda(l, k);
            list.vypis(listBox2, l);
            label1.Text = String.Format($"Druhé maximum je {list.druhe_maximum(l,out int poradi_prvku)}, a je na {poradi_prvku}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(textBox2.Text);
            list.vymaz(l, k);
            list.vypis(listBox1, l);
        }
    }
}
