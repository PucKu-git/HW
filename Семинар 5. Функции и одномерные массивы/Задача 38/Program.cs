/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double GetDifference(double[] array)
{
    double max = array.Max();
    double min = array.Min();
    double diff = max - min;
    return diff;
}

void PrintResult(double result)
{
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна {0}", result);
}

double[] array = new double[] { 3.22, 4.2, 1.15, 77.15, 65.2 };
double result = GetDifference(array);
PrintResult(result);