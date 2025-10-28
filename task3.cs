using System;

class Program
{
    static void Main()
    {
        string name1, name2, name3;
        int grade1, grade2, grade3;
        double average;

        Console.Write("Enter name of student 1: ");
        name1 = Console.ReadLine();
        Console.Write("Enter grade of " + name1 + ": ");
        grade1 = int.Parse(Console.ReadLine());

        Console.Write("Enter name of student 2: ");
        name2 = Console.ReadLine();
        Console.Write("Enter grade of " + name2 + ": ");
        grade2 = int.Parse(Console.ReadLine());

        Console.Write("Enter name of student 3: ");
        name3 = Console.ReadLine();
        Console.Write("Enter grade of " + name3 + ": ");
        grade3 = int.Parse(Console.ReadLine());

        average = (grade1 + grade2 + grade3) / 3;

        Console.WriteLine("Average grade = " + average);
        Console.Write("Students above average: ");

        if (grade1 > average)
            Console.Write(name1 + " ");
        if (grade2 > average)
            Console.Write(name2 + " ");
        if (grade3 > average)
            Console.Write(name3 + " ");

        Console.WriteLine();
    }
}

