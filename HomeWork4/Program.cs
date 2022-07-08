// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Приветствую, данная программа все положительные числа от 1 до Вашего числа");
Console.Write("Введите Ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num / num;

Console.Write("Итого: ");
if(num > 0)
    while(current <= num)
    {
        Console.Write(current + " ");
        current++;
    }
else Console.Write("Вы пытаетесь нас обмунуть и ввели отрицательное число!!!");