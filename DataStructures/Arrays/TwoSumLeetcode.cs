
// Considering the Array -> [3,5,1,4,-8] and target = 5


namespace DataStructures.Arrays
{
    public class TwoSumLeetcode
    {
        public int[] PairSum(int[] nums,int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int indexCounter = 0; indexCounter < nums.Length; indexCounter++)
            {
                // We will find a value when (currentelement + x = target)
                // x = target - currentelement concluded from the last statement
                int currentElement = nums[indexCounter];
                int assumedValue = target - currentElement;
                if(map.ContainsKey(assumedValue))
                {
                    return new int[] {map[assumedValue],indexCounter};
                }
                if (!map.ContainsKey(currentElement))
                    map.Add(currentElement, indexCounter);
            }
            return [];
        }
        
        // Driver Code
        public static class Test
        {
            private static int[] InputArray = { 3, 5, 1, 4, -8 };
            private static int Target = 5;
            private static int[] ExpectedOutput = { 2, 3 }; // 1 (index 2) + 4 (index 3) = 5

            public static void RunTest()
            {
                var solution = new TwoSumLeetcode();

                int[] actualOutput = solution.PairSum(InputArray, Target);

                Console.WriteLine("Input Array: " + string.Join(",", InputArray));
                Console.WriteLine("Target: " + Target);
                Console.WriteLine("Expected Output: " + string.Join(",", ExpectedOutput));
                Console.WriteLine("Actual Output: " + string.Join(",", actualOutput));

                if (actualOutput.SequenceEqual(ExpectedOutput))
                {
                    Console.WriteLine("Test Passed!");
                }
                else
                {
                    Console.WriteLine("Test Failed!");
                }
            }
        }
    }
}
