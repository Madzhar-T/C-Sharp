// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты уA ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

// Ab=корень из (Xb - Xa) в кдвадрате + (Yb +Ya) в квадрате

double res = Math.Sqrt (Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
// Console.WriteLine (res); // напишет результат без округления, много цифр после запятой
// либо:
// Console.WriteLine (Math.Round(res, 2));
// либо для округл.можно исп.: 
Console.WriteLine ($"{res:f2}");
