// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N = new Random().Next(0, 100);
Console.WriteLine("Вводное число: " +N);
int even = 2;
while (even <= N)
{
    if (even%2 == 0)
    {
      Console.Write(" " +even);
      even++;  
    }
    if (even == N)
    {
      break;
    }
    even++;
    
}

