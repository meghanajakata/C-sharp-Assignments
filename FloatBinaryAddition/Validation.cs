
/// <summary>
/// Represents the validation checks for the given input
/// </summary>
public class Validation
{
    /// <summary>
    /// Checks whether the given input matches the criteria 
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns>
    /// Returns true if it satisfies the condition
    /// </returns>
    public bool checkValidation(string first, string second)
    {
        LogMessages log = new LogMessages();
        if (first == string.Empty || second == string.Empty)
        {
            log.Write("Please enter the  number");
            return false;
        }
        return true;
    }

    /// <summary>
    /// Checks whether the given input is decimal/float
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    /// Returns true if it is a decimal
    /// </returns>
    public bool isDecimal(string value)
    {
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == '.')
            {
                return true;
            }
        }
        return false;
    }
}

