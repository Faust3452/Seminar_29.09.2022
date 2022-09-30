// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] MassFill(int range)
{
    int[] arr = new int[range];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(100,1000);
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

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)   
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}

Console.Write("Введите размер массива для генерации: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = MassFill(size);
Console.Write("Сгенерированный массив: ");
PrintArray(array);
int evenCount = CountEvenNumbers(array);
Console.WriteLine($"Количество четных элементов в массиве: {evenCount}");
