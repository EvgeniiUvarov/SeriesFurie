// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// Если набор данных — таблица:
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);

int[,] array = GetArray(rows, colum);
PrintArray(array);
WriteLine();

for (int i = MinElement(array); i < MaxElement(array)+1; i++)
{
   if(SerchSumElement(array,i) != 0) WriteLine($"{i} Встречается {SerchSumElement(array,i)} раз!");
}

int SerchSumElement(int[,] array, int num)
{
   int sum = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (num == array[i,j]) sum++; 
      }
   }
   return sum;
}

int MinElement(int[,] array)
{
   int result = array[0,0];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 1; j < array.GetLength(1); j++)
      {
         if (array[i,j] < result) result = array[i,j];
      }
   }
   return result;
}

int MaxElement(int[,] array)
{
   int result = array[0,0];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 1; j < array.GetLength(1); j++)
      {
         if (array[i,j] > result) result = array[i,j];
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