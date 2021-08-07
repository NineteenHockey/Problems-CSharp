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

    // Complete the staircase function below.
    static void staircase(int n) {
        //int length = stringLng(n);
        for (int i =1; i<=n; i++)
            {
                Console.WriteLine(oneLineOneWord(i, n));
            }


    }

    static int stringLng(int n)
    {
        return (n-1)*2+1;
    }

    static string oneLineOneWord(int step, int length)
    {
        return new String(' ',length-step)+new String('#',step);
    }

    static string oneLine(int step, int length)
    {
        StringBuilder sb = new StringBuilder();
        int spaces = length - stringLng(step);
        int i;
        bool sym=true;
        for (i=0; i<spaces; i++)
        {
            sb.Append(" ");
        }
        for (i=spaces; i<length;i++)
        {
            if (sym)
                sb.Append("#");
            else
                sb.Append(" ");
            sym=!sym;
        }
        return sb.ToString();
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
