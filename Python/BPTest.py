print()
arr=[]

def parenthesis(left,right,str):

    if  left==0 and right==0:
        arr.append(str)
    
    if left>0:
        parenthesis(left-1,right+1,str+"(")
    if right>0:
        parenthesis(left,right-1,str+")")

parenthesis(3, 0, "")
print(arr)