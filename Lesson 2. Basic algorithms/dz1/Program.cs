// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = (number / 10) % 10;
Console.WriteLine("Вторая цифра числа: " + secondDigit);
