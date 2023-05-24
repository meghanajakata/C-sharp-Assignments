using System;

namespace MaximumFourDigitProduct
{
    public class FindProduct
    {
        public long max_pdt = 1;
        public string num;
        int left = 0, right = 4;

        public int CalculateProduct(string number)
        {
            return number.Length();
            /*
            int currentProduct = 1;
            int value;
            int maximumProduct = 1;
            int left = 0, right = 4;

            for (int i = 0; i < 4; i++)
            {
                value = Convert.ToInt32(num[i]) - 48;
                maximumProduct = maximumProduct * value;
            }
            currentProduct = maximumProduct;

            while (right < number.Length && left < right)
            {
                value = Convert.ToInt32(num[left++] - 48);
                currentProduct = currentProduct / value;
                value = Convert.ToInt32(num[right++] - 48);
                currentProduct = currentProduct * value;
                maximumProduct = Math.Max(maximumProduct, currentProduct);
            }*/

        }
    }
}