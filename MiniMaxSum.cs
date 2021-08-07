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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long min, max,sum;
        min=max=0;
        for (int i=0; i<arr.Length; i++)
            {
                sum =0;
                for (int j=0; j<arr.Length; j++)
                {
                    if (i!=j)
                        sum+=arr[j];
                }
                if (sum>max)
                    max=sum;
                if (sum<min||i==0) // assign to min maximum value of the type?
                    min=sum;
            }
            Console.WriteLine(min+" "+max);
                


    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
