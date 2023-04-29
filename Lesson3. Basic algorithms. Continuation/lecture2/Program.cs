// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: "); //приглашаем пользователя к вводу
int num = Convert.ToInt32(Console.ReadLine()); //принимаем данные


// прописываем условия =ЕСЛИ, четверти = 1/4 квадрата с осями

if (num == 1) //работает как если да
{
    System.Console.WriteLine("x > 0, y > 0");
}
else if (num == 2) //else if связывает условие с предыдущим
{
    System.Console.WriteLine("x < 0, y > 0");
}
else if (num == 3)
{
    System.Console.WriteLine("x > 0, y > 0");
}
else if (num == 4)
{
    System.Console.WriteLine("x > 0, y < 0");
}
else //срабатывает при любом раскладе, как если нет
{
    System.Console.WriteLine("Введено неверное значение");

}