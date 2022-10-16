Console.Clear();
void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-100, 99);
}


string ReleaseArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
         if (array [i] == number)
            return "yes";
    }
    return "no";
}

Console.Clear();

Console.WriteLine($"Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int [n];
InputArray(array);
Console.WriteLine($"Получился массив [{string.Join(", ", array)}]");
Console.WriteLine("Введите число, которое вы хотите найти: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ReleaseArray(array,m)}");