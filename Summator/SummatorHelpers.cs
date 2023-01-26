internal static class SummatorHelpers
{

    //Test method for sum of array from numbers
    public static long Sum(int[] arr)
    {
        long sum = 0;
        for (int i = 1; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }
}