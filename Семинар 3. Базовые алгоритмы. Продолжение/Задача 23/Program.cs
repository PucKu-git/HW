/*
Задача 23: Напишите программу,
которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
*/
using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
        int counter=1;
        while (counter <= N)
        {
        Console.WriteLine("Куб числа " + counter + " равно " + Math.Pow(counter,3));
        counter ++;
        }
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}