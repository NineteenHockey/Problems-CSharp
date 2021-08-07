using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
         string result="";
         byte hours;
         string minsSecs;

         byte.TryParse(s.Substring(0,2), out hours);

         if (s.EndsWith("AM"))
         {
             if (hours!=12)
                result = s.Remove(s.Length-2);
            else
                result="00"+s.Remove(s.Length-2, 2).Remove(0,2);
         }
         else 
        {
            if (hours!=12)
            {

                hours+=12;
            }
            result=hours+s.Remove(s.Length-2, 2).Remove(0,2);
        }
            
        
         
         return result;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
