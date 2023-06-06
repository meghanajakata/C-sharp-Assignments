/// <summary>
/// Represents the string methods
/// </summary>
public class Utilities
{
    /// <summary>
    /// Generates a substring from the given string of certain length
    /// </summary>
    /// <param name="input"></param>
    /// <param name="startIndex"></param>
    /// <param name="noOfChar"></param>
    /// <returns>
    /// Returns a substring
    /// </returns>
    public string Substring(string input, int startIndex, int noOfChar)
    {
        string result = "";
        for(int i=startIndex; i < startIndex+noOfChar;  i++) 
        {
            result += input[i];
        }
        return result;
    }

    
}
