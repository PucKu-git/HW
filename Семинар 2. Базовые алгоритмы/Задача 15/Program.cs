/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int ConsoleReading (string message)
    {
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
    }
    
bool IsWeekend(int digit)
{
    // Проверяем, что цифра в допустимом диапазоне от 1 до 7
    if (digit >= 1 && digit <= 7)
    {
    // Проверяем, является ли цифра 6 или 7, что соответствует субботе или воскресенью
        if (digit == 6 || digit == 7)
        {
            return true; // это выходной
        }
        else
        {
            return false; // это рабочий день
        }
    }
    else
    {
        Console.WriteLine("Неверная цифра");
        return false;
    }
}

void  Answer (int digit)
{
if (IsWeekend(digit))
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}

// Считываем цифру с консоли
int digit = ConsoleReading ("Введите цифру от 1 до 7: ");
Answer(digit);