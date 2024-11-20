using System.Diagnostics;

try
{
    Console.WriteLine("Введите значение d: ");
    double d = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    double F = Math.Log(d) + (3.5 * d * d + 1) / Math.Cos(2 * y);
    Console.WriteLine($"Результат F ={F}");
}
catch
{
    Console.WriteLine("Введите правильно!");
}