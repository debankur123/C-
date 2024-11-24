namespace DataStructures.Arrays
{
    public class FindDuplicateLeetcode
    {
        public int[] DuplicateElements(int[] nums) // Gives TLE at Leetcode or other online platforms
        {
            List<int> newArray = [];
            int countDuplicates = 1;
            for (int ithCount = 0; ithCount < nums.Length; ithCount++)
            {
                for (int jthCount = ithCount + 1; jthCount < nums.Length; jthCount++)
                {
                    if (nums[ithCount] == nums[jthCount])
                    {
                        countDuplicates++;
                        if (!newArray.Contains(nums[ithCount]))
                            newArray.Add(nums[ithCount]);
                    }
                }
            }
            return [.. newArray];
        }
        public int[] DuplicateElements2(int[] nums) // Better approach than the previous
        {
            List<int> newArray = [];
            Array.Sort(nums); // T.C O(NLogN)
            for (int ithCount = 0; ithCount < nums.Length - 1; ithCount++)
            {
                if (nums[ithCount] == nums[ithCount + 1])
                {
                    if (!newArray.Contains(nums[ithCount]))
                    {
                        newArray.Add(nums[ithCount]);
                    }
                }
            }
            return [.. newArray];
        }
        // Using a Hashset can reduce timecomplexity to O(N) but not space complexity to O(1).
        public int[] DuplicateElementsUsingHashSet(int[] elements)
        {
            HashSet<int> set = [];
            HashSet<int> duplicates = [];
            for(int indexCount=0;indexCount<elements.Length;indexCount++)
            {
                if(set.Contains(elements[indexCount]))
                {
                    duplicates.Add(elements[indexCount]);
                }
                else 
                {
                    set.Add(elements[indexCount]);
                }
            }
            return [.. duplicates];
        }

        public void PrintArray(int[] elements)
        {
            int[] result = DuplicateElementsUsingHashSet(elements);
            Console.WriteLine(string.Join(", ", result));
        }

    }

}
