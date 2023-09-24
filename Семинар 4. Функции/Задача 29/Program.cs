/*
Задача 29: Напишите программу,
которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

string ConsoleReading(string message)
{
    Console.Write(message);
    string input = Console.ReadLine()!;
    return input;
}

int[] FormatArray(string numbers)
{
    string[] words = numbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
        array[i] = int.Parse(words[i]);
    }
    return array;
}


void PrintArray(int[] inArray)
{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write(inArray[i]);
        if (i < inArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string input = ConsoleReading("Введите массив чисел: ");
int[] array = FormatArray(input);
PrintArray(array);