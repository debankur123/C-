
// Considering the Array -> [3,5,1,4,-8] and target = 5

namespace DataStructures.Arrays
{
    public static class TwoSumLeetcode
    {
        public static int[] PairSum(int[] nums,int target)
        {
            Dictionary<int, int> map = [];
            for(int indexCounter = 0; indexCounter < nums.Length; indexCounter++)
            {
                // We will find a value when (current_element + x = target)
                // x = target - current_element concluded from the last statement
                int currentElement = nums[indexCounter];
                int assumedValue = target - currentElement;
                if(map.ContainsKey(assumedValue))
                {
                    return [map[assumedValue],indexCounter];
                }
                if (!map.ContainsKey(currentElement))
                    map.Add(currentElement, indexCounter);
            }
            return [];
        }
        
        // Driver Code
        public static class Test
        {
            private static readonly int[] InputArray = [3, 5, 1, 4, -8];
            private const int Target = 5;
            private static readonly int[] ExpectedOutput = [2, 3]; // 1 (index 2) + 4 (index 3) = 5

            public static void RunTest_TwoSumLeetcode()
            {
                int[] actualOutput = PairSum(InputArray, Target);

                Console.WriteLine("Input Array: " + string.Join(",", InputArray));
                Console.WriteLine("Target: " + Target);
                Console.WriteLine("Expected Output: " + string.Join(",", ExpectedOutput));
                Console.WriteLine("Actual Output: " + string.Join(",", actualOutput));

                Console.WriteLine(actualOutput.SequenceEqual(ExpectedOutput) ? "Test Passed!" : "Test Failed!");
            }
        }
    }
}
