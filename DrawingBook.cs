using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        int beginning, end;
        if (p==1 || p==n|| (p==n-1 && (p % 2) ==0))
            return 0;
        //else if (p==n-1 && (n %2)==1)
        //    return 1;
        else
        {
            beginning = p/2;
            end = (n-p)/2;
            if ((n-p)==1)
                end=1;
            if (beginning<end)
                return beginning;
            else
                return end;
        }
            
        /*
         * Write your code here.
         */

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
