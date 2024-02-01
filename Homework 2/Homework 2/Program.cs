using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            FindMiddle(arr);
        }

        static void FindMiddle(int[] arr)
        {
            int size = arr.Length;

            if (size == 0)
            {
                Console.WriteLine("Empty list, no middle element.");
                return;
            }

            int middleIndex = size / 2;

            Console.Write("Middle element(s): " + arr[middleIndex]);

            if (size % 2 == 0)
            {
                Console.Write(", " + arr[middleIndex - 1]);
            }

            Console.WriteLine();
        }
    }
}

//ex2 - Write a function that takes in a list of integers and returns the largest integer in the list.
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 4, 7, 1, 9, 3, 8 };
        int maxNumber = FindLargest(numbers);

        Console.WriteLine("The largest number is: " + maxNumber);
    }

    static int FindLargest(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("List is empty or null.");
        }

        return numbers.Max();
    }
}

