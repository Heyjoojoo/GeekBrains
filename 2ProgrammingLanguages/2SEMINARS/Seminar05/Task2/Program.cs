Console.Clear();
void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-100, 99);
}

void oldNumbers (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = array [i] * (-1);
    }
}

int [] array = new int [12];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
oldNumbers (array);
Console.WriteLine($"[{string.Join(", ", array)}]");


