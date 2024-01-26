// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System.Diagnostics;
using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);
int[,] array = GetArray(rows, colum);
PrintArray(array);

WriteLine("Введите позиции элемента: ");
string[] positionEll = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rowPos = int.Parse(positionEll[0]);
int colPos = int.Parse(positionEll[1]);
//WriteLine($"{SerchPositionElement(array,rowPos,colPos)}");

if(array.GetLength(0) < rowPos && array.GetLength(1) < colPos) WriteLine("Такого элемента нет");
else WriteLine($"Элемент: {array[rowPos,colPos]}");

// string SerchPositionElement(int[,] array, int row, int col)
// {
//    string result = "Такого элемента нет!";
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          if(i == row && j == col) result = $"Элемент найден {array[i,j]}";
//       }
//    }
//    return result;
// }

int[,] GetArray(int row, int col)
{
   int[,] result = new int[row, col];
   for (int i = 0; i < result.GetLength(0); i++)
   {
      for (int j = 0; j < result.GetLength(1); j++)
      {
         result[i, j] = new Random().Next(1, 10);
      }
   }
   return result;
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Write($"{array[i, j]} ");
      }
      WriteLine();
   }
}