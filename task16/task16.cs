// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("введите первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());
if (Num1 * Num1 == Num2) 
    Console.WriteLine("является квадратом");
else 
{
    if (Num2 * Num2 == Num1) 
    Console.WriteLine("является квадратом");
    else 
    Console.WriteLine("не является квадратом");
}

