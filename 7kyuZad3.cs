using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        // Convert the number to a string to iterate over each digit
        string numberString = n.ToString();
        
        // Use LINQ to square each digit and concatenate the results
        string resultString = string.Concat(numberString.Select(c => (int)Math.Pow(char.GetNumericValue(c), 2)));
        
        // Convert the concatenated string back to an integer
        return int.Parse(resultString);
    }
}
