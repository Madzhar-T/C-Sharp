// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
} 

int a = GetNumber("Введите число А: ");
int b = GetNumber("Введите число B: ");
int res = 1;

while (b >= 1)
{
    res = res * a;
    b --;
}
Console.WriteLine(res);