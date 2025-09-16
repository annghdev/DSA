namespace DSA.Sorting;

public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = FindMinIndex(arr, i);
            arr.Swap(i, minIndex);
        }
    }

    private static int FindMinIndex(int[] arr, int startIndex)
    {
        int minIndex = startIndex;
        for (int i = startIndex + 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }
}
