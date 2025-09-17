namespace DSA.Sorting;

public class InsertionSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int temp = arr[i];

            int j = i - 1;
            while (j >= 0 && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            j++;
            arr[j] = temp;
        }
    }
}
