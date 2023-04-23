//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 5;
int b = 7;

int max = a;
int min = b;

if(a > b) {
    max = a;
    min = b;
}
else {
    max = b;
    min = a;
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
