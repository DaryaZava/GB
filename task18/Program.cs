﻿// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4: ");
int a = int.Parse(Console.ReadLine()!);

if (a == 1) Console.WriteLine(" Диапозон возможных координат => 0++...");
if (a == 2) Console.WriteLine(" Диапозон возможных координат => x => 0++...-, y => 0++...+");
if (a == 3) Console.WriteLine(" Диапозон возможных координат => x => 0++...-, y => 0++...-");
if (a == 4) Console.WriteLine(" Диапозон возможных координат => x => 0++...+, y => 0++...-");
