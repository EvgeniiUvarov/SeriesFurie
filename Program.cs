//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5; "1,2,3,4,5"

using static System.Console;
Clear();

Write("Введите число N: ");
int N = int.Parse(ReadLine());

RecursMethod(N);

void RecursMethod(int num)
{
   if(num > 0)
   {
      //Write($"{num} ");                    //По убыванию
      RecursMethod(num-1);
      Write($"{num} ");                      //По возростанию
   }
   
}