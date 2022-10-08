Console.Clear();
Console.Write("Введите координату х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
    Console.Write("Введите координату х: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.Write("Введите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");