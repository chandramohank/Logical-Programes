def treeheight(root):
    node=[root]
    if node = None:
        return 0
    print(node.data)

    lheight =  treeheight(node.left)
    rheight = treeheight(node.right)

    if  lheight>rheight
       return lheight+1
    else:
       return rheight+1


