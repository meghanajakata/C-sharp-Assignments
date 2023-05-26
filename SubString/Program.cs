using System;
using System.Collections.Generic;
using FindMaximumFourDigitProduct;

namespace SubStringOccurrence
{

    public class Program
    {
        static void Main()
        {
            String firstString;
            String secondString;
            List<int> indices = new List<int>();

            LogMessages log = new LogMessages();
            log.Write("Enter a string: ");
            firstString = Console.ReadLine();
            log.Write("Enter a substring: ");
            secondString = Console.ReadLine();

            Validation validObject = new Validation();  

            // Checks whether the given input meets the criteria
            bool isValid = validObject.IsValidInput(firstString, secondString);
            if(isValid == false) 
            {
                return;
            }

            SubStringCount stringObject = new SubStringCount();
            indices = stringObject.CountOccurrence(firstString,secondString);
            log.Write("No: of Occurances: " + indices.Count);
            Console.Write("Index positions: ");
            for (int i = 0; i < indices.Count; i++)
            {
                Console.Write(indices[i] + " ");
            }
        }
    }
}
