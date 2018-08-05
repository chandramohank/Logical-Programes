#1.  Binary tree traversal
#Inorder [DBEAC]
#Preorder [ABDEC]

#st1: visit the root node print
#st2: if left node exists
#       visit the left node print
#     else if right exists
#       visit the right node print
#st3: repeat st2 untill all nodes visited
class  Node:
    def __init__(self,data):
        self.data=data
        self.left=None
        self.right=None

def BuildTree(inorder,postorder,start ,end):    
    if  start>end:
        return
    root = Node(postorder[BuildTree.postOrderIndex])
    
    #print(inorder[rootindex])
    BuildTree.postOrderIndex=BuildTree.postOrderIndex-1    
    if  start==end:
        return root
    rootindex=search(inorder,start,end,root.data);
    root.right = BuildTree(inorder,postorder,rootindex+1,end)
    root.left = BuildTree(inorder,postorder,start,rootindex-1)
    return root

def BuildTreeUsingPreOrder(inorder,preOrder,start ,end):    
    if  start>end:
        return
    root = Node(preOrder[BuildTree.postOrderIndex])
    
    #print(inorder[rootindex])
    BuildTree.postOrderIndex=BuildTree.postOrderIndex+1    
    if  start==end:
        return root
    rootindex=search(inorder,start,end,root.data);
    root.left = BuildTreeUsingPreOrder(inorder,preOrder,start,rootindex-1)
    root.right = BuildTreeUsingPreOrder(inorder,preOrder,rootindex+1,end)
    return root
def search(inOrder,start,end,data):
    for i in range(start,end+1):
        if  inOrder[i]==data:
            return i
    
def printpreorder(node):
    if  node is None:
        return
    print(node.data)
    printpreorder(node.left)
    printpreorder(node.right)

inOrder=[8, 4, 2, 5, 1, 6, 3, 7]
postOrder = [8, 4, 5, 2, 6, 7, 3, 1]
preOrder=[1,2,4,8,5,3,6,7]

start=0
end=len(inOrder)-1
#BuildTree.postOrderIndex =len(postOrder)-1
#finalNode = BuildTree(inOrder,postOrder,start,end)
#printpreorder(finalNode)
BuildTree.postOrderIndex =0
finalNode = BuildTreeUsingPreOrder(inOrder,preOrder,start,end)
printpreorder(finalNode)




