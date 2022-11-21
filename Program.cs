using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection;

class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        double[] X = Array.ConvertAll<string, double>(input.Split(" "), double.Parse);
        double a = X[0];
        double b = X[1];
        double min = -32.768;
        double max = 32.767;




        

        
       for (double i = a; i < b - 1; i++)
        {
            Console.Write($"{i + 1} ");
            
        }
        /*(a == b || a + 1 > b || a - 1 < b || b + 1 > a || b - 1 < a)
        {
            Console.WriteLine("Empty");
        }
        /*if (b - a <= 11 && a + b >= 11)
         {
             if (a < b)
             {



                 /*for (double i = a; i < b - 1; i++)
                 {
                     Console.Write($"{i + 1} ");
                 }
                 */
        /*for (double j = a; j <= 11; j++)
        {

            Console.WriteLine($"{j + 1},{j + 2},{j + 3}, ..., {b - 2},{b - 1}");
            break;
        }
        */









        // }

        //}










    }
}
