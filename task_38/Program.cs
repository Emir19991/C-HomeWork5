// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MinNum(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxNum(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double DifferenceMaxMin(double[] arr)
{
    double difference = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        difference = MaxNum(arr) - MinNum(arr);
    }
    return difference ;
}




double[] array = CreateArrayRndDouble(4, 1, 100);
double difference = DifferenceMaxMin(array);
Console.Write("[");
PrintArrayDouble(array, ",");
Console.Write("]");
Console.WriteLine($" Разница между максимальным и минимальным элементом массива равна: {Math.Round(difference, 1)}  "); //Math.Round(difference)