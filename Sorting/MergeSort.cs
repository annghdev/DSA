namespace DSA.Sorting;

public class MergeSort
{
    public static void Sort(int[] arr)
    {
        Sort(arr, 0, arr.Length - 1);
    }

    private static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Merge(arr, left, right, mid);
        }
    }

    private static void Merge(int[] arr, int left, int right, int mid)
    {
        int nLeft = mid - left + 1;
        int nRight = right - mid;

        int[] aLeft = new int[nLeft];
        int[] aRight = new int[nRight];

        for (int i = 0; i < nLeft; i++)
        {
            aLeft[i] = arr[left + i];
        }
        for (int i = 0; i < nRight; i++)
        {
            aRight[i] = arr[mid + 1 + i];
        }
        int iLeft = 0, iRight = 0, k = left;

        while (iLeft < nLeft && iRight < nRight)
        {
            if (aLeft[iLeft] <= aRight[iRight])
            {
                arr[k] = aLeft[iLeft];
                iLeft++;
            }
            else
            {
                arr[k] = aRight[iRight];
                iRight++;
            }
            k++;
        }

        while(iLeft < nLeft)
        {
            arr[k] = aLeft[iLeft];
            iLeft++;
            k++;
        }
        while (iRight < nRight)
        {
            arr[k] = aRight[iRight];
            iRight++; 
            k++;
        }
    }
}
