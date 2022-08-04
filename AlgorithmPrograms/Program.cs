int[] number = { 65, 34, 29, 75, 11, 86 };
Console.WriteLine("Before Sorting:");
display(number);
BubbleSort(number);
Console.WriteLine("\nAfter Sorting:");
display(number);

void BubbleSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        for(int j = 0; j < array.Length-i-1; j++)
        {
            if(array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}
void display(int[] array)
{
    foreach (int item in array)
    {
        Console.WriteLine(item);
    }
}