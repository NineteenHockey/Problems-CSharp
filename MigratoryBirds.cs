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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        int[] frequencyTable = new int[5];
        int maxFrequency;
        int maxFrequencyInd;
        foreach (int b in arr)
        {
            frequencyTable[b-1]++;
        }
        maxFrequency=frequencyTable[0];
        maxFrequencyInd=0;
        for (int i =1; i<5;i++)
        {
            if (frequencyTable[i]>maxFrequency)
            {
                maxFrequency=frequencyTable[i];
                maxFrequencyInd=i;
            }
        }
        return maxFrequencyInd+1;



    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
