//**Задача 20:**
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

using System;
using static System.Console;

Clear();

Write("wwedite perwoe ");
int x1 = int.Parse(ReadLine());
int y1 = int.Parse(ReadLine());

Write("wwedite wtoroe ");
int x2 = int.Parse(ReadLine());
int y2 = int.Parse(ReadLine());

int sqrX=(x2-x1)*(x2-x1);
int sqrY=(y2-y1)*(y2-y1);


WriteLine(Math.Sqrt(sqrX+sqrY));

//Math.Pow(x2-x1,2)

//WriteLine({$"rasstojanie rawno:  distance:f2"})

//using System;
//using static System.Console;

//Clear();

//Write("Введите X1: ");
//int x1 = int.Parse(ReadLine());
//Write("Введите Y1: ");
//int y1 = int.Parse(ReadLine());
//Write("Введите X2: ");
//int x2 = int.Parse(ReadLine());
//Write("Введите Y2: ");
//int y2 = int.Parse(ReadLine());
//double AB = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
//WriteLine($"Длинна = {AB}");

