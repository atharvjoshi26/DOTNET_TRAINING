/*
//C# Program to Sort a List of Names in Alphabetical Order
using System;
using System.Collections.Generic;
using System.Linq;

class SortNames
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "John", "Alice", "Bob", "Eve", "Charlie" };

        Console.WriteLine("Original List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Sort();

        Console.WriteLine("\nSorted List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}


//C# Program to Demonstrate Pass by Value
using System;

class PassByValue
{
    static void Main(string[] args)
    {
        int x = 10;
        Console.WriteLine("Before method call: x = " + x);

        ChangeValue(x);

        Console.WriteLine("After method call: x = " + x);
    }

    static void ChangeValue(int y)
    {
        y = 20;
        Console.WriteLine("Inside method: y = " + y);
    }
}


//C# Program to Demonstrate Pass by Reference
using System;

class PassByReference
{
    static void Main(string[] args)
    {
        int x = 10;
        Console.WriteLine("Before method call: x = " + x);

        ChangeValue(ref x);

        Console.WriteLine("After method call: x = " + x);
    }

    static void ChangeValue(ref int y)
    {
        y = 20;
        Console.WriteLine("Inside method: y = " + y);
    }
}

//C# Program to Illustrate Regular Expression Patterns
using System;
using System.Text.RegularExpressions;

class RegularExpressions
{
    static void Main(string[] args)
    {
        string pattern = @"^[a-zA-Z]+$"; // matches only letters
        string input = "HelloWorld";

        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Input matches the pattern.");
        }
        else
        {
            Console.WriteLine("Input does not match the pattern.");
        }
    }
}
//C# Program to Implement Namespaces
using System;
using MyMath;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        int result = calc.Add(5, 3);
        Console.WriteLine("5 + 3 = " + result);

        result = calc.Subtract(5, 3);
        Console.WriteLine("5 - 3 = " + result);
    }
}

//C# Program to Demonstrate the Difference between Value Type Parameter and Reference Type Parameter
using System;

class ValueTypeVsReferenceType
{
    static void Main(string[] args)
    {
        int valueType = 10;
        Console.WriteLine("Before method call: valueType = " + valueType);

        ChangeValueType(valueType);

        Console.WriteLine("After method call: valueType = " + valueType);

        MyClass referenceType = new MyClass { Value = 10 };
        Console.WriteLine("Before method call: referenceType.Value = " + referenceType.Value);

        ChangeReferenceType(referenceType);

        Console.WriteLine("After method call: referenceType.Value = " + referenceType.Value);
    }

    static void ChangeValueType(int x)
    {
        x = 20;
        Console.WriteLine("Inside method: x = " + x);
    }

    static void ChangeReferenceType(MyClass obj)
    {
        obj.Value = 20;
        Console.WriteLine("Inside method: obj.Value = " + obj.Value);
    }
}

class MyClass
{
    public int Value { get; set; }
}

//C# Program to Demonstrate the Goto Statement
using System;

class GotoStatement
{
    static void Main(string[] args)
    {
        int i = 0;

        start:
        Console.WriteLine("i = " + i);

        if (i < 5)
        {
            i++;
            goto start;
        }
    }
}
//C# Program to Convert Upper case to Lower Case
using System;

class UpperToLower
{
    static void Main(string[] args)
    {
        string input = "HELLO WORLD";
        string lowerCase = input.ToLower();

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Lower case: " + lowerCase);
    }
}

//C# Program to Convert Characters of a String to Opposite Case
using System;

class OppositeCase
{
    static void Main(string[] args)
    {
        string input = "HeLlO WoRlD";
        string oppositeCase = "";

        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                oppositeCase += char.ToLower(c);
            }
            else
            {
                oppositeCase += char.ToUpper(c);
            }
        }

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Opposite case: " + oppositeCase);
    }
}
*/
//C# Program to Find the Length of a String
using System;

class StringLength
{
    static void Main(string[] args)
    {
        string input = "Hello World";
        int length = input.Length;

        Console.WriteLine("Input: " + input);
        Console.WriteLine("Length: " + length);
    }
}