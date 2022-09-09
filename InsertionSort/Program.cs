
int[] array = { 2, 6, 1, 9, 7, 3, 8, 4, 0, 5 };

PrintResult(array, "Before Sort");

// Insertion Sort
for (int i = 1; i < array.Length; i++)
{
    int current = array[i];
    int position = i;

    for (int j = i - 1; j >= 0; j--)
    {
        if (array[j] > current)
        {
            array[position] = array[j];
            position--;
        }
        else
        {
            break;
        }
    }

    array[position] = current;
}

PrintResult(array, "After Sort");


static void PrintResult(int[] array, string title)
{
    Console.WriteLine($"{title}");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("\t");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
