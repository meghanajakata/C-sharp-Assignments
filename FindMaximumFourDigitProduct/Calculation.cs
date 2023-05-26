using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents the Maximum Product of 4 digits for the given number
/// </summary>
public class ProductOfDigits
{
    /// <summary>
    /// Calculates the Maximum 4 digit product in the given number
    /// </summary>
    /// <param name="number"></param>
    /// <returns>
    /// Returns a list of digits which contribute to 
    /// </returns>
    public List<int> CalculateProduct(string number)
    {
        int maximumProduct = 1;
        int currentProduct = 1;
        int left = 0, right = 3;
        List<int> digits = new List<int>();
        // Loop to check the very possible 4 digit number 
        for (int i = 0; i < number.Length - 3; i++)
        {
            currentProduct = (number[i] - 48) * (number[i + 1] - 48) * (number[i + 2] - 48) * (number[i + 3] - 48);
            if (currentProduct > maximumProduct)
            {
                left = i;
                right = i + 3;
                maximumProduct = currentProduct;
            }
        }

        for (int iterator = left; iterator <= right; iterator++)
        {
            digits.Add(number[iterator] - 48);
        }

        // Return the digits list
        return digits;
    }
}
