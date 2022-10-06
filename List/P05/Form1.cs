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

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1;
            int d;
            int n;

            if (!int.TryParse(textBox1.Text, out n) || !int.TryParse(textBox2.Text,out a1)|| !int.TryParse(textBox3.Text,out d)||n<1)
            {
                MessageBox.Show(string.Format("Počet prvků je menší jak 1"));
                return;
            }

            List<int> l = list.vytvor(n, a1, d);

            if (checkBox1.Checked)
            {
                list.Pridani(l, n);
            }

            list.vypis(listBox1, l);
        }
    }
}
