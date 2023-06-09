﻿// Напишите программу которая перевернет одномерный массив.

using static System.Console;
Clear();

Write("Ввудите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

// string stringArray = string.Join(",", array);
// WriteLine($"[{stringArray}]");

WriteLine($"[{String.Join(",", array)}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");

// WriteLine($"[{String.Join(",", ReverseArray1(array))}]");


int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1,10);
    }
    return resultArray;
}


// int[] ReverseArray1(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
    
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length-1-i];
//     }
    
//     return result;
// }


void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i] = temp;
    }
}
