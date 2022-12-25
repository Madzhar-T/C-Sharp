// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
} 

int userNum = GetNumber("Введите число");
int res = 1;

while (userNum > 0)
{
    res = res * userNum;
    userNum --;
}

Console.WriteLine(res);
