//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int start = 1;

while(start <= n)
{
    if (start % 2 == 0)
    {
    Console.WriteLine(start);
    }
    start++;
}

