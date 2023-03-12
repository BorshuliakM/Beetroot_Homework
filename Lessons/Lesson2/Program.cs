int[] numbers = new int[6];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i + 1} = ");
    numbers[i] = int.Parse(Console.ReadLine());
}
Sort(numbers, SortAlghorithmType.Bubble, OrderBy.Desc);
Print(numbers);
static void SelectionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int min_idx = i;
        for (int j = i + 1; j < n; j++)
            if (arr[j] < arr[min_idx])
                min_idx = j;

        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;
    }
}
static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {

                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
}
static void InsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}
static void Sort(int[] numbers, SortAlghorithmType type, OrderBy order)
{
    switch (type)
    {
        case SortAlghorithmType.Selection:
            SelectionSort(numbers);
            break;
        case SortAlghorithmType.Bubble:
            BubbleSort(numbers);
            break;
        case SortAlghorithmType.Insertion:
            InsertionSort(numbers);
            break;
        default:
            throw new ArgumentException("Invalid sorting algorithm type.");
    }
    if (order == OrderBy.Desc) Array.Reverse(numbers);

}
static void Print(int[] numbers)
{
    foreach (int i in numbers)
    {
        Console.WriteLine($"[{i}]");
    }
}
enum SortAlghorithmType
{
    Selection,
    Bubble,
    Insertion
}
enum OrderBy
{
    Asc,
    Desc
}
