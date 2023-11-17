using System;

class SortingAndSearching
{
    static void Main()
    {
        // Example usage
        int[] array = GenerateRandomArray(10);

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Bubble Sort
        BubbleSortDescending(array);

        Console.WriteLine("\nSorted Array (Descending Order):");
        PrintArray(array);

        // Binary Search
        int searchValue = 42;
        int result = BinarySearch(array, searchValue);

        if (result != -1)
            Console.WriteLine($"\n{searchValue} found at index {result}.");
        else
            Console.WriteLine($"\n{searchValue} not found in the array.");
        Console.ReadKey();
    }

    static void BubbleSortDescending(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    // swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        // If the element is not present in the array
        return -1;
    }

    static int[] GenerateRandomArray(int size)
    {
        int[] arr = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1, 100); // Generates random integers between 1 and 100
        }

        return arr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
