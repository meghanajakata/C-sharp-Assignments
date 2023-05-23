using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString
{
    public class SubStringCount
    {
        public String original;
        public String sub;
        public List<int> indices = new List<int>();
        public int count;
        public SubStringCount(String s1, String s2)
        {
            original = s1;
            sub = s2;   
        }
        public void Count()
        {
            int prev = 0, index = 0;
            String temp;
            for (int i = 0; i <= (original.Length) - (sub.Length); i++)
            {
                temp = original.Substring(i);
                if (temp.StartsWith(sub))
                {
                    count++;
                    indices.Add(i);
                }
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            String s1;
            String s2;
            Console.Write("Enter a string: ");
            s1 = Console.ReadLine();
            Console.Write("Enter a substring: ");
            s2 = Console.ReadLine();
            SubStringCount o = new SubStringCount(s1, s2);
            o.Count();
            Console.WriteLine("No: of times occurred " + o.count);
            Console.Write("Index positions: ");
            for (int i = 0; i < o.indices.Count; i++)
            {
                Console.Write(o.indices[i] + " ");
            }
        }
    }
}
