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

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        // 24 hour format -- use 'H' or 'HH' instead of hh (12h format)
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // e.g.: 07:05:45PM
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}