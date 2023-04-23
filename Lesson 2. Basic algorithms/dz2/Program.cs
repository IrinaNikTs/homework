// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = ;

if (num < 100 || num > 999) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    int thirdDigit = (num / 10) % 10;
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
