// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Enter quarter -> ");
int q = Convert.ToInt32(Console.ReadLine());

if (q == 1)
{
    Console.Write("x > 0; y > 0");
}
else if (q == 2)
{
    Console.Write("x < 0; y > 0");
}
else if (q == 3)
{
    Console.Write("x < 0; y < 0");
}
else if (q == 4)
{
    Console.Write("x > 0; y < 0");
}
else Console.WriteLine("ERROR!");
