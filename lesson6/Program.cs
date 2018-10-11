using System;
using System.Linq;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        static void Task1()
        {
            Console.WriteLine("Please enter 5 element array...");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter {0} element", i+1);
                arr[i] = int.Parse( Console.ReadLine());
            }

            Array.Sort(arr);
            arr.ToList().ForEach(f => Console.Write(f.ToString() + ", "));
            
            Console.ReadLine();
        }

        static void Task2()
        {

        }
    }
}
//