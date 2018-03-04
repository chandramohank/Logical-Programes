#InOrder [D,B,E,A,C]
#PostOrder [D,E,B,C,A]

class Node(object):
    """docstring for ."""
    def __init__(self, data):
        self.data=data
        self.left=None
        self.right=None

def buildTree(inOrder,postOrder,start,end):
    if start>end:
        return
    node=Node(postOrder[buildTree.postIndex])
    buildTree.postIndex-=1
    if start==end:
        return node
    inIndex=search(inOrder,start,end,node.data)
    
    node.right=buildTree(inOrder,postOrder,inIndex+1,end)
    node.left=buildTree(inOrder,postOrder,start,inIndex-1)
    return node
def search(inOrder,start,end,data):
    for i in range(start,end+1):
        if  inOrder[i]==data:
            return i
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
buildTree.postIndex=len(postOrder)-1
finalnode=buildTree(inOrder,postOrder,0,len(postOrder)-1)
printInorder(finalnode)
