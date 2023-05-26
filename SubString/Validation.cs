/// <summary>
/// Represents the methods defining criteria for the input
/// </summary>
public class Validation
{
    /// <summary>
    /// Checks whether the given input is valid or not
    /// </summary>
    /// <param name="firstString"></param>
    /// <param name="secondString"></param>
    /// <returns>
    /// Returns a boolean 
    /// </returns>
    
    public bool IsValidInput(string firstString, string secondString) 
    {
        string message = "";
        LogMessages messageObject = new LogMessages();
        if (firstString == string.Empty)
        {
            message = "Enter the first string ";
            messageObject.Write(message);
            return false;
        }
        if(secondString == string.Empty) 
        {
            message = "Enter the second string ";
            messageObject.Write(message);
            return false;
        }
        if(secondString.Length > firstString.Length)
        {
            message = "Make sure first string is larger than second ";
            messageObject.Write(message);
            return false;
        }
        return true;
    }
}
