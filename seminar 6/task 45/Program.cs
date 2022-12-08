// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] massive = {5, 4, 2, 1, 53, 234};
int[] mas = new int[massive.Length]; // создан массив такой же длины

for(int i =0; i < massive.Length; i++)
{
    mas [i] = massive [i];
}

Console.WriteLine($"{string.Join(" , ",massive)}");
Console.WriteLine($"{string.Join(" ",mas)}");