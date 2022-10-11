using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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


        static public void Vypis(ListBox k, List<int> pole)
        {
            k.Items.Clear();
            for (int i = 0; i < pole.Count; i++)
            {
                k.Items.Add(pole[i]);
            }
        }
        static public List<int> Vymaz(List<int> pole, int k)
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
        static public List<int> Lambda(List<int> pole, int k)
        {
            pole.RemoveAll(a => a == k);
            return pole;
        }
        static public int Druhe_maximum(List<int> pole, out int poradi)
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

        static public List<int> Poradi_min_cisel(List<int> pole)
        {
            int min = pole.Min();
            List<int> test = new List<int>();
            for (int i = 0; i < pole.Count; i++)
            {
                if (min == pole[i])
                {
                    test.Add(i+1);
                }
            }
            return test;
        }
        static public List<int> AritPosloupnost(List<int> pole, int n,int a1, int d)
        {
            for (int i = 0; i < n; i++)
            {
                pole.Add(a1);
                a1 += d;
            }
            return pole;

        }

        static public List<int> Pridani(List<int> pole, int n)
        {
            int d = pole[pole.Count - 1] - pole[pole.Count - 2];
            int a1 = pole[pole.Count-1];
            a1 += d;
            AritPosloupnost(pole, n, a1, d);
            return pole;
        }
        static public List<int> Vytvor(int n, int a1, int d)
        {
            List<int> r = new List<int>();
            AritPosloupnost(r, n, a1, d);   
            return r;
        }


        static public List<double> Posloupnost_gon(List<double> pole, int n, double a1, double a2)
        {
            pole.Add(a1);
            pole.Add(a2);
            double posloupnost = pole[1] / pole[0];
            double dalsi_prvek;
            for (int i = 2; i<n; i++)
            {
                dalsi_prvek = pole[pole.Count-1] * posloupnost;
                pole.Add(dalsi_prvek);
            }
            return pole;
        }

        static public List<double> Vytvor_gon(int n, double a1, double a2)
        {
            List<double> r = new List<double>();
            Posloupnost_gon(r, n, a1, a2);
            return r;
        }
        static public void Vypis(ListBox k, List<double> pole)
        {
            k.Items.Clear();
            for (int i = 0; i < pole.Count; i++)
            {
                k.Items.Add(pole[i]);
            }
        }

        static public bool Soucet_prvku(List<double> pole,int p, out double soucet)
        {
            soucet = 0;
            if (p <= pole.Count)
            {
                for (int i = 0; i < p; i++)
                {
                    soucet += pole[i];
                }

                return true;
            }
            else
            {
                return false;
            }
            
        }



        static public void Vypis(ListBox k, List<char> pole)
        {
            k.Items.Clear();
            for (int i = 0; i < pole.Count; i++)
            {
                k.Items.Add(pole[i]);
            }
        }

        static public List<char> Vytvor_char(TextBox test)
        {
            List<char> result = new List<char>();
            for (int i = 0; i < test.Lines.Count(); i++)
            {
                result.Add(test.Lines[i][0]);
            }
            return result;
        }

        static public List<char> Vypustit(List<char> pole)
        {
            int i = 0;
            while (i < pole.Count)
            {
                if (pole[i] >= 'a' && pole[i]<='z' || char.IsDigit(pole[i]))
                {
                    pole.Remove(pole[i]);
                }else
                {
                    i++;
                }

            }
            return pole;
        }

        static public List<int> Prohození(List<int> pole, out int min, out int max)
        {
            min = Int32.MaxValue;
            max = Int32.MinValue;
            int pozice_max = 0;
            int pozice_min = 0;
            for (int i = 0; i < pole.Count; i++)
            {
                if (pole[i] % 2 == 0) {
                    if (max < pole[i]) {
                        max = pole[i];
                        pozice_max = i;
                    }
                }
                else
                {
                    if (pole[i] % 3 == 0)
                    {
                        if (min > pole[i]) { 
                            min = pole[i];
                            pozice_min = i;
                        }
                    }
    
                }
            }
            if (min != Int32.MaxValue && max != Int32.MinValue) { 
                pole[pozice_max] = min;
                pole[pozice_min] = max;
            }
            return pole;
        }
    }
}
