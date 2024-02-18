using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public class Recursiondate
    {
        static List<int> simple = new List<int>();
        public void Recursion(int H)
        {
            {
                int n = H;
                bool f = false;
                for (int i = 2; i < 1000; i++)
                {
                    foreach (int s in simple)
                    {
                        f = i % s == 0;
                        if (f) break;
                    }
                    if (!f) simple.Add(i);
                    f = false;
                }
                Denum(n);
            }
        }
        static void Denum(int n)
        {
            if (simple.Contains(n)) Console.Write("{0}\t", n);
            else
            {
                foreach (int s in simple)
                {
                    if (n % s == 0)
                    {
                        Console.Write("{0}\t", s);
                        Denum(n / s);
                        break;
                    }
                }
            }
        }
    }
}
