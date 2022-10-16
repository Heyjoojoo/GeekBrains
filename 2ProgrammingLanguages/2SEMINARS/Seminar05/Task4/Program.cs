Console.Clear();

void fillArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-100,101);
}

int showNumbers (int[] array, int numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 100 && array[i] > 9)
        numbers = numbers +1;
    }
    return numbers;
}

int[] array = new int [123];
fillArray(array);
Console.WriteLine($"Вот такой массив что ли [{string.Join(", ", array)}]");
int numbers = 0;
Console.WriteLine($"{showNumbers(array, numbers)}");

