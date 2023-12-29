// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

using System;
using System.Drawing;
using static System.Console;
Clear();

WriteLine("Введите длинну массива: ");
int[] array = new int[int.Parse(ReadLine())];
GetArray(array);
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"[{string.Join(" ",SumElement(array))}]");

int[] SumElement(int[]arr)
{
   int[] result = new int[arr.Length % 2 == 0?arr.Length/2:arr.Length/2+1];
   for (int i = 0; i < result.Length; i++)
   {
      result[i] = arr[i] * arr[arr.Length-1-i];
   }
   if(arr.Length%2 != 0) result[result.Length-1] = arr[arr.Length/2];
   return result; 
}

void GetArray(int[] ar)
{
   for (int i = 0; i < ar.Length; i++)
   {
      ar[i] = new Random().Next(1,10);
   }
}

