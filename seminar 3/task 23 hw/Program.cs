// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int t = 1; t <= num; t++)
{
    Console.Write($"{Math.Pow(t, 3)}, ");
}

