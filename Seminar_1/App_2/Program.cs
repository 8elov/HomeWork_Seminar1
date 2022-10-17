//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("Максимальное число: " + a);
}

if (b > a && b > c)
{
    Console.WriteLine("Максимальное число: " + b);
}

if (c > a && c > b)
{
    Console.WriteLine("Максимальное число: " + c);
}
