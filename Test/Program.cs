using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //testSequence(@"[^a-zA-Z0-9æøåÆØÅ\.\-@ ]+", new string[] { "AnDeRs", "æøå", "ÆØÅ", "aa-aa", "aa.aa", "aa@aa", "6534/gksdfl","aa aa" });
            var l = new List<int>();
          for(int i=0;i<7;i++)
          {
              l.Add(i);
          }
          foreach (int s in l)
              Console.WriteLine(s);
          Console.WriteLine("remove");
            l.RemoveRange(7-2+1,2-1);
            foreach(int s in l)
                Console.WriteLine(s);
                            
        }

        public static void testSequence(string pattern,string[] texts)
        {
            int i=1;
            foreach(string s in texts)
            {
                Match m = Regex.Match(s,pattern);
            
            if (m.Success)
                Console.WriteLine("YUS"+i);
            else
                Console.WriteLine("FAK"+i);
            i++;
            }
        }
    }
}
