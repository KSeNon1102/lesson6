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
                Console.WriteLine("Please enter {0} element", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            arr.ToList().ForEach(f => Console.Write(f.ToString() + ", "));

            Console.ReadLine();
        }

        static void Task2()
        {
            int[,] map = new int[3, 3];
            for (int i = 0, k = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    map[i, j] = k++;
                }
            }

            Print(map);
            bool end = false;
            var coordinate = new int[2];
            while (!end)
            {
                
                var key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'q':
                        Console.WriteLine("Bay...");
                        end = true;
                        break;
                    case 'e':
                        Console.WriteLine("Bay...");
                        end = true;
                        break;
                    case 'w':
                        coordinate = FindPlace(map);
                        if (coordinate[0] - 1 < 0)
                        {
                            Console.Beep();
                            break;
                        }
                        map[coordinate[0], coordinate[1]] = map[coordinate[0] - 1, coordinate[1]];
                        map[coordinate[0] - 1, coordinate[1]] = 0;
                        Print(map);
                        break;
                    case 'a':
                        coordinate = FindPlace(map);
                        if (coordinate[1] - 1 < 0)
                        {
                            Console.Beep();
                            break;
                        }
                        map[coordinate[0], coordinate[1]] = map[coordinate[0] , coordinate[1]-1];
                        map[coordinate[0], coordinate[1]-1] = 0;
                        Print(map);
                        break;
                    case 'd':
                        coordinate = FindPlace(map);
                        if (coordinate[1] + 1 > 2)
                        {
                            Console.Beep();
                            break;
                        }
                        map[coordinate[0], coordinate[1]] = map[coordinate[0], coordinate[1]+1];
                        map[coordinate[0], coordinate[1]+1] = 0;
                        Print(map);
                        break;
                    case 's':
                        coordinate = FindPlace(map);
                        if (coordinate[0] + 1 > 2)
                        {
                            Console.Beep();
                            break;
                        }
                        map[coordinate[0], coordinate[1]] = map[coordinate[0] +1, coordinate[1]];
                        map[coordinate[0] + 1, coordinate[1]] = 0;
                        Print(map);
                        break;
                    default:
                        Console.Beep();
                        break;
                }
            }

           // Console.ReadLine();

        }
        static int[] FindPlace(int[,] matrix)
        {
            for (int i = 0; i <= matrix.Rank; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                        return new int[] { i, j };


                }                
            }
            return new int[] { 0, 0 };
        }

        static void Print(int[,] matrix)
        {
            Console.Clear();
            for(int i=0; i<= matrix.Rank; i++)
            {
                for(int j=0; j< matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
//