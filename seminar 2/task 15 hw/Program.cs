﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5) Console.WriteLine ("нет");
if (day == 6 || day == 7) Console.WriteLine ("да");

