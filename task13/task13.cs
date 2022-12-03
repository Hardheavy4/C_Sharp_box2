Console.Write("Введите число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
string Num2 = Convert.ToString(Num1);
if (Num2.Length > 2)
  Console.WriteLine("третья цифра -> " + Num2[2]);
else 
Console.WriteLine("-> третьей цифры нет");
