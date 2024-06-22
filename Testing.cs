using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace myConsoleApp
{
    public class Testing
    {
        public void Run()
        {
            // Question one Changing list to readonly
            List<string> myList = new List<string> { "red", "green", "blue" };

            ReadOnlyCollection<string> changeToReadOnly = myList.AsReadOnly();

            // changeToReadOnly.Add("purple");

            Console.WriteLine("Checking if 'purple' was added to the read-only collection:");
            foreach (string color in changeToReadOnly)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nContents of the original list:");
            foreach (string color in myList)
            {
                Console.WriteLine(color);
            }

            // Question two  checking capacity

            List<int> myListInteger = new List<int>();
            myListInteger.Capacity = 100;
            myListInteger.Add(1);
            myListInteger.Add(17);
            myListInteger.Add(2);
            myListInteger.Add(3);
            myListInteger.Add(4);
            myListInteger.Add(5);
            myListInteger.Add(6);
            myListInteger.Add(7);
            myListInteger.Add(8);
            myListInteger.Add(12);
            Console.WriteLine("Checking my List capacity = " + myListInteger.Capacity);
            Console.WriteLine("Checking my count = " + myListInteger.Count);

            // Question Three maximum number
            List<int> MaxiumValue = new List<int> { 1, 2, 4, 6, 59, 20, 30, 40, 5, 500 };
            int result = MaxiumValue.Max();
            Console.WriteLine("The maxium number is = " + result);

            // Question Four 
            int[] myArray = { 1, 2, 3 };
            int[] arrayTwo = { 4, 5, 6 };
            int[] combineResult = myArray.Concat(arrayTwo).ToArray();


            foreach (int item in combineResult)

            {
                Console.WriteLine("The Array result " + item);

            }

            //  Question 6 Sorting and reversersing
            int[] sorting = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            Array.Sort(sorting);

            foreach (int num in sorting)

            {
                Console.WriteLine("The sorted numbers are: " + num);

            }
// Reverse array
            int[] reverse = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            Array.Reverse(reverse);

            foreach (int n in reverse)

            {
                Console.WriteLine("The reverse numbers are: " + n);

            }


            //  Question 7 creating manipulted array 
            int[] manipulatedArray = { 10, 20, 30, 40, 50 };
            Console.WriteLine("the lenght of the array: " + manipulatedArray.Length);

            manipulatedArray[2] = 35;
            Console.WriteLine("The modified array:");
            foreach (int n in manipulatedArray)
            {
                Console.WriteLine(n);
            }

            //  Question 8 List metthod 
            List<string> fruits = new List<string> {"apple", "banana","cherry"};
            fruits.Add("date");
            fruits.Remove("banana");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
