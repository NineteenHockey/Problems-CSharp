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

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year) {
        int withoutFebruary=31+31+30+31+30+31+31;
        int leapYearDays=withoutFebruary+29;
        int usualYearDays=withoutFebruary+28;
        int afterRevolutionYear=withoutFebruary+28-13;
        int day;

        if (year==1918)
        {
            day=256 - afterRevolutionYear;
        }
        else if (leapYear(year))
        {
            
            day = 256-leapYearDays;
        }
        else
        {
            day=256-usualYearDays;
        }

        return day+".09."+year;



    }

    static bool leapYear(int year)
    {
        if ((year%4) !=0)
            return false;
        else if ((year>1918)&&(year%100)==0 && (year%400)!=0)
            return false;
        else
            return true;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
