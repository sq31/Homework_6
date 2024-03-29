﻿/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.WriteLine("Найдем точку пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2");
Console.Write("Введите значение b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2) / (k2 - k1);
double y = (k2 * x + b2);

Console.WriteLine($"Точкой пересечения двух прямых является ({x};{y}).");