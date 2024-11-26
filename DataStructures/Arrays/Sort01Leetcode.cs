namespace DataStructures.Arrays
{
    public class Sort01Leetcode
    {
        public void Sort01(int[] nums)
        {
            // We will do this using a two pointer approach
            int leftIndex = 0,rightIndex = nums.Length - 1;
            while(leftIndex < rightIndex)
            {
                while(nums[leftIndex] == 0 && leftIndex < rightIndex)
                {
                    leftIndex++;
                }
                while(nums[rightIndex] == 1 && leftIndex < rightIndex)
                {
                    rightIndex--;
                }
                if(leftIndex < rightIndex)
                {
                    (nums[leftIndex], nums[rightIndex]) = (nums[rightIndex], nums[leftIndex]);
                    leftIndex++;
                    rightIndex--;
                }
            }
        }
    }
    // Driver Code
    public static class Test
    {
        private static int[] InputArray = [1, 1, 0, 0, 0, 0, 1, 0];
        private static int[] ExpectedOutput = [0, 0, 0, 0, 0, 1, 1, 1];
        public static void RunTestSort01()
        {
            var solution = new Sort01Leetcode();
            var actualOutput = (int[])InputArray.Clone();
            solution.Sort01(actualOutput);
            Console.WriteLine("Input Array: " + string.Join(",", InputArray));
            Console.WriteLine("Expected Output: " + string.Join(",", ExpectedOutput));
            Console.WriteLine("Actual Output: " + string.Join(",", actualOutput));
            Console.WriteLine(actualOutput.SequenceEqual(ExpectedOutput) ? "Test Passed!" : "Test Failed!");
        }
    }
}
