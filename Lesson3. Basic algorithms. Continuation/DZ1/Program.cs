// // Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string numberStr = Console.ReadLine();

// Проверяем длину введенной строки
if (numberStr.Length != 5)
{
System.Console.WriteLine("Введено неверное количество цифр");
}
else
{
// Получаем отдельные символы из строки
char number1 = numberStr[0];
char number2 = numberStr[1];
char number3 = numberStr[2];
char number4 = numberStr[3];
char number5 = numberStr[4];

// Проверяем является ли число палиндромом
if (number1 == number5 && number2 == number4)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}
}


