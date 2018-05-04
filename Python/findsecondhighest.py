
def findSecondHighest(arr):
    first,second=0,0
    for i in range(0,len(arr)):
        if arr[i]>first:
            second=first
            first=arr[i]
        elif arr[i]>second and arr[i]!=first:
            second=arr[i]
    return second

findSecondHighest([10,3,7,15])