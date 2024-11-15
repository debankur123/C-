
namespace DataStructures.Arrays;
public static class FindUnique
{
    private static int[] CountUnique(int[] elements)
    {
        Array.Sort(elements);
        List<int> uniqueElements = [];
        int indexCount = 0;
        while(indexCount<elements.Length)
        {
            int currentElement = elements[indexCount];
            int count=1;
            while(indexCount+1<elements.Length && elements[indexCount+1]==currentElement)
            {
                count++;
                indexCount++;
            }
            if(count==1)
            {
                uniqueElements.Add(currentElement);
            }
            indexCount++;
        }
        return [.. uniqueElements];
    }

    private static int CountUniqueByXOR(int[] elements)
    {
        int ans = 0;
        for (int indexCount = 0; indexCount < elements.Length; indexCount++)
        {
            ans ^= elements[indexCount];
        }
        return ans;
    }
    public static void PrintArray(int[] elem)
    {
        int uniqueElements = CountUniqueByXOR(elem);
        Console.WriteLine(string.Join(", ", uniqueElements));
    }
}


