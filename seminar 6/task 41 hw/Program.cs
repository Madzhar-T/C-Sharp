// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
    } 

Console.WriteLine("Введите число или остановите ввод словом stop: ");
int number = Convert.ToInt32(Console.ReadLine());
// string stop = "stop";
int count = 0;

while (number > 0)
{
    int mumber = GetNumber("Введите число: ");
    count++;
    // if (stop...)
    {
        break;
    }
    
}

Console.WriteLine(count);