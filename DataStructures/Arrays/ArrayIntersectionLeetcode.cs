namespace DataStructures.Arrays
{
    public class ArrayIntersectionLeetcode
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            // suppose we haven 2 arrays arr[1,2,3,4,5] arr[2,3,4,5,6] then the Intersection will be the
            // elements that are common in both the arrays [2,3,4,5]
            var commonElements = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int ithIndex =0;
            int jthIndex =0;
            while(ithIndex < nums1.Length && jthIndex < nums2.Length)
            {
                if(nums1[ithIndex] == nums2[jthIndex])
                {
                    if(!commonElements.Contains(nums1[ithIndex]))
                    {
                        commonElements.Add(nums1[ithIndex]);
                    }
                    ithIndex++;
                    jthIndex++;
                }
                else if(nums1[ithIndex] < nums2[jthIndex])
                {
                    ithIndex++;
                }
                else 
                {
                    jthIndex++;
                }
            }
            return commonElements.ToArray();
        }
        public void PrintElements(int[] arr1, int[] arr2)
        {
            int[] intersection = Intersection(arr1, arr2);
            Console.WriteLine(string.Join(",", intersection));
        }
    }
}
