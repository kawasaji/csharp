// See https://aka.ms/new-console-template for more information
using System;

int[] arr = new int[5];

int[][] arr_a = new int[5][];


for (int i = 0; i < 5; i++)
{
    Console.Write($"enter {i + 1} number ~# ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < arr.Length; i++) // Вывод
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Random rnd = new Random();
        arr_a[i] = new int[5] { rnd.Next(10), rnd.Next(10), rnd.Next(10), rnd.Next(10), rnd.Next(10) };
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{arr_a[i][j]} ");
    }

    Console.WriteLine();
}