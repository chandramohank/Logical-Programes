
class Node:
    def __init__(self,data,next):
        self.data=data
        self.next=next

if __name__=='__main__':
    first=Node(1,None)
    second=Node(2,first)
    third=Node(3,second)
    fourth=Node(4,third)
    fifth=Node(5,fourth)
    sixth=Node(6,fifth)
    seven=Node(7,sixth)
    head=seven


    fastpointer=head
    slowpointer=head
    while fastpointer.next!=None and fastpointer.next.next!=None:
        slowpointer=slowpointer.next
        fastpointer=fastpointer.next.next

    print(slowpointer.data)
