// Принимает на вход X и Y, при этом х не равно 0, Y не равно 0

int ReadInt(string text)
{
    System.Console.Write(text);
    int number - Convert.ToInt32(Console.ReadLine());
}


void 



int[] coords - new int[2];

coords[0] - ReadInt("Введите координату точки X");
coords[1] - ReadInt("Введите координату точки Y");

string[] str - {"Точка лежит в первой четверти", "Точка лежит во второй четверти", "Точка лежит в третьей четверти", "Точка лежит в четвертой четверти"; "Точка лежит в пятой четверти"}

if (coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine(str[0]);
}
else if (coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine(str[1]);
}
else if (coords[0] < 0 && coords[2] > 0)
{
    System.Console.WriteLine(str[2]);
}
else if (coords[0] < 0 && coords[3] > 0)
{
    System.Console.WriteLine(str[3]);
}
else if (coords[0] < 0 && coords[4] > 0)
{
    System.Console.WriteLine(str[4]);
}
else if (coords[0] < 0 && coords[5] > 0)
{
    System.Console.WriteLine(str[5]);
}







