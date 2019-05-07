using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public string GetEvensAndOdds(string s)
    {
        string temp0 = string.Empty;
        string temp1 = string.Empty;
        string output = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                temp0 += s[i];
            }
            else
            {
                temp1 += s[i];
            }
        }

        output = temp0 + " " + temp1;

        return output;
    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        string s;
        Solution output = new Solution();

        for (int i = 0; i < t; i++)
        {
            s = Console.ReadLine();
            Console.WriteLine(output.GetEvensAndOdds(s));
        }

        Console.ReadLine();
    }
}

