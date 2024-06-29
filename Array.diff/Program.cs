namespace Array.diff;

public class Kata
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }

    public static int[] ArrayDiff(int[] A, int[] B)
    {
        int[] sameElement = new int[A.Length];
        int sameElementIndex = 0;
        int[] C = new int[A.Length];
        int indexOfC = 0;

        foreach (var a in A)
        {
            // First we check if a is in sameElement array
            if (Kata.ExistsInSubrange(sameElement, sameElementIndex, a))
            {
                continue;
            }

            // Now check if a exists in B
            if (System.Array.Exists(B, e => e == a))
            {
                sameElement[sameElementIndex] = a;
                sameElementIndex += 1;
                continue;
            }

            // If a neither existed in sameElement, nor in B it must be a unique value in A,
            // so we use it to build the result.
            C[indexOfC] = a;
            indexOfC += 1;
        }

        System.Array.Resize(ref C, indexOfC);
        return C;
    }

    private static bool ExistsInSubrange(int[] array, int subRangeLength, int value)
    {
        for (int i = 0; i < subRangeLength; i++)
        {
            if (array[i] == value)
            {
                return true;
            }
        }
        return false;
    }
}

