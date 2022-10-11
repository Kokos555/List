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

namespace P09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<char> l = new List<char>();

        private void button7_Click(object sender, EventArgs e)
        {
            l = new List<char>(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char pismeno = (sender as Button).Text[0];
            int i = 0;
            while (i < l.Count)
            {
                if (l[i] == pismeno)
                {
                    l.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

        }
    }
}
