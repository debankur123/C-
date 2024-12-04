namespace DataStructures.Arrays;

public static class Sort012Leetcode
{
    public static void Sort(int[] arr)
    {
        int count0=0,count1=0,count2=0;
        for(int indexCount=0;indexCount<arr.Length;indexCount++)
        {
            if(arr[indexCount]==0) count0++;
            else if(arr[indexCount]==1) count1++;
            else count2++;
        }
        for(int indexCount=0;indexCount<count0;indexCount++)
        {
            arr[indexCount]=0;
        }
        for(int indexCount=count0;indexCount<count0+count1;indexCount++)
        {
            arr[indexCount]=1;
        }
        for(int indexCount=count0+count1;indexCount<arr.Length;indexCount++)
        {
            arr[indexCount]=2;
        }
    }
    public static void PrintArray(int[] elem)
    {
        Console.WriteLine("Array elements: " + string.Join(", ", elem));
    }
    
}
public static class TestSort012
{
    private static readonly int[] InputArray = [2,0,2,1,1,0];
    private static readonly int[] ExpectedOutput = [0,0,1,1,2,2];
    public static void RunTest_Sort012()
    {
        var actualOutput = (int[])InputArray.Clone();
        Sort012Leetcode.Sort(actualOutput);
        Console.WriteLine("Input Array: " + string.Join(",", InputArray));
        Console.WriteLine("Expected Output: " + string.Join(",", ExpectedOutput));
        Console.WriteLine("Actual Output: " + string.Join(",", actualOutput));
        Console.WriteLine(actualOutput.SequenceEqual(ExpectedOutput) ? "Test Passed!" : "Test Failed!");
    }
}