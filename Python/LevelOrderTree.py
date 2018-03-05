class  Node:
    def __init__(self,data):
        self.data=data
        self.left=None
        self.right=None

def levelOrder(root,nodes):
    queue=[root]

    while queue:
        n=queue.pop(0)
        nodes.append(n.data)
        if n.left:
            queue.append(n.left)
        elif n.right:
            queue.append(n.right)
    return nodes

# Function to  print level order traversal of tree
def printLevelOrder(root):
    h = height(root)
    for i in range(1, h+1):
        printGivenLevel(root, i)
 
 
# Print nodes at a given level
def printGivenLevel(root , level):
    if root is None:
        return
    if level == 1:
        print( "%d" %(root.data))
    elif level > 1 :
        printGivenLevel(root.left , level-1)
        printGivenLevel(root.right , level-1)
 
 
""" Compute the height of a tree--the number of nodes
    along the longest path from the root node down to
    the farthest leaf node
"""
def height(node):
    if node is None:
        return 0
    else :
        # Compute the height of each subtree 
        lheight = height(node.left)
        rheight = height(node.right)
 
        #Use the larger one
        if lheight > rheight :
            return lheight+1
        else:
            return rheight+1

# right tree
root_r = Node(26)
n1_r = Node(10)
n2_r = Node(3)
n3_r = Node(4)
n4_r = Node(6)
n5_r = Node(3)
n6_r = Node(30)

# setup children
n3_r.right = n6_r
n1_r.left = n3_r
n1_r.right = n4_r
n2_r.right = n5_r
root_r.left = n1_r
root_r.right = n2_r

nodes = printLevelOrder(root_r)
print(nodes)

