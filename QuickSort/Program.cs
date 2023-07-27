using System.Diagnostics;

public class Program
{
    static void Main()
    {
        int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };
        int[]? sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

        Console.WriteLine($"Sorted array: {string.Join(',', sortedArray)}");
        Console.ReadLine();
    }

    public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        int pivotIndex = Program.GetPivotIndex(array, minIndex, maxIndex);

        QuickSort(array, minIndex, pivotIndex - 1);

        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivotIndex = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivotIndex++;
                Swap(ref array[pivotIndex], ref array[i]);
            }
        }

        pivotIndex++;

        Swap(ref array[pivotIndex], ref array[maxIndex]);

        return pivotIndex;
    }

    private static void Swap(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;

        leftItem = rightItem;

        rightItem = temp;
    }
}