/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GenerateArrey (int length)
{
    int[] numbers = new int [length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.Next(100,999);
    }
    return numbers;
}

int CountEven (int[] targetArray)
{
    int count = 0;
    for (int i = 0; i < targetArray.Length; i++)
    {
        if (targetArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GenerateArrey(10);
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("{0}", CountEven(array));