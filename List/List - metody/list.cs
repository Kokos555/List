using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace List_metody
{
    public class list
    {
        static public void vypis(ListBox k, List<int> pole)
        {
            k.Items.Clear();
            for (int i = 0; i < pole.Count; i++)
            {
                k.Items.Add(pole[i]);
            }
        }
        static public List<int> vymaz(List<int> pole, int k)
        {
            int i = 0;
            while (i < pole.Count)
            {
                if (pole.Contains(k)) { 
                    pole.Remove(k);
                }
                else
                {
                    i++;
                }
            }
            return pole;
        }
        static public List<int> lambda(List<int> pole, int k)
        {
            pole.RemoveAll(a => a == k);
            return pole;
        }
        static public int druhe_maximum(List<int> pole, out int poradi)
        {
            int max = pole.Max();
            int max2 = -8;
            poradi = 0;
            for(int i = 0; i < pole.Count; i++)
            {
                if (pole[i]>max2 && pole[i] != max)
                {
                    max2 = pole[i];
                    poradi = i+1;

                }
            }
            return max2;
        }
    }
}
