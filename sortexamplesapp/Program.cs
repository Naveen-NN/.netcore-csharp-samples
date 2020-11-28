using System;

namespace sortexamplesapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 5, 6, 8, 7};
            
            ArraySorter sorter = new BubbleSort(); 
            
            Console.WriteLine("Before Sorting:");  
            
            Print(numbers);  
            
            sorter.Sort(numbers);

            Console.WriteLine("\nAfter Sorting:");  
            
            Print(numbers);  

        }

        static void Print(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
