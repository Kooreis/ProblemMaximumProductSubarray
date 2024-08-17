static int MaxSubarrayProduct(int[] arr)
    {
        int n = arr.Length;
        int maxEndingHere = 1;
        int minEndingHere = 1;
        int maxSoFar = 0;
        int flag = 0;