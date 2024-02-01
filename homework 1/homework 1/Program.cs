using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Program
    {
        static void Main()
            {
                Console.Write("Enter the temperature in degrees Celsius: ");
                double temperature = Convert.ToDouble(Console.ReadLine());

                if (temperature < 0)
                {
                    Console.WriteLine("Freezing weather.");
                }
                else if (temperature >= 0 && temperature < 10)
                {
                    Console.WriteLine("Cold weather.");
                }
                else if (temperature >= 10 && temperature < 20)
                {
                    Console.WriteLine("Cool weather.");
                }
                else if (temperature >= 20 && temperature < 30)
                {
                    Console.WriteLine("Moderate weather.");
                }
                else
                {
                    Console.WriteLine("Warm weather.");
                }

            }
        }

}
// ex 2 
using System;

class AgeCategoryProgram
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }
    }
}
//ex 3
using System;

class TemperatureConversionProgram
{
    static void Main()
    {
        Console.WriteLine("Choose conversion direction:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        int choice = Convert.ToInt32(Console.ReadLine());

        double temperatureF, temperatureC;

        if (choice == 1)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            temperatureF = Convert.ToDouble(Console.ReadLine());
            temperatureC = (temperatureF - 32) * 5 / 9;
            Console.WriteLine($"Equivalent temperature in Celsius: {temperatureC} °C");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Celsius: ");
            temperatureC = Convert.ToDouble(Console.ReadLine());
            temperatureF = (temperatureC * 9 / 5) + 32;
            Console.WriteLine($"Equivalent temperature in Fahrenheit: {temperatureF} °F");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose 1 or 2.");
        }
    }
}
//ex4 
using System;

class FindMinMaxProgram
{
    static void Main()
    {
        int[] numbers = { 12, 5, 7, 25, 8, 15 };

        FindMinMax(numbers);
    }

    static void FindMinMax(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return;
        }

        int max = array[0];
        int min = array[0];

        foreach (int num in array)
        {
            if (num > max)
                max = num;

            if (num < min)
                min = num;
        }
        Console.WriteLine($"Maximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
    }
}
//ex 5 
using System;

class ReverseArrayProgram
{
    static void Main()
    {
        int[] numbers = { 12, 5, 7, 25, 8, 15 };

        ReverseArray(numbers);
    }

    static void ReverseArray(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return;
        }
        Array.Reverse(array);
        Console.WriteLine("Reversed array:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
//ex 6 
using System;

class SecondLargestProgram
{
    static void Main()
    {
        int[] numbers = { 12, 5, 7, 25, 8, 15 };

        FindSecondLargest(numbers);
    }

    static void FindSecondLargest(int[] array)
    {
        if (array.Length < 2)
        {
            Console.WriteLine("Array should have at least two elements to find the second largest element.");
            return;
        }

        Array.Sort(array, (a, b) => -a.CompareTo(b));

        Console.WriteLine($"Second largest element: {array[1]}");
    }
}
//ex 7 
using System;

class SumArraysProgram
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        int[] sumArray = SumArrays(array1, array2);

        Console.WriteLine("Sum of corresponding elements from two arrays:");
        PrintArray(sumArray);
    }

    static int[] SumArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Arrays should have the same length for element-wise addition.");
            return new int[0]; 
        }

        int[] sumArray = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            sumArray[i] = array1[i] + array2[i];
        }

        return sumArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}

