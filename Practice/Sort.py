
def merge(left_arr, right_arr):
    result = []
    while len(left_arr) and len(right_arr)> 0:
        if(left_arr[0])  < right_arr[0]:
           result.append(left_arr.pop(0))
        else:
            result.append(right_arr.pop(0))
    
    while len(left_arr) > 0:
        result.append(left_arr.pop(0))
    while len(right_arr) > 0:
        result.append(right_arr.pop(0))
    
    return result
def mergesort(nums):
    '''
    Divide
    Split into two 
    Sort right
    Sort left
    Conquer
    Merge left and right

    o()
    '''
    if len(nums) <= 1:
        return nums
    
    result = []
    mid =  len(nums)//2
    left_arr = mergesort(nums[:mid])
    right_arr = mergesort(nums[mid:])
    return merge(left_arr,right_arr)

assert(mergesort([4,2,6,1])==[1,2,4,6])
assert(mergesort([4,120,6,1])==[1,4,6,120])
assert(mergesort([])==[])
assert(mergesort([2])==[2])


def selectionsort(nums):
    if len(nums) <=1:
        return nums
    
    for i in range(len(nums)-1):
        for j in range(i+1,len(nums)):
            if nums[j] < nums[i]:
                nums[i], nums[j] = nums[j], nums[i]

    return nums

assert(selectionsort([4,2,6,1])==[1,2,4,6])
assert(selectionsort([4,120,6,1])==[1,4,6,120])
assert(selectionsort([])==[])
assert(selectionsort([2])==[2])




def insertionsort(nums):
    if len(nums) <=1: 
        return nums
    
    for i in range(1, len(nums)):
        current_val =  nums[i]
        pointer = i-1

        while pointer > -1 and nums[pointer] > current_val:
            nums[pointer+1] = nums[pointer] 
            pointer-=1
        nums[pointer+1] =  current_val # check this
        
    return nums

assert(insertionsort([4,2,6,1])==[1,2,4,6])
assert(insertionsort([4,120,6,1])==[1,4,6,120])
assert(insertionsort([])==[])
assert(insertionsort([2])==[2])


def bubblesort(nums):
    if len(nums) <=1: 
        return nums

    for i in range(len(nums)):
        for j in range((len(nums)-i-1)):
            if nums[j] > nums[j+1]:
                nums[j], nums[j+1] = nums[j+1], nums[j]
    
    return nums



assert(bubblesort([4,2,6,1])==[1,2,4,6])
assert(bubblesort([4,120,6,1])==[1,4,6,120])
assert(bubblesort([])==[])
assert(bubblesort([2])==[2])
