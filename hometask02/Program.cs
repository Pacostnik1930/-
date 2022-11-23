// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(a > b && a > c)
{
Console.WriteLine(a);
}
else

if(b > c)
{
Console.WriteLine(b);
}
else
{
Console.WriteLine(c);
}
