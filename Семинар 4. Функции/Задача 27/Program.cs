/*
Задача 27: Напишите программу,
которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int ConsoleReading (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

static int SumOfDigits(int number)
    {
        // Создаем переменную для хранения суммы
        int sum = 0;

        // Используем цикл while, пока число не станет равным нулю
        while (number > 0)
        {
            // Находим последнюю цифру числа, используя операцию остатка от деления на 10
            int digit = number % 10;

            // Прибавляем последнюю цифру к сумме
            sum += digit;

            // Убираем последнюю цифру из числа, используя операцию целочисленного деления на 10
            number /= 10;
        }
        // Возвращаем сумму
        return sum;
    }

int number = ConsoleReading("Введите число: ");
Console.WriteLine("Сумма цифр числа {0} равна {1}", number, SumOfDigits(number));