// Принимает на вход X и Y, при этом х не равно 0, Y не равно 0

int ReadInt(string text)
{
    System.Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
}


void CheckQuarter(int[]array, string[] prints)
{
    if (array[0] > 0 && array[1] > 0)
{
    System.Console.WriteLine(prints[0]);
}
else if (array[0] < 0 && array[1] > 0)
{
    System.Console.WriteLine(prints[1]);
}
else if (array[0] < 0 && array[1] < 0)
{
    System.Console.WriteLine(prints[2]);
}
else if (array[0] < 0 && array[1] < 0)
{
    System.Console.WriteLine(prints[3]);
}
else if (array[0] < 0 && array[1] < 0)
{
    System.Console.WriteLine(prints[4]);
}

}


int[] coords = new int[2];

coords[0] = ReadInt("Введите координату точки X");
coords[1] = ReadInt("Введите координату точки Y");

string[] str = {"Точка лежит в первой четверти", "Точка лежит во второй четверти", "Точка лежит в третьей четверти", "Точка лежит в четвертой четверти"}

CheckQuarter(coords,str);







