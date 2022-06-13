using System;
using static System.Console;

Clear();

//*Задача 18:**

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Write("Input quater ");
int quater = int.Parse(ReadLine());

if (quater == 1) WriteLine("x>0,y>0");
if (quater == 2) WriteLine("x<=0,y>0");
if (quater == 3) WriteLine("x<0,y<0");
if (quater == 4) WriteLine("x>0,y<=0");