﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1 целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 целое число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max=num1;

if (num1>max) max=num1;
if (num2>max) max=num2;
if (num3>max) max=num3;

Console.Write("max = ");
Console.WriteLine(max);