

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

