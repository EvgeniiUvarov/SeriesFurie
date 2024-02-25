// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(0,1,0) 53(0,1,1)
// 32(1,0,0) 41(1,0,1)
// 66(1,1,0) 88(1,1,1)

using static System.Console;
Clear();

Write("Введите через пробел размер трёхмерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);
int lin = int.Parse(strAr[2]);

int[,,] array =  new int[rows, colum, lin];
GetArray(array);
PrintArray(array);


void GetArray(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int z = 0; z < array.GetLength(2); z++)
         {
            array[i,j,z] = PositivNum(array);
         }
      }
   }
}

int PositivNum(int [,,] array)
{
   int result = new Random().Next(0,9);
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int z = 0; z < array.GetLength(2); z++)
         {
            result = result == array[i,j,z]? PositivNum(array): result;
         }
      }
   }
   return result;
}

void PrintArray(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int z = 0; z < array.GetLength(2); z++)
         {
            Write($"{array[i,j,z]}({i},{j},{z}) ");
         }
         WriteLine();
      }
   }
}