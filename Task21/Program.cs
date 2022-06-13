//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//5 -> 1, 4, 9, 16, 25.

//2 -> 1,4

using System;
using static System.Console;

Clear();

WriteLine("wwedite chislo N: ");
int N = Convert.ToInt32(ReadLine());
int count = 1;

while(count<=N)
{
    Write($"{Math.Pow(count,2)}, " );
    count++;
}
Write($"{Math.Pow(count,2)}." );

