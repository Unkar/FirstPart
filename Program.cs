// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символам.

using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Введите количество строк");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите строку");
            array[i] = Console.ReadLine();
        }
        
        int size_result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                size_result++;
            }
        }
        string[] result = new string[size_result];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[j] = array[i];
                j++;
            }
        }
        Console.WriteLine("Массив из строк, длина которых меньше или равна 3 символам");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($" {result[i]} ");
        }
    }
}
        