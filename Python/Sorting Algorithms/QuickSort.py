
def Partition(arr,low,high):
    i = low-1
    pivot=arr[high]
    for j in range(low,high):
        if arr[j]<=pivot:
            i=i+1
            arr[j],arr[i]=arr[i],arr[j]
    arr[i+1],arr[high] = arr[high],arr[i+1]
    return i+1


def quicksort(arr,low,high):

    if low<high:
        pi=Partition(arr,low,high)
        quicksort(arr,low,pi-1)
        quicksort(arr,pi+1,high)
    

arr = [10, 7, 8, 9, 1, 5]
n = len(arr)
quicksort(arr,0,n-1)
for i in range(n):
    print ("%d" %arr[i])