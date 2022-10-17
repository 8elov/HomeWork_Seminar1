// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее число: " + a + ", меньшее число: " + b);
}

if (b > a)
{
    Console.WriteLine("Большее число: " + b + ", меньшее число: " + a);
}

if (a == b)
{
    Console.WriteLine("Число " + a + " равно числу " + b);
}