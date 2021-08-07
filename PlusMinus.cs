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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        int plusCount,minusCount,zeroCount,arrLength;
        float plusRatio,minusRatio,zeroRatio;
        plusCount=minusCount=zeroCount=0;
        arrLength=arr.Length;
        for (int i = 0; i<arrLength; i++)
        {
            if (arr[i]>0)
                plusCount++;
            else if (arr[i]==0)
                zeroCount++;
            else
                minusCount++;

        }
        plusRatio=(float)plusCount/arrLength;
        minusRatio=(float)minusCount/arrLength;
        zeroRatio=(float)zeroCount/arrLength;
        Console.Out.WriteLine(String.Format("{0:0.000000}",plusRatio));
        Console.Out.WriteLine(String.Format("{0:0.000000}",minusRatio));
        Console.Out.WriteLine(String.Format("{0:0.000000}",zeroRatio));



    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
