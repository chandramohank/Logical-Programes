from datetime import datetime


class memoize:
    def __init__(self,f):
        self.f=f
        self.memo={}
    def __call__(self,args):
        if not args in self.memo:
            self.memo[args]=self.f(args)
        return self.memo[args]

def factorialwithoutrecursion(n):
    res=n
    while  n>1:
        res=res*(n-1)
        n=n-1
    return res


print( factorialwithoutrecursion(4))

strttime =datetime.now().time()
print(datetime.now().time())
def Factorial(n):
    if n < 2: return 1
    return n*Factorial(n-1)
    
res=memoize(Factorial)
res1=res(3)
print(res1)
print(datetime.now().time().microsecond-strttime.microsecond)