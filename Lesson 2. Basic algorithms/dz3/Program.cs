// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1) {
    Console.WriteLine("Это понедельник");
}
else if(number == 2) 
{
    Console.WriteLine("Это вторник");
}
else if(number == 3) 
{
    Console.WriteLine("Это среда");
}
else if(number == 4) 
{
    Console.WriteLine("Это четверг");
}
else if(number == 5) 
{
    Console.WriteLine("Это пятница");
}
else if(number == 6) 
{
    Console.WriteLine("Суббота - это выходной");
}
else if(number == 7) 
{
    Console.WriteLine("Воскресенье - это выходной");
}
else {
    Console.WriteLine("Не является днем недели");
}