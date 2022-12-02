int[] arr = { 2, 4, 1, 8, 7, 5, 6, 3, 9 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
PrintArray(arr); 