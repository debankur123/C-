namespace DataStructures.Arrays
{
    // I have an arrays [2, 4, 6, 8, 10, 12];
    // After swapping alternate it would be -> [4,2,8,6,12,10] 

    public static class SwapAlternate 
    {
        public static void SwapAlternateElement(int[] evenArray)
        {
            for (int indexCount = 0; indexCount < evenArray.Length - 1; indexCount += 2)
            {
                if (indexCount + 1 < evenArray.Length)
                {
                    Swap(evenArray);
                }
            }
            for (int count = 0; count < evenArray.Length; count++)
            {
                Console.Write(evenArray[count] + " ");
            }
        }

        private static void Swap(int[] evenArray)
        {
            for (int indexCount = 0; indexCount < evenArray.Length; indexCount += 2)
            {
                (evenArray[indexCount + 1], evenArray[indexCount]) = (evenArray[indexCount], evenArray[indexCount + 1]);
            }
        }
    }
}