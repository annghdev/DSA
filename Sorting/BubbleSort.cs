namespace DSA.Sorting;

public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    arr.Swap(j, j + 1);
                }
            }
        }
    }
}
