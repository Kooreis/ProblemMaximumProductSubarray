Here is a C# console application that solves the problem:

```csharp
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, -2, -3, 0, 7, -8, -2 };
        Console.WriteLine("Maximum Sub array product is " + MaxSubarrayProduct(arr));
    }

    static int MaxSubarrayProduct(int[] arr)
    {
        int n = arr.Length;
        int maxEndingHere = 1;
        int minEndingHere = 1;
        int maxSoFar = 0;
        int flag = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                maxEndingHere = maxEndingHere * arr[i];
                minEndingHere = Math.Min(minEndingHere * arr[i], 1);
                flag = 1;
            }
            else if (arr[i] == 0)
            {
                maxEndingHere = 1;
                minEndingHere = 1;
            }
            else
            {
                int temp = maxEndingHere;
                maxEndingHere = Math.Max(minEndingHere * arr[i], 1);
                minEndingHere = temp * arr[i];
            }

            if (maxSoFar < maxEndingHere)
                maxSoFar = maxEndingHere;
        }

        if (flag == 0 && maxSoFar == 0)
            return 0;

        return maxSoFar;
    }
}
```

This program finds the maximum product subarray in an array by iterating through the array and keeping track of the maximum product subarray ending at the current position. It also keeps track of the minimum product subarray ending at the current position because a negative number in the array could turn the maximum product into minimum at the next position. The maximum product subarray is updated at each position.