// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int t = 0;

// while (t <= num)
// {
//     Console.Write($"{t*t}, ");
//     t++;
// }

for (int t = 0; t <= num; t++)
{
    Console.Write($"{t*t}, ");
}