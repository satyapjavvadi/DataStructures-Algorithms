using System;

public class MaxConsecutiveOnes
{
    public static int FindMaxConsecutiveOnes(int[] arr)
    {
        int end = 0, maxOnes = 0;
        for(int start = 0; start < arr.Length; start++)
        {
            if(arr[start] != 0)
            {
                end++;
            }
            else
            {
                end = 0;
            }
            if(maxOnes < end)
            {
                maxOnes = end;
            }
        }
        return maxOnes;
    }
    public static void Test()
    {
        int[] arr = { 1, 1, 0, 1, 1, 1 };
        int maxOnes = FindMaxConsecutiveOnes(arr);
        Console.WriteLine(maxOnes);
    }
}
