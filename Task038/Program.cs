// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] ArrayCreation(int arrayLenth)
{
    double[] array = new double[arrayLenth];
    for (int i = 0; i < arrayLenth; i++) array[i] = new Random().NextDouble() * 1000;
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double FindMaxArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double FindMinArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Введите длину желаемого массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
double[] myArray = ArrayCreation(arrayLength);
PrintArray(myArray);  //В длинных массивах лучше не печатать элементы массива
Console.WriteLine($"Максимальный элемент массива =  {FindMaxArray(myArray)}");
Console.WriteLine($"Минимальный элемент массива = {FindMinArray(myArray)}");
//В длинных массивах для экономии процессорного времени лучше сохранить
//вычесления максимального и минимального элемента в переменных
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {FindMaxArray(myArray) - FindMinArray(myArray)}");
