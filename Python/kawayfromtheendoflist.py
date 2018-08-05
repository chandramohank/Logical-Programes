def kthFromEnd(head, k):
    
    slow = fast = head

    for i in range(k):
        fast = fast.next
    if not fast:
        return None
    while fast:
        slow = slow.next
        fast = fast.next
    return slow

class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

# Construct 5->;6->;7->;8
head = Node(5)
head.next = Node(6)
head.next.next = Node(7)
head.next.next.next = Node(8)
head.next.next.next.next = Node(9)

print(kthFromEnd(head, 4).data)