// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] MassFillRand(int range, int min, int max)
{
    double[] arr = new double[range];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = min + rnd.NextDouble() * (max - min);
        arr[i] = Math.Round(arr[i], 2, MidpointRounding.ToZero);
    }
    return arr;
}

double[] MassFillManual(int range)
{
    double[] arr = new double[range];
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.WriteLine($"Введите {i}-ый элемент массива: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

double MaxMinDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    double diff = max - min;
    return diff;
}

Console.Write("Введите размер массива для генерации: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 0 для генерации массива случайным образом. Для задания массива вручную введите любое другое значение: ");
string varGen = Console.ReadLine();
double[] array = new double[size];

if (varGen == "0")
{
    Console.Write("Введите нижний предел для генерации значений массива: ");
    int minGen = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхний предел для генерации значений массива: ");
    int maxGen = Convert.ToInt32(Console.ReadLine());
    if (minGen > maxGen) Console.WriteLine("Введенные вами пределы неверны. Нижний предел больше верхнего. \nПовторите ввод!");
    else
    {
        array = MassFillRand(size, minGen, maxGen);
    }   
}
else 
{
    array = MassFillManual(size);
    Console.Write("Полученный массив: ");
    PrintArray(array);
}

Console.Write("Полученный массив: ");
PrintArray(array);
double difference = MaxMinDiff(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {difference}");
