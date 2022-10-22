Console.Clear();
Console.WriteLine("Введите сторону a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (c < a+b && a < b+c && b < a+c)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");