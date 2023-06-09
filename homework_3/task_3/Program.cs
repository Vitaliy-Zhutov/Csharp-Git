﻿/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using static System.Console;
Clear();

Write("Введите число N:");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Ошибка, введите число: ");
    return;
}
if (N > 0)
{
    int index = 1;
    while (index <= N)
    {
        Write($"{Math.Pow(index, 3)} ");
        index += 1;
    }
    WriteLine(" ");
}