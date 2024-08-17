for i in range(0, len(arr)):
        if arr[i] > 0:
            max_ending_here = max_ending_here * arr[i]
            min_ending_here = min(min_ending_here * arr[i], 1)
            flag = 1