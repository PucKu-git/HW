/* 
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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

int CountNotZerro (int[] targetArray)
{
    int count = 0;
    for (int i = 0; i < targetArray.Length; i++)
    {
        if (targetArray[i] > 0)
        {
            count++;
        }
    }
    return count;
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
Console.Write("{0}",CountNotZerro(array));