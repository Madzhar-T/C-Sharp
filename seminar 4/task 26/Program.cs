// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
} 

bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int NunOfDig(int num)
{
    int dig = 0;
    while (num > 0)
    {
        num /= 10; // num = num / 10;
        dig ++; // dig = dig +1;
    }
    return dig;
}


int userNumber = GetNumber("Введите число");
bool isCorrect = Validate(userNumber);

if (isCorrect == true)
{
    int count = NunOfDig(userNumber);
    Console.WriteLine($"Количество цифр в числе = {count}");
}
else
{
    Console.WriteLine("Невозможно посчитать количество чисел");
}






