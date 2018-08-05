
def isBalanced(input):
    isTrue=False
    tempStack=[]
    for i in range(0,len(input)):        
        if  input[i]=="(":
            tempStack.append(input[i])
        else:
            if not tempStack:
                isTrue=False
                return isTrue                                                               
            else:
                tempStack.pop()
                
    return True


print(isBalanced("((()))"))