/// <summary>
/// Represents the validation 
/// </summary>
public class Validation
{
    /// <summary>
    /// Checks whether the input by the user matches the criteria
    /// </summary>
    /// <param name="number"></param>
    /// <returns>
    /// Returns true if the input satisfy the criteria and false if it doesn't match
    /// </returns>
    public bool CheckValidation(string number)
    {
        LogMessages message = new LogMessages();

        // Checks whether the given input is negative number (or) If the string is empty
        if (number == string.Empty)
        {
            message.Write("Please enter a number");
            return false;
        }
        if (number[0] == '-')
        {
            message.Write("Please enter a positive number");
            return false;
        }

        // Checks whether the given number contains characters 
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < '0' || number[i] > '9')
            {
                message.Write("Please enter a number (0-9)");
                return false;
            }
        }

        return true;
    }
}
