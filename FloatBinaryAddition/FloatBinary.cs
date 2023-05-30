using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatBinaryAddition
{
    /// <summary>
    /// Represents the Binary addition of a float with Mantissa and exponent
    /// </summary>
    public class FloatBinary
    {
        /// <summary>
        /// Adds the given two float binary values
        /// </summary>
        /// <param name="firstBinary"></param>
        /// <param name="secondBinary"></param>
        /// <returns>
        /// Returns the binary string after adding the binary float
        /// </returns>
        public string AddBinaryFloat(string firstBinary, string secondBinary)
        {
            String obj = new String();
            int partition = obj.MaxStringLength(firstBinary.Split('.')[0], secondBinary.Split('.')[0]);
            string firstMantissa = GetMantissa(firstBinary, secondBinary, 1);
            string secondMantissa = GetMantissa(firstBinary, secondBinary, 2);
            firstMantissa = firstMantissa + (firstBinary.Split('.'))[1];
            Console.WriteLine("firstMantissa" + firstMantissa);

            secondMantissa = secondMantissa + (secondBinary.Split('.')[1]);
            Console.WriteLine("secondMantissa" + secondMantissa);

            if (firstMantissa.Length > secondMantissa.Length)
            {
                secondMantissa = secondMantissa + Normalize(firstMantissa.Length - secondMantissa.Length);
            }
            else
            {
                firstMantissa = firstMantissa + Normalize(secondMantissa.Length - firstMantissa.Length);
            }
            Console.WriteLine(firstMantissa + '\n' + secondMantissa);
            string result = AddMantissa(firstMantissa, secondMantissa, partition);
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// Converts the float number to its mantissa
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="i"></param>
        /// <returns>
        /// Returns the  binary string Mantissa of the given Binary
        /// </returns>
        public string GetMantissa(string first, string second, int i)
        {
            string firstTemp = first.Split('.')[0];
            string secondTemp = second.Split('.')[0];
            if (firstTemp.Length > secondTemp.Length)
            {
                secondTemp = Normalize(firstTemp.Length - secondTemp.Length) + secondTemp;
            }
            else if (secondTemp.Length > firstTemp.Length)
            {
                firstTemp = Normalize(secondTemp.Length - firstTemp.Length) + firstTemp;
            }
            if (i == 1) return firstTemp;
            return secondTemp;
        }

        /// <summary>
        /// Creates a string with 0's
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        /// Returns the string of 0's of the given length
        /// </returns>
        public string Normalize(int number)
        {
            string normalizedString = "";
            for (int i = 0; i < number; i++)
            {
                normalizedString += "0";
            }
            return normalizedString;

        }

        /// <summary>
        /// Adds the Mantissa of the given two binary strings
        /// </summary>
        /// <param name="firstMantissa"></param>
        /// <param name="secondMantissa"></param>
        /// <param name="partition"></param>
        /// <returns>
        /// Returns the binary string after the addition of mantissa
        /// </returns>
        public string AddMantissa(string firstMantissa, string secondMantissa, int partition)
        {
            int sum, carry = 0;
            int a, b;
            string result = "";
            for (int i = firstMantissa.Length - 1; i >= 0; i--)
            {
                a = firstMantissa[i] - '0';
                b = secondMantissa[i] - '0';
                sum = a ^ b ^ carry;
                result = result + sum;
                carry = (a & b) | (a & carry) | (b & carry);
            }
            String obj = new String();
            if (carry == 1)
            {
                partition += 1;
                result = result + carry;
            }
            result = obj.Reverse(result);
            result = result.Substring(0, partition) + '.' + result.Substring(partition);
            return result;
        }
    }
}
