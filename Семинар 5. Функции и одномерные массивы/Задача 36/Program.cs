/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GenerateArrey (int length)
{
    int[] numbers = new int [length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.Next(-99,99);
    }
    return numbers;
}

int SummNotEven (int[] targetArray)
{
    int summ = 0;
    for (int i = 0; i < targetArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ=summ+targetArray[i];
        }
    }
    return summ;
}

int[] array = GenerateArrey(4);
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("{0}", SummNotEven(array));