namespace DSA.Sorting;

public class QuickSort
{
    public static void Sort(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        Sort(arr, left, right);
    }

    private static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            Sort(arr, left, pivotIndex - 1);
            Sort(arr, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];

        int newPivotIndex = left - 1;

        for (int i = left; i <= right; i++)
        {
            if (arr[i] <= pivot)
            {
                newPivotIndex++;
                arr.Swap(i, newPivotIndex);
            }
        }
        return newPivotIndex;
    }
}
