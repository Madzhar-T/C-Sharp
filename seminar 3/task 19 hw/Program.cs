// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да.

Console.WriteLine("введите пятизначное число: ");
int nam = Convert.ToInt32(Console.ReadLine());

int temp = nam;
int last = 0;
int rev = 0;

while (nam > 0)
{
    last = nam % 10;
    rev = rev * 10 + last;
    nam = nam / 10;
}

Console.WriteLine(rev);

if (temp == rev)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

if (temp < 10000 || temp > 99999)
{
    Console.WriteLine("Введено не пятизначное число");
}