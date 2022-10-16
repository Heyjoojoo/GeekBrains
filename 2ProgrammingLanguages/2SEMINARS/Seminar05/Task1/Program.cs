void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-9, 10);
}

int SumPositiveNumbers (int [] array)
{
    int summapositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
            summapositive = summapositive + array[i];
    }
    return summapositive;
}

int SumNegativeNumbers (int [] array)
{
    int summanegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
            summanegative = summanegative + array[i];
    }
    return summanegative;
}

Console.Clear();
int [] array = new int [12];

InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных чисел: {SumPositiveNumbers(array)}");
Console.WriteLine($"Сумма отрицательных чисел: {SumNegativeNumbers(array)}");
