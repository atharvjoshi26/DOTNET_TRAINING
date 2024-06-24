/*
//C# Program to Convert Infix to Postfix
using System;
using System.Collections.Generic;

class InfixToPostfix
{
    static void Main(string[] args)
    {
        Console.Write("Enter infix expression: ");
        string infix = Console.ReadLine();

        string postfix = ConvertInfixToPostfix(infix);

        Console.WriteLine("Postfix expression: " + postfix);
    }

    static string ConvertInfixToPostfix(string infix)
    {
        Stack<char> stack = new Stack<char>();
        string postfix = "";

        foreach (char c in infix)
        {
            if (char.IsLetter(c))
            {
                postfix += c;
            }
            else if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                while (stack.Peek()!= '(')
                {
                    postfix += stack.Pop();
                }
                stack.Pop(); // remove '('
            }
            else
            {
                while (stack.Count > 0 && stack.Peek()!= '(' && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                {
                    postfix += stack.Pop();
                }
                stack.Push(c);
            }
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop();
        }

        return postfix;
    }

    static int GetPrecedence(char op)
    {
        if (op == '+' || op == '-')
        {
            return 1;
        }
        else if (op == '*' || op == '/')
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
}
//C# Program to Display Square Feet of a House
using System;

class SquareFeet
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the house in feet: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of the house in feet: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double squareFeet = length * width;

        Console.WriteLine("The house is " + squareFeet + " square feet");
    }
}
//C# Program to Convert Meter to Kilometer and Vice-versa
using System;

class MeterToKilometer
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());

        double kilometers = meters / 1000;

        Console.WriteLine(meters + " meters is equal to " + kilometers + " kilometers");

        Console.Write("Enter distance in kilometers: ");
        kilometers = Convert.ToDouble(Console.ReadLine());

        meters = kilometers * 1000;

        Console.WriteLine(kilometers + " kilometers is equal to " + meters + " meters");
    }
}
//C# Program to Generate the Marksheet of the Student
using System;

class Marksheet
{
    static void Main(string[] args)
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter roll number: ");
        int rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in subject 1: ");
        int marks1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in subject 2: ");
        int marks2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in subject 3: ");
        int marks3 = Convert.ToInt32(Console.ReadLine());

        int totalMarks = marks1 + marks2 + marks3;
        double percentage = (totalMarks / 300.0) * 100;

        Console.WriteLine("Marksheet:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Marks in Subject 1: " + marks1);
        Console.WriteLine("Marks in Subject 2: " + marks2);
        Console.WriteLine("Marks in Subject 3:" + marks3);
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage + "%");
    }
}
//C# Program to Create a Stop Watch
using System;
using System.Diagnostics;

class StopWatch
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Press any key to start...");
        Console.ReadKey();

        stopwatch.Start();

        Console.WriteLine("Stopwatch started. Press any key to stop...");
        Console.ReadKey();

        stopwatch.Stop();

        Console.WriteLine("Elapsed time: " + stopwatch.Elapsed);
    }
}
//C# Program to Implement PhoneBook
using System;
using System.Collections.Generic;

class PhoneBook
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook.Add("John", "123-456-7890");
        phoneBook.Add("Jane", "987-654-3210");
        phoneBook.Add("Bob", "555-123-4567");

        Console.WriteLine("Phone Book:");
        foreach (KeyValuePair<string, string> entry in phoneBook)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }

        Console.Write("Enter name to search: ");
        string name = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine("Phone number: " + phoneBook[name]);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}
//C# Program to Get IP Address
using System;
using System.Net;

class GetIPAddress
{
    static void Main(string[] args)
    {
        string ipAddress = GetLocalIPAddress();

        Console.WriteLine("Local IP Address: " + ipAddress);
    }

    static string GetLocalIPAddress()
    {
        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
        return host.AddressList[0].ToString();
    }
}
//C# Program to Convert Celsius to Fahrenheit
using System;

class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(celsius + "°C is equal to " + fahrenheit + "°F");
    }
}
//C# Program to Create a Gray Code
using System;

class GrayCode
{
    static void Main(string[] args)
    {
        int n = 3; // number of bits
        int max = 1 << n; // maximum value

        Console.WriteLine("Gray Code for " + n + " bits:");

        for (int i = 0; i < max; i++)
        {
            int grayCode = i ^ (i >> 1);
            Console.WriteLine(Convert.ToString(grayCode, 2).PadLeft(n, '0'));
        }
    }
}

//C# Program to Get the DayLight Saving Information
using System;

class DayLightSaving
{
    static void Main(string[] args)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.Local;
        bool isDaylightSaving = timeZone.SupportsDaylightSavingTime;

        Console.WriteLine("Is Daylight Saving Time supported: " + isDaylightSaving);

        if (isDaylightSaving)
        {
            DateTime startDate = timeZone.DaylightSavingTime.Start;
            DateTime endDate = timeZone.DaylightSavingTime.End;

            Console.WriteLine("Daylight Saving Time starts: " + startDate);
            Console.WriteLine("Daylight Saving Time ends: " + endDate);
        }
    }
}

//C# Program to Demonstrate Multilevel Inheritance with Virtual Methods
using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Bulldog : Dog
{
    public override void Sound()
    {
        Console.WriteLine("The bulldog growls.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Bulldog bulldog = new Bulldog();

        animal.Sound();
        dog.Sound();
        bulldog.Sound();
    }
}
//C# Program to Implement Delegates
using System;

class Program
{
    delegate int MathOperation(int x, int y);

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static void Main(string[] args)
    {
        MathOperation operation = Add;
        Console.WriteLine("Result: " + operation(10, 5));

        operation = Subtract;
        Console.WriteLine("Result: " + operation(10, 5));
    }
}

// C# Program to Traverse the Singly Linked List
using System;

class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    public Node Head { get; set; }

    public void Traverse()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Head = new Node(1);
        list.Head.Next = new Node(2);
        list.Head.Next.Next = new Node(3);

        list.Traverse();
    }
}
// C# Program to Sort a List of Names in Alphabetical Order
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "John", "Alice", "Bob", "Eve", "Charlie" };
        names.Sort();

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
//C# Program to Find the Smallest Element in a Matrix
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int smallest = int.MaxValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < smallest)
                {
                    smallest = matrix[i, j];
                }
            }
        }

        Console.WriteLine("Smallest element: " + smallest);
    }
}

//C# Program to Find the Largest Element in a Matrix
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int largest = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > largest)
                {
                    largest = matrix[i, j];
                }
            }
        }

        Console.WriteLine("Largest element: " + largest);
    }
}
//C# Program to Demonstrate Jagged Arrays
using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

        for (int i = 0; i < jaggedArray.Length;i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
// C# Program to Calculate Distance, Speed and Time
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter speed (km/h): ");
        double speed = Convert.ToDouble(Console.ReadLine());

        double time = distance / speed;

        Console.WriteLine("Time: " + time + " hours");
    }
}
//C# Program to Find Simple Interest
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("Simple interest: " + simpleInterest);
    }
}*/
//C# Program to Convert Digits to Words
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a digit (0-9): ");
        int digit = Convert.ToInt32(Console.ReadLine());

        string[] digitsToWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        Console.WriteLine("The digit " + digit + " is " + digitsToWords[digit]);
    }
}
