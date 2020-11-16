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

            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }



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
