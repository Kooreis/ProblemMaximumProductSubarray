Here is a Java console application that solves the problem:

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the length of the array:");
        int n = scanner.nextInt();
        int[] arr = new int[n];
        System.out.println("Enter the elements of the array:");
        for (int i = 0; i < n; i++) {
            arr[i] = scanner.nextInt();
        }
        System.out.println("The maximum product of subarray is: " + maxProduct(arr));
    }

    public static int maxProduct(int[] nums) {
        if (nums.length == 0) {
            return 0;
        }

        int max = nums[0];
        int min = nums[0];
        int result = max;

        for (int i = 1; i < nums.length; i++) {
            int temp_max = Math.max(nums[i] * max, Math.max(nums[i] * min, nums[i]));
            min = Math.min(nums[i] * max, Math.min(nums[i] * min, nums[i]));

            max = temp_max;

            if (max > result) {
                result = max;
            }
        }

        return result;
    }
}
```

This console application first asks the user to input the length of the array and then the elements of the array. It then calculates the maximum product subarray and prints it to the console. The `maxProduct` method calculates the maximum product by keeping track of the maximum and minimum product of the subarray ending at each position in the array. The maximum product of the subarray ending at the current position is either the current element, the maximum product of the subarray ending at the previous position times the current element, or the minimum product of the subarray ending at the previous position times the current element. The minimum product is calculated in a similar way. The maximum product of the subarray is the maximum of the maximum products of the subarrays ending at each position.