//Напишите программу которая рекурсивно посчитает сумму цифр числа.
//453 -> 12
//45 -> 9
using System.Reflection.Metadata.Ecma335;
using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());

WriteLine(RecursMethod(number));

int RecursMethod(int num)
{
   return num > 0 ?num % 10 + RecursMethod(num/10): 0;
}