/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int ConsoleReading (string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine()!);
        return number;
    }

double NumbersToPower (int A, int B)
    {
        double power = Math.Pow(A,B);
        return power;
    }

// Определяем метод ToSuperscript, который принимает число и возвращает надстрочный индекс с помощью Юникода
 string ToSuperscript(int number)
    {
        // Преобразуем число в строку
        string numStr = number.ToString();

        // Создаем массив символов для хранения надстрочных индексов
        char[] supArray = new char[numStr.Length];

        // Используем цикл for, чтобы перебрать все символы в строке
        for (int i = 0; i < numStr.Length; i++)
        {
            // Получаем текущий символ из строки
            char c = numStr[i];

            // Проверяем, является ли символ цифрой от 0 до 9
            if (c >= '0' && c <= '9')
            {
                // Получаем код символа Юникода для надстрочного индекса соответствующей цифры
                // Для этого прибавляем к коду символа '0' разность между кодами символов '\u2070' (надстрочный индекс 0) и '0'
                int code = c + ('\u2070' - '0');

                // Преобразуем код в символ
                char sup = (char)code;

                // Добавляем символ к массиву с надстрочными индексами
                supArray[i] = sup;
            }
            else
            {
                // Если символ не является цифрой, то просто добавляем его к массиву без изменений
                supArray[i] = c;
            }
        }

        // Используем метод String.Join, чтобы объединить символы из массива в строку с надстрочным индексом
        string supStr = String.Join("", supArray);

        // Возвращаем строку с надстрочным индексом
        return supStr;
    }

int A = ConsoleReading("Введите число A: ");
int B = ConsoleReading("Введите число B: ");

string superscript = ToSuperscript(B);
Console.WriteLine("{0}{1} = {2}",A,superscript,NumbersToPower(A,B));
