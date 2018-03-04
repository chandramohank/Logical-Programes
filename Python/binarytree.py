#InOrder [D,B,E,A,C]
#preOrder[A,B,D,E,C]

class  Node:
    def __init__(self,data):
        self.data=data
        self.left=None
        self.right=None
    
def BuildTree(inOrder,preOrder,inStr,enStr):

    if inStr > enStr:
        return
    node=Node(preOrder[BuildTree.preIndex])

    BuildTree.preIndex+=1

     # If this node has no children then return
    if inStr == enStr :
        return node

    inIndex=search(inOrder,inStr,enStr,node.data)

    node.left=BuildTree(inOrder,preOrder,inStr,inIndex-1)
    node.right=BuildTree(inOrder,preOrder,inIndex+1,enStr)

    return node

def search(inOrder,start,end,data):
    for i in range(start,end+1):
        if  inOrder[i]==data:
            return i
def printInorder(node):
    if node is None:
        return
     
    # first recur on left child
    printInorder(node.left)
     
    #then print the data of node
    print(node.data)
 
    # now recur on right child
    printInorder(node.right)

        
# Driver program to test above function
inOrder = ['D', 'B' ,'E', 'A', 'F', 'C']
preOrder = ['A', 'B', 'D', 'E', 'C', 'F']
# Static variable preIndex
BuildTree.preIndex = 0
root = BuildTree(inOrder, preOrder, 0, len(inOrder)-1)
 
# Let us test the build tree by priting Inorder traversal
print("Inorder traversal of the constructed tree is")
printInorder(root)



