class Node(object):
    """docstring for ."""
    def __init__(self, data):
        self.data=data
        self.left=None
        self.right=None

def buildTree(inorder, postorder):
    if inorder:
        ind = inorder.index(postorder.pop())
        root = Node(inorder[ind])
        root.right = buildTree(inorder[ind+1:], postorder)
        root.left = buildTree(inorder[:ind], postorder)
        return root
def printInorder(node):
    if node is None:
        return     
    print(node.data)
    # first recur on left child
    printInorder(node.left)
    #then print the data of node
    
    # now recur on right child
    printInorder(node.right)

inOrder=[4, 8, 2, 5, 1, 6, 3, 7]
postOrder = [8, 4, 5, 2, 6, 7, 3, 1]

pNode = buildTree(inOrder,postOrder)
printInorder(pNode)


