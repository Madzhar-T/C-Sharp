// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
} 

int a = GetNumber("Введите число A: ");
int b = GetNumber("Введите число B: ");
int c = GetNumber("Введите число C: ");

if (a < b+c && b < a+c && c < a+b)
{
    Console.WriteLine ("треугольник с такими сторонами может существовать");
}
else
{
    Console.WriteLine ("треугольник с такими сторонами не может существовать");
}
