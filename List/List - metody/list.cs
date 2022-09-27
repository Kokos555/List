using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace List_metody
{
    public class list
    {
        static public List<int> Generovani(int pocet, int dolni_mez, int horni_mez)
        {
            List<int> pole = new List<int>();
            Random nh = new Random();
            for (int i = 0; i < pocet; i++)
            {
                int x = nh.Next(dolni_mez, horni_mez);
                pole.Add(x); 
            }
            return pole;
        }


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
                if (k == pole[i]) { 
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

        static public int DruhyNejvetsi(List<int> pole, out int poradi1)
        {
            List<int> p = pole.ToList();
            p.Sort();
            int delka = p.Count;
            int max2 = p[delka - 2];
            poradi1 = pole.IndexOf(max2)+1;
            return max2;
        }
    }
}
