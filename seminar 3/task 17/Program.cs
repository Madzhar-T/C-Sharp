// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("I quarter!");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II quarter!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III quarter!");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV quarter");
}
else Console.WriteLine("ERROR!!!");