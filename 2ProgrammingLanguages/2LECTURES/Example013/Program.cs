int[] array = { 1, 12, 345, 7, 5, 34, 87, 1, 1, 9 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i] } ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]< array[minPosition]) minPosition = j; 
        }

        int temporary = array [i];          //
        array[i] = array [minPosition];     // с в а п
        array [minPosition] = temporary;    //

    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);