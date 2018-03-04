import math

def powerset(array):
    powers=[]
    total=int(math.pow(2,len(array)))
    for i in range(0,total):
        temp=[]
        num="{0:b}".format(i)
        while len(num)<len(array):
            num='0'+num
        for j in range(0,len(num)):
            if num[j]=='1':
                temp.append(array[j])
        powers.append(temp)
    return powers

print(powerset([3,4,5,6]))
