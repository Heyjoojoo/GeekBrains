﻿Console.Clear();
Console.Write("Введите координату число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i*i + " ");
}