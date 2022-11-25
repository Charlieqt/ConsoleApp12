using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection;

class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int[] X = Array.ConvertAll<string, int>(input.Split(" "), int.Parse);
        int a = X[0];
        int b = X[1];


        if (a == b || a + 1 == b || b + 1 == a)
        {
            Console.WriteLine("Empty");
        }
        else
        {

            while (b > a)
            {
                if (b - a >= 10 && a + b >= 10)
                {
                    Console.WriteLine($"{a + 1},{a + 2},{a + 3},...,{b - 2},{b - 1}");

                    a++;
                    break;
                }
                else if (a + b >= -10 || a + b <= -10)
                {
                    Console.WriteLine($"{a + 1},{a + 2},{a + 3},...,{b - 2},{b - 1}");

                    a++;
                    break;
                }
                break;  
            }

            while (a < b)
            {
                if (b - a >= 5 && a + b >= 5)
                {
                    Console.WriteLine($"{a + 1},{a + 2},{a + 3},{a + 4}");

                    a++;
                    break;
                }
                else if (b + a >= -5 || b <= 0 || b + a >= -5 || b <= 0)
                {
                    Console.WriteLine($"{a + 1},{a + 2},{a + 3},{a + 4}");

                    a++;
                    break;
                
                }
                break;
            }
                
            






        }
















    }

}
