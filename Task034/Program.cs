// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] ArrayCreation(int arrayLengh)
{
    int[] array = new int[arrayLengh];
    for (int i = 0; i < arrayLengh; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.Write($"Количество четных членов массива = {count}");
}

Console.Write("Введите длину желаемого массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = ArrayCreation(arrayLength);
PrintArray(myArray);
NumberOfEven(myArray);