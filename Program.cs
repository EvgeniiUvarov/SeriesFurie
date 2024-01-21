// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

using static System.Console;
Clear();

Write("Введите числа через пробел K1 B1 K2 B2: ");
string[] stArr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double k1 = int.Parse(stArr[0]);
double b1 = int.Parse(stArr[1]);
double k2 = int.Parse(stArr[2]);
double b2 = int.Parse(stArr[3]);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
WriteLine($"Точка пересечения двух прямых: ({x} {y})");
