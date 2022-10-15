Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (n > 0 )
{
    n /= 10;
    result ++;
} 

Console.WriteLine(result+1);