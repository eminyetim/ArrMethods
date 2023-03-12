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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int again = 0;
        int againBefore = 0;
        foreach (var item in arr)
        {   
            
            if(againBefore < again)
            {
                againBefore = again;
            }
            again = 0;
            foreach (var item2 in arr)
            {
                
                if(item == item2)
                {
                    again++;
                }    
            }         
        }
        return againBefore;
    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        // //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        // int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        // int result = Result.migratoryBirds(arr);
        // System.Console.WriteLine(result);
        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();


        string[] numbers = new string[10];
        numbers[0] = "0";
        numbers[1] = "1";
        numbers[2] = "2";
        numbers[3] = "3";
        numbers[2] = null;


        
        

       for(int i = 0 ;  i < numbers.Count() ; i++)
       {
            if(numbers[i] != null)
            {
                System.Console.WriteLine(numbers[i]);
            }
            
       }
                
    }
}
