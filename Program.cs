// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов 
// массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;
using static System.Console;
Clear();

WriteLine("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");

int[] GetArrayFromString(string arrayStr)
{
   string[] arS = arrayStr.Split(" ",StringSplitOptions.RemoveEmptyEntries);
   int[] result = new int[arS.Length];
   for (int i = 0; i < arS.Length; i++)
   {
      result[i] = int.Parse(arS[i]);
   }
   return result;
}

