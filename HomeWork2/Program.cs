// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Приветствую, данная программа определит какое из ваших чисел больше!");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max;

if(num1 > num2)
{
    max = num1;
}
    else
{
    max = num2;
}
if(num3 > max)
{
    Console.Write("Максимальное из этих чисел: " + num3);
}
else
{
    Console.Write("Максимальное из этих чисел: " + max);
}
