Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = string.Empty;
while (n > 0)
{
    int x = n % 2;
    result = Convert.ToString(x) + result;
    n = n / 2;
}
Console.WriteLine(result);

/* Рекурсия
string f(int n)
{
    if (n == 0 || n == 1)
        return $"{n}";
    return f(n / 2) + $"{n % 2}";
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/
