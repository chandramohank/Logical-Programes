class Node:
    def __init__(self,data,next):
        self.data=data
        self.next=next
def findnth(head,n):
    counter=1
    if counter==n:
        return head.data
    else:
        return findnth(head.next,n-1)


first=Node(1,None)
second=Node(2,first)
third=Node(3,second)
fourth=Node(4,third)
fifth=Node(5,fourth)
sixth=Node(6,fifth)
seven=Node(7,sixth)

print(findnth(seven,3))
