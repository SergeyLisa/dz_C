Console.WriteLine("Введите три числа ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b > a)
{
  Console.WriteLine($"Число {b} максимальное");
}
if (c > a)
{
  Console.WriteLine($"Число {c} максимальное");
}