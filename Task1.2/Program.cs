// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = new Random().Next(0, 100);
int b = new Random().Next(0, 100);
Console.WriteLine("Первое число: " +a);
Console.WriteLine("Второе число: " +b);
if (a>b)
{
    Console.WriteLine("Большее: " +a);
    Console.WriteLine("Меньшее:: " +b);
}
if (a<b)
{
     Console.WriteLine("Большее: " +b);
    Console.WriteLine("Меньшее:: " +a);
}
if (a==b)
{
    Console.WriteLine("Числа равны");
}