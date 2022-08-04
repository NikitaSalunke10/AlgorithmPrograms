string[] words = {"Orange", "Apple", "Kiwi", "Banana", "Pineapple" };
Console.WriteLine("Before Sorting:");
foreach (string word in words)
{
    Console.WriteLine(word);
}
InsertSort(words);
Console.WriteLine("\nAfter Sorting:");
foreach (string word in words)
{
    Console.WriteLine(word);
}

void InsertSort(string[] array)
{
    int i, j;
    for(i = 1; i < array.Length; i++)
    {
        string word = array[i];
        j = i - 1;
        while((j >= 0) && (array[j].CompareTo(word)>0))
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j+1] = word;
    }
}