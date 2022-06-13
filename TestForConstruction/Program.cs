using System;
using static System.Console;

Clear();

Write("Wwedite N: ");
int N=int.Parse(ReadLine());

for(int i=0;i<=N;i+=2)
{
    WriteLine(i);
}

//Переменная живёт внутри скобок