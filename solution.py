Here is a Python console application that solves the problem:

```python
def max_product_subarray(arr):
    max_ending_here = 1
    min_ending_here = 1
    max_so_far = 0
    flag = 0

    for i in range(0, len(arr)):
        if arr[i] > 0:
            max_ending_here = max_ending_here * arr[i]
            min_ending_here = min(min_ending_here * arr[i], 1)
            flag = 1

        elif arr[i] == 0:
            max_ending_here = 1
            min_ending_here = 1

        else:
            temp = max_ending_here
            max_ending_here = max(min_ending_here * arr[i], 1)
            min_ending_here = temp * arr[i]

        if max_so_far < max_ending_here:
            max_so_far = max_ending_here

    if flag == 0 and max_so_far == 0:
        return 0
    return max_so_far


if __name__ == "__main__":
    arr = list(map(int, input("Enter the array elements separated by space: ").split()))
    print("Maximum product subarray is: ", max_product_subarray(arr))
```

This console application takes an array of integers as input from the user and prints the maximum product of a subarray. The function `max_product_subarray` calculates the maximum product of a subarray in the given array. It uses a variable `max_ending_here` to keep track of the maximum product till the current element and `min_ending_here` to keep track of the minimum product till the current element. The variable `max_so_far` is used to store the maximum product of a subarray found so far. The flag variable is used to handle the case when all elements in the array are negative.