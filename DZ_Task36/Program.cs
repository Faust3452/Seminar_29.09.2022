// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] MassFill(int range, int min, int max)
{
    int[] arr = new int[range];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(min, max+1);
    return arr;
}

void PrintArray(int[] arr)
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

int NotEvenPosCount(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count += arr[i];
    }
    return count;
}

Console.Write("Введите размер массива для генерации: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний предел для генерации значений массива: ");
int minGen = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний предел для генерации значений массива: ");
int maxGen = Convert.ToInt32(Console.ReadLine());
if (minGen > maxGen) Console.WriteLine("Введенные вами пределы неверны. Нижний предел больше верхнего. \nПовторите ввод!");
else
{
    int[] array = MassFill(size, minGen, maxGen);
    Console.Write("Сгенерированный массив: ");
    PrintArray(array);
    int countNotEvenPos = NotEvenPosCount(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве: {countNotEvenPos}");    
}
