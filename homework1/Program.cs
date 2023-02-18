// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
    Console.WriteLine("Первое число больше второно, второе меньше первого");
}
else
{
    Console.WriteLine("Второе число больше первого, первое меньше второго");

}
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (x > max) max = x;
if (y > max) max = y;
if (z > max) max = z;
Console.Write("max = ");
Console.WriteLine(max);

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine("Чиcло четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count < N)
{
    if ( count % 2 == 0)
    {
       Console.WriteLine(count);
    }
    count = count + 1;
}
