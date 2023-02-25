using System.CodeDom.Compiler;
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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int elementsCount = arr.Count;
        int positiveNumbers = arr.Where(_ => _ > 0).Count();
        int negativeNumbers = arr.Where(_ => _ < 0).Count();
        int zeroNumbers = arr.Where(_ => _ == 0).Count();
        decimal positiveNumbersProportion = Decimal.Divide(positiveNumbers, elementsCount);
        var negativeNumbersProportion = Decimal.Divide(negativeNumbers, elementsCount);
        var zeroNumbersProportion = Decimal.Divide(zeroNumbers, elementsCount);
        Console.WriteLine($"{positiveNumbersProportion:N6}\r\n{negativeNumbersProportion:N6}\r\n{zeroNumbersProportion:N6}");

    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        if (n < 0 || n > 100)
        {
            Console.WriteLine("Array size number is not in range. Should be within the following range: 0 < n <= 100");
            return;
        }

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        if (arr.Count > n || arr.Count < n) 
        {
            Console.WriteLine($"Array size is incorrect. Should be {n} integer numbers");
            return;
        }

        int valueNotInRange = arr.Where(el => el < -100 || el > 100).Count();

        if (valueNotInRange > 0)
        {
            Console.WriteLine("Array contains value, which is not in range: -100 <= arr[i] <= 100");
            return;
        }

        Result.plusMinus(arr);
    }
}
