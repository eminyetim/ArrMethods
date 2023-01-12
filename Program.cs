using System;

class program
{
    public static void Main(string[] args)
    {
        int[] numberArray = {5 , 4 , 3 , 8 , 12 , 25 ,61};
        
        System.Console.WriteLine("** Unordered List **");
        foreach (var item in numberArray)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("**Ordered List**");
        Array.Sort(numberArray);
        foreach (var item in numberArray)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("**Clear**");
        Array.Clear(numberArray,2,2);
        foreach (var item in numberArray)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("**Reverse**");
        Array.Reverse(numberArray);
        foreach (var item in numberArray)
        {
            System.Console.WriteLine(item);
        }
   
        System.Console.WriteLine("**Index Of**");
        System.Console.WriteLine(Array.IndexOf(numberArray,3));

        System.Console.WriteLine("**Resize**");
        Array.Resize<int>(ref numberArray , 15);
        numberArray[13] =88;
        foreach (var item in numberArray)
        { 
            System.Console.WriteLine(item);
        }
    }
    
}