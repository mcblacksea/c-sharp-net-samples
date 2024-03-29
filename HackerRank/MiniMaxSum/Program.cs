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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<List<int>> data, List<int> arr)
    {
        List<int> result = new List<int>();

        foreach (var query in arr)
        {
            var inCacheCurrent = 0;
            var inCacheTotal = 0;

            foreach (var lst in data)
            {
                var current = 0;
                var previous = 0;
                inCacheCurrent = 0;

                foreach (var item in lst)
                {
                    current = item;
                    if(previous == current)
                    {
                        continue;
                    }

                    if(previous + current > query)
                    {
                        inCacheCurrent += 1;
                    }

                    previous = current;
                }
                inCacheTotal += inCacheCurrent;
            }

            result.Add(inCacheTotal);
            inCacheTotal = 0;
        }


        //var distinctValues = arr.Distinct();


        //if (distinctValues.Count() <= 1)
        //{
        //    var zeroNumber = arr[0];
        //    var sum = arr.Sum() - zeroNumber;
        //    Console.WriteLine($"{sum} {sum}");
        //}
        //else
        //{
        //    var minNumber = arr.Min();
        //    var maxNumber = arr.Max();
        //    var minArr = arr.Where(v => v != maxNumber).ToList().Sum();
        //    var maxArr = arr.Where(v => v != minNumber).ToList().Sum();
        //    Console.WriteLine($"{minArr} {maxArr}");
        //}
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList<long>();

        //var notInRangeNumber = arr.Where(v => v < 1 || v > Math.Pow(10, 9)).Count();
        //if (notInRangeNumber > 0)
        //{
        //    Console.WriteLine("array contains number, which is not in range: 1<=arr[i]<=10^9pow");
        //    return;
        //}
        Result.miniMaxSum(
            new List<List<int>>() 
            { 
                 new List<int>() { 12, 11 },
                 new List<int>() { 22, 21 },
                 new List<int>() { 21, 32 },
                 new List<int>() { 21, 42 },
            },
            new List<int>()
            {
                50, 40
            });
    }
}
/**
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Example

The minimum sum is  and the maximum sum is . The function prints

16 24
Function Description

Complete the miniMaxSum function in the editor below.

miniMaxSum has the following parameter(s):

arr: an array of integers
Print

Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

Input Format

A single line of five space-separated integers.

Constraints


Output Format

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

Sample Input

1 2 3 4 5
Sample Output

10 14
Explanation

The numbers are , , , , and . Calculate the following sums using four of the five integers:

Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Hints: Beware of integer overflow! Use 64-bit Integer.
**/