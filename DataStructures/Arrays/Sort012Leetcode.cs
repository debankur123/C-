namespace DataStructures.Arrays;

public static class Sort012Leetcode
{
    public static void Sort(int[] arr)
    {
        int count0 = 0, count1 = 0, count2 = 0;
        for (int indexCount = 0; indexCount < arr.Length; indexCount++)
        {
            if (arr[indexCount] == 0) count0++;
            else if (arr[indexCount] == 1) count1++;
            else count2++;
        }
        for (int indexCount = 0; indexCount < count0; indexCount++)
        {
            arr[indexCount] = 0;
        }
        for (int indexCount = count0; indexCount < count0 + count1; indexCount++)
        {
            arr[indexCount] = 1;
        }
        for (int indexCount = count0 + count1; indexCount < arr.Length; indexCount++)
        {
            arr[indexCount] = 2;
        }
    }
    public static void DutchNationalFlagAlgorithm(List<int> arr) // Time complexity remains O(N)
    {
        int leftIndex = 0, rightIndex = arr.Count - 1;
        int currentIndex = 0;
        while (currentIndex <= rightIndex)
        {
            if (arr[currentIndex] == 0)
            {
                (arr[currentIndex], arr[leftIndex]) = (arr[leftIndex], arr[currentIndex]);
                leftIndex++;
                currentIndex++;
            }
            else if (arr[currentIndex] == 2)
            {
                (arr[currentIndex], arr[rightIndex]) = (arr[rightIndex], arr[currentIndex]);
                rightIndex--;
            }
            else
            {
                currentIndex++;
            }
        }
    }
    public static void PrintArray(int[] elem)
    {
        Console.WriteLine("Array elements: " + string.Join(", ", elem));
    }
}
public static class TestSort012
{
    private static readonly int[] InputArray = [2, 0, 2, 1, 1, 0];
    private static readonly int[] ExpectedOutput = [0, 0, 1, 1, 2, 2];
    public static void RunTest_Sort012()
    {
        var actualOutput = InputArray.ToList();
        Sort012Leetcode.DutchNationalFlagAlgorithm(actualOutput);
        Console.WriteLine("Input Array: " + string.Join(",", InputArray));
        Console.WriteLine("Expected Output: " + string.Join(",", ExpectedOutput));
        Console.WriteLine("Actual Output: " + string.Join(",", actualOutput));
        Console.WriteLine(actualOutput.SequenceEqual(ExpectedOutput) ? "Test Passed!" : "Test Failed!");
    }
}