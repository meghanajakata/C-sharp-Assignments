using System;

namespace MaximumFourDigitProduct
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            String number;
            number = Console.ReadLine();
            FindProduct user = new FindProduct(number);
            Console.WriteLine(number);
            int result = user.CalculateProduct(number);
            Console.Write(result);
        }
    }
}
