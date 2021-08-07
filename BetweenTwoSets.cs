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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int maxA, maxB,currentNumber,countRights;
        bool isRight;
        maxA=maxB=countRights=0;
        foreach (int i in a)
        {
            if (i>maxA)
                maxA=i;
        }
        foreach(int i in b)
        {
            if (i>maxB)
                maxB=i;
        }
        currentNumber=maxA;
        do 
        {
            isRight = true;
            foreach (int i in a)
            {
                if (currentNumber%i != 0)
                {
                    isRight=false;
                    break;
                }
            }
            if (isRight)
                foreach(int i in b)
                    if (i%currentNumber !=0)
                    {
                        isRight=false;
                        break;
                    }

            if (isRight)
                countRights++;
            currentNumber+=maxA;    
        }   while (currentNumber<=maxB);

        return countRights;


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
