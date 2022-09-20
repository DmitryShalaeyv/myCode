// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Первое число -> ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число -> ");
int num2 = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (num1 > num2) 
{
    max = num1;
    min = num2;
}
else {
     max = num2;
     min = num1;
}
Console.WriteLine($" Mаксимальное число {max}");
Console.WriteLine($" Mинимальное число {min}");



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Первое число -> ");
int num11 = int.Parse(Console.ReadLine());

Console.WriteLine("Второе число -> ");
int num21 = int.Parse(Console.ReadLine());

Console.WriteLine("Третье число -> ");
int num31 = int.Parse(Console.ReadLine());

int max1 = num11;
if (max1 < num21) max1 = num21;
if (max1 < num31) max1 = num31;

Console.WriteLine($" Mаксимальное число:  {max1}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("введите число -> ");
int num = int.Parse(Console.ReadLine());

int val = num % 2;

if (val == 1) Console.WriteLine($"Число {num} не четное");
else Console.WriteLine($"Число {num} четное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("введите число -> ");
int N = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Четные числа: ");
for(int i = 1; i <= N; i++) {
    if (i % 2 == 0) Console.WriteLine(i);
}




