using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Runtime.CompilerServices;

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter first number: ");
        int first_num = int.Parse(Console.ReadLine());  

        Console.WriteLine("Enter second number: ");
        int sec_num = int.Parse(Console.ReadLine()); 

        int sum = first_num + sec_num;

        Console.WriteLine($"Sum = " + sum);
    }
}

    
        

    

