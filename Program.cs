// Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120
using static System.Console;
Clear();

Write("Введите два числа через пробел: ");
string[] str = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int numA = int.Parse(str[0]);
int numB = int.Parse(str[1]);

WriteLine(RecursMethod(numA,numB));

int RecursMethod(int numA, int numB)
{
   return numA <= numB ?numA * RecursMethod(numA+1, numB): 1;
}

