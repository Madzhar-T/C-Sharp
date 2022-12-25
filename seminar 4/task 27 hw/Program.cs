// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumOfDig(int num)
{
    int dig = 0;
    while (num != 0)
    {
        dig = dig + num % 10;
        num /= 10;
    }
    return dig;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = SumOfDig(number);
Console.WriteLine(res);