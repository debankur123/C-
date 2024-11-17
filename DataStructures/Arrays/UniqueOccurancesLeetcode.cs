
namespace DataStructures.Arrays
{
    public class UniqueOccurancesLeetcode
    {
        public bool IsUnique(int[] arr)
        {
            int[] increasedSizeArray = new int[2001];
            for(int countIndex=0;countIndex<arr.Length;countIndex++)
            {
                increasedSizeArray[arr[countIndex] + 1000]++;
            }
            Array.Sort(increasedSizeArray);
            for(int countIndex=1;countIndex<2001;countIndex++)
            {
                if(increasedSizeArray[countIndex]!=0 && increasedSizeArray[countIndex]==increasedSizeArray[countIndex-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}