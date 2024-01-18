// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] strArr = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

WriteLine($"{SumArray(strArr)}");

int SumArray(string[] stringAr)
{
   int result = 0;
   for (int i = 0; i < stringAr.Length; i++)
   {
      result += int.Parse(stringAr[i]) > 0? 1:0;
   }
   return result;
}
