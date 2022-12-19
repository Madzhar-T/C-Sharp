// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты уA ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты zA ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты yB: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты zB: ");
int zB = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt (Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine ($"{res:f2}");    