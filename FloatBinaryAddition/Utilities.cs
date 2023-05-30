using System;

/// <summary>
/// Represents the utilities of the string 
/// </summary>
public class String
{
    /// <summary>
    /// Reverses the given string
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    /// Returns the reversed string
    /// </returns>
    public string Reverse(string value)
    {
        string temp = "";
        for (int i = value.Length - 1; i >= 0; i--)
        {
            temp = temp + value[i];
        }
        return temp;
    }

    /// <summary>
    /// Checks the maximum length between two given strings
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns>
    /// Returns the maximum length of the given strings
    /// </returns>
    public int MaxStringLength(string first, string second)
    {
        return first.Length > second.Length ? first.Length : second.Length;
    }
}
/// <summary>
/// Represents the utilities of Numeric
/// </summary>
public class Numeric
{
    /// <summary>
    /// Converts the given int/float to binary
    /// </summary>
    /// <param name="Integer"></param>
    /// <returns>
    /// Returns the binary string of the given int/float
    /// </returns>
    public string ToBinary(string Integer)
    {
        string wholeFirstNumber, decimalFirstNumber;
        wholeFirstNumber = Integer.Split('.')[0];
        Validation validObject = new Validation();
        bool isValid = validObject.isDecimal(Integer);
        decimalFirstNumber = isValid == true ? "0." + Integer.Split('.')[1] : "0.0";

        String obj = new String();

        string result = "";
        float decNumber = float.Parse(decimalFirstNumber);
        int intNumber = Convert.ToInt32(wholeFirstNumber);
        while (intNumber > 0)
        {
            result = result + (intNumber % 2);
            intNumber = intNumber / 2;
        }
        result = obj.Reverse(result) + '.';
        while (decNumber != 0)
        {
            decNumber = decNumber * 2;
            result = result + (int)(decNumber / 1);
            decNumber = decNumber % 1;
        }
        return result;
    }

    /// <summary>
    /// Converts the given binary input to decimal
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public double ToDecimal(string value)
    {
        string integer, dec;
        integer = value.Split('.')[0];
        dec = value.Split('.')[1];
        int a; double powerValue; long sum = 0;
        for (int i = 0; i < integer.Length; i++)
        {
            a = integer[i] - '0';

            powerValue = Math.Pow(2, (integer.Length - i - 1));
            powerValue = powerValue * a;
            sum += (long)powerValue;
        }
        double decSum = 0;
        for (int i = 0; i < dec.Length; i++)
        {
            a = dec[i] - '0';
            powerValue = Math.Pow(2, (-1 * (i + 1)));
            powerValue = powerValue * a;
            decSum += powerValue;
        }
        decSum = sum + decSum;

        return decSum;
    }
}

