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

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> l;
            int n = Convert.ToInt32(textBox1.Text);
            l = list.Generovani(n, -5, 26);
            list.vypis(listBox1, l);
            l.Reverse();
            list.vypis(listBox2, l);
            for(int i = 0; i < listBox3.Items.Count; i++)
            {

            }
        }
    }
}
