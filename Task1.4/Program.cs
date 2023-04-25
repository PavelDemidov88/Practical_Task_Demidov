// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = new Random().Next(0, 100);
int b = new Random().Next(0, 100);
int c = new Random().Next(0, 100);
Console.WriteLine("" +a);
Console.WriteLine("" +b);
Console.WriteLine("" +c);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Max: " +max);

