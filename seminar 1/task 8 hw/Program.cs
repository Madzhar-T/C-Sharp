﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int x = 2;

while (x <= numberN)
{
    Console.Write(x+", ");
    x = x + 2;
}
if (numberN == 1)
{
    Console.WriteLine("Чётных чисел нет.");
}