// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine ("введите число");
int n = Convert.ToInt32(Console.ReadLine());

int[] feb = new int[n];
feb[0] = 0;
feb[1] = 1;
for (int i = 2; i < n; i++)
{
    feb[i] = feb[i - 2] + feb[i - 1];
} 
Console.WriteLine($"{string.Join(" ",feb)}");



// Второй вариант

// void Check(int n)
// {
//     int numberOne = 0;
//     int numberTwo = 1;
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write(numberOne + " ");
//         int x = numberOne + numberTwo;
//         numberOne = numberTwo;
//         numberTwo = x;
//     }
// }
// Console.WriteLine("Введите колличество символов");
// int n = int.Parse(Console.ReadLine()!);
// Check(n);
