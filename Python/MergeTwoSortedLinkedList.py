class Node:
    def __init__(self,data,next):
        self.data=data
        self.next=next

def merge(first,second):
        final=Node(None,None)
        prev=final
        while first!=None and second!=None:
            if first.data<=second.data:
                prev.next=first
                first=first.next
            else:
                prev.next=second
                second=second.next
            prev=prev.next

        if first == None:
  	         prev.next = second
        elif second == None:
  	          prev.next = first

        return final.next

# create first linked list: 1 -> 3 -> 10
n3 = Node(10, None)
n2 = Node(3, n3)
n1 = Node(1, n2)
L1 = n1

# create second linked list: 5 -> 6 -> 9
n6 = Node(9, None)
n5 = Node(6, n6)
n4 = Node(5, n5)
L2 = n4

# print the linked list
merged = merge(L1, L2)
while merged != None:
  print(str(merged.data) + ' -> ')
  merged = merged.next
print('None')
