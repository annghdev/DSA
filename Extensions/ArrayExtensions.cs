namespace DSA.Extensions;

public static class ArrayExtensions
{
    public static void Print(this int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void Swap(this int[] arr, int i, int j)
    {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }
}
