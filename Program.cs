// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* 
// BOXING AND UNBOXING PROGRAM

using System;

class Program
{
    static void Main()
    {
        // Example  of Boxing
        int valueType = 123;      // Value type
        object boxedValue = valueType;  // Boxing: Converting value type to object type

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

        // Example of Unboxing
        object obj = 456;         // Boxed value
        int unboxedValue = (int)obj; // Unboxing: Converting object type back to value type

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

        // Another example with double
        double doubleValue = 78.9; // Value type
        object boxedDouble = doubleValue; // Boxing

        Console.WriteLine("\nBoxing double:");
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Boxed double: " + boxedDouble);

        double unboxedDouble = (double)boxedDouble; // Unboxing

        Console.WriteLine("\nUnboxing double:");
        Console.WriteLine("Object type: " + boxedDouble);
        Console.WriteLine("Unboxed double: " + unboxedDouble);
    }
}*/
/*
// ADDITION PROGRAM 
using System;

// Define a public class named 'funcexer3'
public class funcexer3
{
    // Define a public static method 'Sum' that takes two integer parameters and returns their sum
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    // Main method, the entry point of the program
    public static void Main()
    {
        // Print a description of the program
        Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
        Console.Write("--------------------------------------------------\n");

        // Prompt the user to enter a number and read the input as an integer
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter another number and read the input as an integer
        Console.Write("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum by calling the 'Sum' method and print the result
        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
    }
} 


//ASSIGNMENT OPERATOR IN REAL TIME CODE
using System;
namespace Arithmetic
{
    class GFG
    {
        
        // Main Function
        static void Main(string[] args)
        {
            
            int result;
            int x = 10, y = 5;
            
            // Addition
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            
            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            
            // Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication Operator: "+ result);
            
            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            
            // Modulo
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
        }
    }
}

//write a program to take integer and object and display it using boxing and unboxing in c # use boxing and unboxing use type casting and take array as input in object when the user enter 1 it should display the name associated with the index
using System;

class Program
{
    static void Main()
    {
        // Create an array of objects to store names
        object[] names = new object[] { "Alice", "Bob", "Charlie", "Diana" };

        // Prompt the user to enter an index
        Console.WriteLine("Enter an index (0 to 3) to display the name associated with it:");
        int index = int.Parse(Console.ReadLine());

        // Box the integer index
        object boxedIndex = index;

        // Unbox the index
        int unboxedIndex = (int)boxedIndex;

        // Display the name associated with the unboxed index
        if (unboxedIndex >= 0 && unboxedIndex < names.Length)
        {
            Console.WriteLine("The name associated with index {0} is: {1}", unboxedIndex, names[unboxedIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index entered.");
        }

        // Prompt the user to enter 1 to display the name associated with the index
        Console.WriteLine("Enter 1 to display the name associated with the index again:");
        int choice = int.Parse(Console.ReadLine());

        // Check if the user entered 1
        if (choice == 1)
        {
            // Display the name again using the unboxed index
            if (unboxedIndex >= 0 && unboxedIndex < names.Length)
            {
                Console.WriteLine("The name associated with index {0} is: {1}", unboxedIndex, names[unboxedIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index entered.");
            }
        }
        else
        {
            Console.WriteLine("You did not enter 1.");
        }
    }
}

*/



/*
//sample program with error
int r = 1;
object o = r;
object ob="Atharv";
String n = ConvertToString(ob);
Console.WriteLine("Roll no is:"+r);
Console.WriteLine("Name is:"+n);
*/

/*
//PRIME NUMBER BETWEEN 1 AND 100 

using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Prime numbers between 1 and 100 are:");
        for (int i = 2; i <= 100; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
*/

/*
//SWAP TWO VARIABLES WITHOUT USING THIRD VARIABLE
using System;  
  public class Swap
   {  
     public static void Main(string[] args)  
      {  
       int  a=5, b=10;            
       Console.WriteLine("Before swap a= "+a+" b= "+b);    
       a=a+b; //a=15 (5+10)      
       b=a-b; //b=5 (15-10)      
       a=a-b; //a=10 (15-5)   
       Console.Write("After swap a= "+a+" b= "+b);       
      }  
  }

  */
/*
  //FIND THE FACTORIAL OF A NUMBER

  using System;  
  public class FactorialExample  
   {  
     public static void Main(string[] args)  
      {  
       int i,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= int.Parse(Console.ReadLine());     
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);    
     }  
  }  

  */

/*
  //PRINT FIBONACCI SERIES TILL N
using System;  
  public class Fibonacciseries
   {  
     public static void Main(string[] args)  
      {  
         int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); 
         for(i=2;i<number;++i)     
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }    
      }  
   }
   */

   //PATTERN CODE
   /*
   // INVERTED RIGHT TRIANGLE
   class Program
{
    static void Main(string[] args)
    {        
    	for (int row = 5; row >= 1; --row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        Console.ReadLine();
    }
}


//RIGHT TRIANGLE PROGRAM
class Program
{
    static void Main(string[] args)
    {        
    	for (int row = 1; row <= 5; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        Console.ReadLine();
    }
}


//
class Program
{
    static void Main(string[] args)
    {        
    	int val = 5;
        int i, j, k;
        for (i = 1; i <= val; i++)
        {
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}


// Diamond Shape
class Program
{
    static void Main(string[] args)
    {        
    	int number = 5, count = 1;
        count = number - 1;
        for (var k = 1; k <= number; k++)
        {
            for (var i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (var i = 1; i <= 2 * k - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (var k = 1; k <= number - 1; k++)
        {
            for (var i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (var i = 1; i <= 2 * (number - k) - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}      



//area of triangle
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base of the triangle:");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle:");
        double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(baseOfTriangle, heightOfTriangle);

        Console.WriteLine($"The area of the triangle is: {area}");
    }

    static double CalculateArea(double baseOfTriangle, double heightOfTriangle)
    {
        return 0.5 * baseOfTriangle * heightOfTriangle;
    }
}

//area of rectangle
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double lengthOfRectangle = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle:");
        double heightOfRectangle = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(lengthOfRectangle, heightOfRectangle);

        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    static double CalculateArea(double lengthOfRectangle, double heightOfRectangle)
    {
        return  lengthOfRectangle * heightOfRectangle;
    }
}
*/

/*
//Current date and local time
using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + now);
    }
}

//Area of polygon
*/

/*
//hotel bill generater
using System;

class HotelBillGenerator
{
    static void Main()
    {
        // Hotel details
        string hotelName = "Sanjivani Hotel";
        string hotelAddress = "Kopargaon, Ahmednagar";
        string gstNumber = "27AATFV1462C";  // Fixed GST number

        // Input variables for items
        Console.WriteLine($"------------------------------");
        Console.WriteLine($"        {hotelName}");
        Console.WriteLine($"        {hotelAddress}");
        Console.WriteLine($"------------------------------");
        Console.WriteLine($"GST Number: {gstNumber}");
        Console.WriteLine($"------------------------------");

        Console.WriteLine("Please enter the details:");
        Console.Write("Enter cost of food: ");
        double foodCost = double.Parse(Console.ReadLine());

        Console.Write("Enter cost of beverages: ");
        double beverageCost = double.Parse(Console.ReadLine());

        Console.Write("Enter cost of services: ");
        double serviceCost = double.Parse(Console.ReadLine());

        // Calculation
        double totalCost = foodCost + beverageCost + serviceCost;

        // Displaying the bill with hotel details
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("             Bill             ");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Item           Amount ($)");
        Console.WriteLine($"------------------------------");
        Console.WriteLine($"Food           ${foodCost, -10:F2}");
        Console.WriteLine($"Beverages      ${beverageCost, -10:F2}");
        Console.WriteLine($"Services       ${serviceCost, -10:F2}");
        Console.WriteLine($"------------------------------");
        Console.WriteLine($"Total          ${totalCost, -10:F2}");
        Console.WriteLine("------------------------------");

        Console.WriteLine("\nThank you for choosing us. Visit again!");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

*/
/*
// write a c# program to display reverse order 0123456789
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Array in reverse order:");
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}

*/
/*
//merge sort
using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };
        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted Array (Merge Sort): ");
        PrintArray(array);
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, middle + 1, rightArray, 0, n2);

        int i = 0, j = 0;
        int k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
*/


//ASSIGNMENT QUESTION
/*
using System;

namespace Day_17_06
{
    internal class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.TransposeMatrixDemo();
            program.InterchangeColumnsDemo();
            program.ConcatenateStringsDemo();
            program.SortingDemo();
            program.SearchElementDemo();
        }

        // 1. Transpose Matrix
        void TransposeMatrixDemo()
        {
            int[,] matrix = GetMatrixFromUser();
            int[,] transposedMatrix = TransposeMatrix(matrix);

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            Console.WriteLine("Transposed Matrix:");
            PrintMatrix(transposedMatrix);
        }

        int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed;
        }

        // 2. Interchange Columns of a Matrix
        void InterchangeColumnsDemo()
        {
            int[,] matrix = GetMatrixFromUser();
            Console.Write("Enter the first column to interchange: ");
            int col1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second column to interchange: ");
            int col2 = int.Parse(Console.ReadLine());

            InterchangeColumns(matrix, col1, col2);

            Console.WriteLine("Matrix after interchanging columns:");
            PrintMatrix(matrix);
        }

        void InterchangeColumns(int[,] matrix, int col1, int col2)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;
            }
        }

        // 3. Concatenate Two Strings
        void ConcatenateStringsDemo()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            string result = ConcatenateStrings(str1, str2);

            Console.WriteLine("Concatenated String: " + result);
        }

        string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        // 4. Sorting Algorithms
        void SortingDemo()
        {
            int[] array = GetArrayFromUser();

            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Bubble Sort
            BubbleSort(array);
            Console.WriteLine("Array after Bubble Sort:");
            PrintArray(array);

            // Quick Sort
            array = GetArrayFromUser();
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Array after Quick Sort:");
            PrintArray(array);

            // Merge Sort
            array = GetArrayFromUser();
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Array after Merge Sort:");
            PrintArray(array);
        }

        void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        // 5. Search an Element in an Array
        void SearchElementDemo()
        {
            int[] array = GetArrayFromUser();
            Console.Write("Enter the element to search for: ");
            int target = int.Parse(Console.ReadLine());

            int index = SearchElement(array, target);

            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }
        }

        int SearchElement(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        // Utility Methods
        int[] GetArrayFromUser()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        int[,] GetMatrixFromUser()
        {
            Console.Write("Enter the number of rows in the matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at ({i}, {j}): ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
/*

using System;

class Program
{
    static void Main()
    {
        // Define two 3x3 matrices
        int[,] matrixA = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrixB = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        // Perform operations
        int[,] additionResult = AddMatrices(matrixA, matrixB);
        int[,] subtractionResult = SubtractMatrices(matrixA, matrixB);
        int[,] multiplicationResult = MultiplyMatrices(matrixA, matrixB);
        int[,] divisionResult = DivideMatrices(matrixA, matrixB);
        int[,] moduloResult = ModuloMatrices(matrixA, matrixB);

        // Display results
        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);
        Console.WriteLine("Matrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("Addition Result:");
        PrintMatrix(additionResult);
        Console.WriteLine("Subtraction Result:");
        PrintMatrix(subtractionResult);
        Console.WriteLine("Multiplication Result:");
        PrintMatrix(multiplicationResult);
        Console.WriteLine("Division Result:");
        PrintMatrix(divisionResult);
        Console.WriteLine("Modulo Result:");
        PrintMatrix(moduloResult);
    }

    static int[,] AddMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return result;
    }

    static int[,] SubtractMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }
        return result;
    }

    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] * b[i, j];
            }
        }
        return result;
    }

    static int[,] DivideMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Check for division by zero
                result[i, j] = b[i, j] != 0 ? a[i, j] / b[i, j] : 0;
            }
        }
        return result;
    }

    static int[,] ModuloMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Check for modulo by zero
                result[i, j] = b[i, j] != 0 ? a[i, j] % b[i, j] : 0;
            }
        }
        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/
/*
using System;

// Interface for tablet capability
interface ITablet
{
    void TouchScreen();
}

// Interface for laptop capability
interface ILaptop
{
    void Type();
}

// Base class
class Gadget
{
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Model} gadget is starting.");
    }
}

// Class that implements both ITablet and ILaptop interfaces
class HybridGadget : Gadget, ITablet, ILaptop
{
    public void TouchScreen()
    {
        Console.WriteLine($"{Model} is in tablet mode with touch screen."
    }

    public void Type()
    {
        Console.WriteLine($"{Model} is in laptop mode with keyboard.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HybridGadget hybridGadget = new HybridGadget { Model = "Microsoft Surface" };

        hybridGadget.Start();         // Method from Gadget class
        hybridGadget.TouchScreen();   // Method from ITablet interface
        hybridGadget.Type();          // Method from ILaptop interface
    }
}
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("☆ SANJIVANI COLLEGE OF ENGINEERING");
        Console.WriteLine("~ Academic Fees Receipt ~");
        Console.WriteLine("=================================");
        
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your branch (IT/CSE): ");
        string branch = Console.ReadLine();
        
        Console.WriteLine("=================================");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("USTN: ******");
        Console.WriteLine("BRANCH: " + branch);
        Console.WriteLine("Year/Sem: 2024-2025/1st Sem");
        Console.WriteLine("Date: 19/06/1990");
        Console.WriteLine("Time: 11:45 AM");
        Console.WriteLine("=================================");
        
        Console.WriteLine("PARTICULARS\tAMOUNT");
        Console.WriteLine("=================================");
        Console.WriteLine("1) Entrance");
        Console.WriteLine("2) Exams");
        Console.WriteLine("3) Library");
        Console.WriteLine("4) Hostel");
        Console.WriteLine("5) Laboratory");
        Console.WriteLine("6) Projects & Classes");
        Console.WriteLine("=================================");
        
        Console.Write("Enter the amount: ₹");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        
        decimal grandTotal = amount + (amount * 0.18m);
        
        Console.WriteLine("Total: ₹" + amount);
        Console.WriteLine("GST (18%): ₹" + (amount * 0.18m));
        Console.WriteLine("=================================");
        Console.WriteLine("GRAND TOTAL ₹ = " + grandTotal);
        Console.WriteLine("=================================");
        Console.ReadLine();
    }
}