# Search and their Analysis
 
## Linear Search
    - Search the elements One by One until the item is found
    - Worst Case O(n)
  
## Binary Search
    - Given a Sorted array
    - Goto to mid of the Array , check if the Mid pointer is the value
    - Else check if Left (start to mid-1) or the Right (mid+1 to end) would have the Input value
    - Continue above step 
    - Worst case O(log(n))
## Jump Search
    - This aims at reducing the Search limit by Jumping to a predefined block where the value can exist
    - Create two pointers start and end
    - Start with 0 for init start and Find an step say Sqrt(n) , if arr[step]  > search value, increase Step Count, else return -1
    - Search between start and End (start + step)
    - The ideal Jump step is taken to be sqrt(n) , this is based of minmizing the T(n) = (n/b)  + b-1 (n/b blocks to check and b-1 for searching in a block)
        Checking to minmixe gives n 
## Interpolation Search
## Exponential Search
 