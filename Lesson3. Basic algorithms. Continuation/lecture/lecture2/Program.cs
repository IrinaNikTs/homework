// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: "); //приглашаем пользователя к вводу
int num = Convert.ToInt32(Console.ReadLine()); //принимаем данные
string[] array = {
    "x > 0, y > 0", "x < 0, y > 0", "x > 0, y > 0", "x > 0, y < 0", "Введено неверное значение"
};

// прописываем условия =ЕСЛИ, четверти = 1/4 квадрата с осями

if (num == 1) //работает как "если да"
{
    System.Console.WriteLine(array[0]);
}
else if (num == 2) //else if связывает условие с предыдущим
{
    System.Console.WriteLine(array[1]);
}
else if (num == 3)
{
    System.Console.WriteLine(array[2]);
}
else if (num == 4)
{
    System.Console.WriteLine(array[3]);
}
else //срабатывает при любом раскладе, как "если нет"
{
    System.Console.WriteLine(array[4]);

}