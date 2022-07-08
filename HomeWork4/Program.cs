// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Приветствую, данная программа все положительные числа от 1 до Вашего числа");
Console.Write("Введите Ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num / num;

Console.Write("Ваши числа: ");
while(current <= num)
{
    Console.Write(current + " ");
    current++;
}