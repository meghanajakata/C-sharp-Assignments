using System;
using System.Collections.Generic;

/// <summary>
/// Represents the definition of Substring Occurrence
/// </summary>
public class SubStringCount
{
    /// <summary>
    /// Counts the occurrence of the substring
    /// </summary>
    /// <param name="firstString"></param>
    /// <param name="secondString"></param>
    /// <returns>
    /// Returns the list of indices where the where the substring has occurred
    /// </returns>
    public List <int>  CountOccurrence(string firstString, string secondString)
    {
        String temp;
        int count = 0;
        List<int> indices = new List<int>();
        Utilities stringObject = new Utilities();

        for (int i = 0; i <= (firstString.Length) - (secondString.Length); i++)
        {
            temp = stringObject.Substring(firstString, i,secondString.Length);
            if (temp == secondString)
            {
                count++;
                indices.Add(i);
            }
        }
        return indices;
    }
}

