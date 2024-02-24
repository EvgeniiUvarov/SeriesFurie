// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9
// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0
// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);

int[,] arrayA = GetArray(rows, colum);
int[,] arrayB = GetArray(rows, colum);
PrintArray(arrayA);
WriteLine();
PrintArray(arrayB);
WriteLine();
int[,] resultArray = SumFestEndSecondMatrix(arrayA,arrayB);
PrintArray(resultArray);

int[,] SumFestEndSecondMatrix(int[,] arrA, int[,] arrB)
{
   int[,] result = new int[arrA.GetLength(0),arrA.GetLength(1)];
   for (int i = 0; i < arrA.GetLength(0); i++)
   {
      for (int j = 0; j < arrA.GetLength(1); j++)
      {
         result[i,j] = arrA[i,j] * arrB[i,j];
      }
   }
   return result;
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