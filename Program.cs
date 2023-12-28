// Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да 


using System;
using static System.Console;
Clear();

Write("Введите размер массива: ");
int siz = int.Parse(ReadLine());
Write("Введите искомое число: ");
int num = int.Parse(ReadLine());
int[] array = RandArray(siz);
WriteLine($"{String.Join(" ,", array)}");
WriteLine($"{string.Join(" ",SumPozNum(array))}");
WriteLine(FindNum(array,num));


int[] SumPozNum(int[] array)
{
   int[] result = new int[array.Length];
   for (int i = 0; i < array.Length; i++)
   {
      result[i] = array[i]*-1;
   }
   return result;
}

string FindNum(int[] array, int num)
{
   string res = string.Empty;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] == num)
      {
       res = "eys";
       break;
      }
      else res = "no";
   }
   return res;
}

int[] RandArray(int size)
{
   int[] result = new int[size];
   for (int i = 0; i < size; i++)
   {
      result[i] = new Random().Next(-9,10);
   }
   return result;
}
