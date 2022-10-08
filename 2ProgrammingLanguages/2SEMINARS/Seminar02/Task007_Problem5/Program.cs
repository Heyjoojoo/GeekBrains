Console.Clear();
Console.WriteLine("Введите два числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1*n1 == n2 || n2*n2 == n1)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");