// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange +1 );
    }
    return array;
}

const int SIZE = 7;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 20;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int max = arr[0];
int min = arr[0];
int diff = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if(arr[i] < min)
    {
        min = arr[i];
    }
}

diff = max - min;

Console.WriteLine($"максимальное значение {max}");
Console.WriteLine($"минимальное значение {min}");
Console.WriteLine($"разница {diff}");