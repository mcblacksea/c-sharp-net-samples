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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        var distinctValues = arr.Distinct();


        if (distinctValues.Count() <= 1)
        {
            var zeroNumber = arr[0];
            var sum = arr.Sum() - zeroNumber;
            Console.WriteLine($"{sum} {sum}");
        }
        else
        {
            var minNumber = arr.Min();
            var maxNumber = arr.Max();
            var minArr = arr.Where(v => v != maxNumber).ToList().Sum();
            var maxArr = arr.Where(v => v != minNumber).ToList().Sum();
            Console.WriteLine($"{minArr} {maxArr}");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList<long>();

        var notInRangeNumber = arr.Where(v => v < 1 || v > Math.Pow(10, 9)).Count();
        if (notInRangeNumber > 0)
        {
            Console.WriteLine("array contains number, which is not in range: 1<=arr[i]<=10^9pow");
            return;
        }
        Result.miniMaxSum(arr);
    }
}