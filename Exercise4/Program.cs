// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число для сравнения: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число для сравнения: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число для сравнения: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c)
{
    System.Console.WriteLine($"a = {a}, b = {b}, c = {c} - > max = {a}");
}
else if (b >= a && b >= c)
{
    System.Console.WriteLine($"a = {a}, b = {b}, c = {c} - > max = {b}");
}
else
{
    System.Console.WriteLine($"a = {a}, b = {b}, c = {c} - > max = {c}");
}