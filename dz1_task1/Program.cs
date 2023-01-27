
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
  Console.WriteLine("число {a} больше");
  Console.WriteLine("число {b} меньше");
}
if (a < b)
{
  Console.WriteLine($"число {b} больше");
  Console.WriteLine($"число {a} меньше");
}