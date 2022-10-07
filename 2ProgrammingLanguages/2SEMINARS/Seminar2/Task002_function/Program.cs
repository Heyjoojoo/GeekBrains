// Функции, процедура

// Console.Clear();
// int f(ref int x, ref int y) // функция
// {
//     return a + b;
// }


// Console.WriteLine(f(5, 5));

Console.Clear();
string f(int a, int b) // функция
{
    if (a > b)
        return ">";

    return "<";
}

Console.WriteLine(f(7, 5));