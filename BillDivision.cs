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

    // Complete the bonAppetit function below.
    static void bonAppetit(List<int> bill, int k, int b) {
        int sum = 0;
        for (int i = 0; i<bill.Count; i++)
            if (i!=k)
                sum+=bill[i];
        int difference=b-(sum/2);

        if (difference==0)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(difference);

    }

    static void Main(string[] args) {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}
