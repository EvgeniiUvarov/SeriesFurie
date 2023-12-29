// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов 
// массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;
using System.Drawing;
using static System.Console;
Clear();

WriteLine("Введите длинну массива: ");
int[] array = new int[int.Parse(ReadLine())];
WriteLine("Введите диапозон поиска: ");
string[] stringAr = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int minVal = int.Parse(stringAr[0]);
int maxVal = int.Parse(stringAr[1]);
GetArrayFromString(array);
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"Сумма элементов в диапозоне от {minVal} до {maxVal} = {SumElement(minVal,maxVal,array)}");

int SumElement(int minVal, int maxVal, int[]arr)
{
   int result = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      result += arr[i]>minVal && arr[i]<maxVal?1:0;
   }
   return result; 
}

void GetArrayFromString(int[] ar)
{
   for (int i = 0; i < ar.Length; i++)
   {
      ar[i] = new Random().Next(1,1000);
   }
}

