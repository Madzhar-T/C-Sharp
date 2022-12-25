// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Данные вводятся с консоли пользователем

int GetNumber(string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine());
} 

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = GetNumber("Введите число: ");
}
Console.WriteLine($"[{string.Join(", ", array)}]");