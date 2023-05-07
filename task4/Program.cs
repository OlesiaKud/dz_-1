// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A > B && A > C)
{
    Console.WriteLine($" MAX = {A}");
}
else if (B > A && B > C)
{
    Console.WriteLine($" MAX = {B}");
}
else if (C > A && C > B)
{
Console.WriteLine($" MAX = {C}");
}
