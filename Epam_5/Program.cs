using System;

namespace Epam_5
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int n;
                Console.Write("Введите число элементов массива: ");
                n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Введите arr[{0}] ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.ReadLine();


          


            Console.WriteLine("Элементы массива:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = {1}",
                i, arr[i]);
            }
            Console.ReadLine();

        }
    }
}
