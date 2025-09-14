namespace DSA.Extensions;

public static class ArrayExtensions
{
    public static void Print(this int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}
