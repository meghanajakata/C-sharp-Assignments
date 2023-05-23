using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MaxProduct
{
    public class Product 
    {
        public long max_pdt = 1;
        public string num;
        int left = 0, right = 4;
        public Product(String num)
        { 
            this.num = num; 
        }
        public void Calculate()
        {
            long  pdt = 1;
            int val;
            if (num.Length < 4)
            {
                max_pdt = 0;
                return;
            }
            for(int i=0; i<4; i++)
            {
                val = Convert.ToInt32(num[i]) - 48;
                max_pdt = max_pdt * val;
            }
            pdt = max_pdt;
            Console.WriteLine(pdt);
            for(; right < num.Length && left < right ;)
            {
                val =  Convert.ToInt32(num[left++] - 48);
                pdt = pdt / val;
                val = Convert.ToInt32(num[right++] - 48);
                pdt = pdt * val;
                Console.WriteLine(pdt);

                max_pdt = Math.Max(max_pdt, pdt);
            }
            Console.Write(max_pdt);
            
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String num;
            num = Console.ReadLine();
            Product p = new Product(num); 
            Console.WriteLine(num);
            p.Calculate();
        }
    }
}
