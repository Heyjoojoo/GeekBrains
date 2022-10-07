Console.Clear();
Console.WriteLine("Введите два числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n2 % n1 == 0)
    Console.WriteLine($"Число {n1} кратно числу {n2}");
else
    Console.WriteLine($"Число {n1} не кратно числу {n2}\n Остаток от деления: {n1%n2}");
