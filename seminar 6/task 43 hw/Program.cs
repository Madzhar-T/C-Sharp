// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
} 

int b1 = GetNumber("Введите число b1: ");
int b2 = GetNumber("Введите число b2: ");
int k1 = GetNumber("Введите число k1: ");
int k2 = GetNumber("Введите число k2: ");

// y = ax + c, y = bx = d 
