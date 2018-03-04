
def twosum(array,s):
    sums=[]
    for i in range(0,len(array)):
        for j in range(i+1, len(array)):
            if array[i]+array[j]==s:
                sums.append([array[i],array[j]])

    return sums

def twosumusinghashtable(array,s):
    sums=[]
    hashTable={}
    for i in range(0,len(array)):
        minuselement=s-array[i]
        if minuselement in hashTable:
            sums.append([array[i],minuselement])
        hashTable[array[i]]=array[i]
    return sums




print(twosum([3, 5, 2, -4, 8, 11], 7))
print(twosumusinghashtable([3,3,3,4,5, 5, 2, -4, 8, 11], 7))
