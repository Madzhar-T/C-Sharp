// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (m < n)
{
    while (m <= n)
    {
        sum = sum + m;
        m++;
    }
    Console.WriteLine(sum);
}
else
{
    while (n <= m)
    {
        sum = sum + n;
        n++;
    }
    Console.WriteLine(sum);
}