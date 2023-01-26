namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static long Average(int[] arr)
        {
            long sum = 0;          

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }
    }
}
