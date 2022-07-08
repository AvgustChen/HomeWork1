// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Приветствую, данная программа определит какое из ваших чисел больше!");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Из данных чисел большим является: " + num1);
}
else
{
    Console.WriteLine("Из данных чисел большим является: " + num2);
}