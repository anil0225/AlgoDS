
def binarysearch(num, list):
  ```
  o(log(n))
  o(1)
  ```

  if not list or len(list) ==0:
    return -1
  
  left = 0
  right = len(list)-1
  while left <= right:
    mid = (left+right)//2
    if list[mid] == num:
      return mid

    if list[mid] > num:
      right = mid-1
    else
      left = mid+1

  return -1

print(binarysearch(4,[1,2,3,4]))
print(binarysearch(22,[11,14,18,21],22,64,104))
