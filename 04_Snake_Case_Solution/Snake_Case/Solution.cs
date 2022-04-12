namespace Snake_Case;
using System.Text;
using System;

public class Solution
{


    public static string SnakeCase(string str)
    {
        // code goes here  
        string[] delimiters = { " ", "-", "*", ".", ",", "%" };
        StringBuilder result = new StringBuilder();


        for (int i = 0; i < str.Length; i++)
        {

            if (Array.Exists(delimiters, e => e == str[i].ToString()))
            {
                Console.Write(str[i]);
                result.Append("_");
            }
            else
            {
                result.Append(str[i].ToString().ToLower());
            }
        }

        return result.ToString();

    }
}
