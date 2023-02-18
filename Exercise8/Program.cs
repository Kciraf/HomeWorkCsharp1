// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;

if(num >=2)
{
    while (index <= num)
    {
        System.Console.Write($"{index} ");
        index+=2;
    }
}
else
{
    System.Console.WriteLine("Нет положительных четных чисел до указанного числа");
}