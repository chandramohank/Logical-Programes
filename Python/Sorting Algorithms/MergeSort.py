
def MergeSort(left,right):
    sortedArray=[]
    i,j=0,0
    while i < len(left) and j <len(right):
        if left[i]<right[j]:
            sortedArray.append(left[i])
            i=i+1
        else:
            sortedArray.append(right[j])
            j=j+1
    
    while i < len(left):
        sortedArray.append(left[i])
        i=i+1
    while j < len(right):
        sortedArray.append(right[j])
        j=j+1
    return sortedArray

print(MergeSort([5,6,7,10],[1,3,11,13]))