Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 && n > 4)
{
    Console.WriteLine("Неверный формат четверти, попробуйте снова: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1) // x > 0 && y > 0
    Console.WriteLine("Координаты х и у больше 0");
else if (n == 2) // х < 0 && y > 0
    Console.WriteLine("Координаты х больше 0 и у меньше 0");
else if (n == 3) //x < 0 && y < 0
    Console.WriteLine("Координаты х и у меньше 0");
else
    Console.WriteLine("Координаты х меньше 0 и у больше 0");