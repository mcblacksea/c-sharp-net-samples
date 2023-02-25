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
/***
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

Example

There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:

0.400000
0.400000
0.200000
Function Description

Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

int arr[n]: an array of integers
Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe .

Constraints



Output Format

Print the following  lines, each to  decimals:

proportion of positive values
proportion of negative values
proportion of zeros
Sample Input

STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
Sample Output

0.500000
0.333333
0.166667
Explanation

There are  positive numbers,  negative numbers, and  zero in the array.
The proportions of occurrence are positive: , negative:  and zeros: .

***/