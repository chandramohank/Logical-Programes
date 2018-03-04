
def primes(limit):
    bools=[]
    primes=[]

    for i in range(1,limit):
        bools.append(True)

    for i in range(2,limit):
        if bools[i-2]:
            for j in range(i*2,limit+1,i):
                bools[j-2]=False

    for i in range(0,len(bools)):
        if bools[i]==True:
            primes.append(i+2)

    return primes


print(primes(20))
