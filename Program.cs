// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
using System;
using static System.Console;
Clear();

WriteLine("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(',',array)}]");
ReversArray(array);
WriteLine($"[{String.Join(' ',array)}]");

void ReversArray(int[] arr)
{
   int qurent = 0;
   for (int i = 0; i < arr.Length/2; i++)
   {
      qurent = arr[arr.Length-1-i];
      arr[arr.Length-1-i] = arr[i];
      arr[i] = qurent;
   }
}

int[] GetArrayFromString(string strArray)
{
   string[] arS = strArray.Split(' ',StringSplitOptions.RemoveEmptyEntries);
   int[] result = new int[arS.Length];
   for (int i = 0; i < arS.Length; i++)
   {
      result[i] = int.Parse(arS[i]);
   }
   return result;
}

