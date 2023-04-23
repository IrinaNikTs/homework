//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    Console.WriteLine("Первое число больше второго");
    Console.WriteLine("Наибольшее число: " + a);
    Console.WriteLine("Наименьшее число: " + b);
}
else if (a < b) {
    Console.WriteLine("Второе число больше первого");
    Console.WriteLine("Наибольшее число: " + b);
    Console.WriteLine("Наименьшее число: " + a);
}
else {
    Console.WriteLine("Числа равны");
}