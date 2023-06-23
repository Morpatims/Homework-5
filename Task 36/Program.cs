Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


int SumOfOddElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count += array[i];
    }

    return count;
}
int[] arr = GetRandomArray(20, -100, 100);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(SumOfOddElements(arr));