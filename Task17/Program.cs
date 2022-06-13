using System;
using static System.Console;

Clear();


Write("wwedite x ");
int x=int.Parse(ReadLine());
Write("wwedite y ");
int y=int.Parse(ReadLine());
int quater=0;

if(x>0&&y>0)
{
    quater=1;
}
if(x<0&&y>0)
{
    quater=2;
}
if(x<0&&y<0)
{
    quater=3;
}
if(x>0&&y<0)
{
    quater=4;
}
WriteLine($"{quater} chetwert");