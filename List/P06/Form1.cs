using List_metody;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            double a1;
            double a2;
            int p;
            if (!int.TryParse(textBox1.Text,out n) || !double.TryParse(textBox2.Text, out a1) || !double.TryParse(textBox3.Text, out a2) || !int.TryParse(textBox4.Text, out p))
            {
                MessageBox.Show(String.Format("Jeden z paramatrů byl zadán chybě!!"));
                return;
            }
            List<double> l = list.Vytvor_gon(n, a1, a2);
            list.Vypis(listBox1, l);
            if (list.Soucet_prvku(l,p,out double soucet))
            {
                MessageBox.Show(String.Format($"Součet prvků v poli je {soucet}."));
            }else
            {
                MessageBox.Show(String.Format($"Číslo p = {p} je větší jak velkost pole = {l.Count}"));
            }




        }
    }
}
