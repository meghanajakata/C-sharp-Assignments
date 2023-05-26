using System;
using System.Collections.Generic;


namespace FindMaximumFourDigitProduct
{
    public class MainClass
    {
        static void Main()
        {
            string number;
            List<int> result = new List<int>();
            int maximumProduct = 1;
            number = Console.ReadLine();
            Validation validnumber = new Validation();
            bool isValid = validnumber.CheckValidation(number);

            // If the number is not valid prints the statement and returns 
            if (isValid == false)
            {
                return;
            }

            ProductOfDigits userNumber = new ProductOfDigits();
            result = userNumber.CalculateProduct(number);

            for (int i = 0; i < result.Count; i++)
            {
                if (i == result.Count - 1) Console.Write(result[i] + "=");
                else Console.Write(result[i] + "*");
                maximumProduct = maximumProduct * result[i];
            }

            Console.WriteLine(maximumProduct);
        }
    }
}
