class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
class LinkedList:
        def __init__(self):
            self.head=None
        def push(self,newData):
            newNode=Node(newData)
            newNode.next=self.head
            self.head=newNode
        def insertafter(self,prevNode,newData):
            newNode=Node(newData)
            newNode.next=prevNode.next
            prevNode.next=newNode
        def append(self,newData):
            newNode=Node(newData)
            if self.head is None:
                self.head = newNode
                return
            last=self.head
            while last.next:
                last=last.next
            last.next=newNode
if __name__=='__main__':
    llist=LinkedList()
    llist.head=Node(1)
    second=Node(2)
    third=Node(3)

    llist.head.next=second
    second.next=third

    llist.append(4)
    llist.push(0)
    llist.insertafter(llist.head.next,8)

    temp=llist.head
    while temp:
        print(temp.data)
        temp=temp.next
