// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using System.Diagnostics;
using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);
int[,] array = GetArray(rows, colum);

if (rows == colum)
{
   PrintArray(array);
   ChenchRowsColumns(array);
   WriteLine();
   PrintArray(array);
}
else WriteLine("Not possible");

void ChenchRowsColumns(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = i; j < array.GetLength(1); j++)
      {
         int res = array[i, j];
         array[i, j] = array[j, i];
         array[j, i] = res;
      }
   }

}

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