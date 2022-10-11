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

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> l = new List<int>(); 
            int n = Convert.ToInt32(textBox1.Text);
            l = list.Generovani(n, -100, 100);
            list.Vypis(listBox1, l);
            l = list.Prohození(l, out int min, out int max);
            list.Vypis(listBox2, l);
            MessageBox.Show(string.Format($"Čísla v poli, min je {min} a max je {max}"));
        }
    }
}
