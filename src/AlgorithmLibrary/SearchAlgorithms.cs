using System.Buffers;

namespace AlgorithmLibrary;

public class SearchAlgorithms
{
    public int BinarySearch(int[] array, int target)
    {
        if (array.Length == 0) return -1;
        if (array.Length == 1 && array[0] == target) return 0;

        array = [.. array.Order()];
        int start = 0, end = array.Length - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (target > array[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return -1;
    }
}
