Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 23 == 0 && n % 7 == 0)
    Console.WriteLine($"Число {n} кратно 7 и 23");
else
    Console.WriteLine($"Число {n} не кратно 7 и 23");
