// Функции, процедура

Console.Clear();
void f(ref int x, ref int y) // процедура
{
x = x + 10;
y = y + 10;
}


int n = 5;
int b = 0;

Console.WriteLine(n);
f(ref n, ref b);
Console.WriteLine(b);
// Сколько значений мы передаем, столько мы и принимаем
// Сколько значений мы принимаем, столько мы и передаем