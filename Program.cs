// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static System.Console;
Clear();

Write("Введите два числа через пробел: ");
string[] str = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int numA = int.Parse(str[0]);
int numB = int.Parse(str[1]);

WriteLine(RecursMethod(numA,numB));

int RecursMethod(int numA, int numB)
{
   return numA <= numB ?numA + RecursMethod(numA+1, numB): 0;
}

