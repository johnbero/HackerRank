﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        string output = string.Empty;

        for(int i = n-1; i >= 0; i--)
        {
            if (i == 0)
            {
                output += arr[i];
            }
            else
            {
                output += arr[i] + " ";
            }
        }
        Console.WriteLine(output);
        Console.ReadLine();
    }
}