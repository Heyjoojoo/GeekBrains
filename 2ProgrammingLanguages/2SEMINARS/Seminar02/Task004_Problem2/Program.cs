// Console.Clear();

// int n = new Random().Next(100, 999);
// Console.WriteLine($"Случайное число: {n}");

// int n1 = n / 100;
// int n2 = n % 10;

// Console.Write(n1);
// Console.Write(n2);

Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine($"{n}\n{n / 100 * 10 + n % 10}");