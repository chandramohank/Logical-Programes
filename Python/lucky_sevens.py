
def luckysevens(arr,s):
    i=0
    while i<len(arr)-2:
        if arr[i]+arr[i+1]+arr[i+2] == s:
            return True
        else:
            i=i+1
    return False

print(luckysevens([0,-2,1,8],7))

