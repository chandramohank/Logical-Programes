class   BinHeap:
    def __init__(self):
        self.heapList = [0]
        self.currentSize = 0
    def percDown(self,i):
         while (i * 2) <= self.currentSize:
             mc=self.minChild(i)
             if self.heapList[i]>self.heapList[mc]:
                  tmp = self.heapList[i]
                  self.heapList[i] = self.heapList[mc]
                  self.heapList[mc] = tmp
             i=mc

    def minChild(self,i):
        if  i*2+1>self.currentSize:
            return i*2
        else:
            if self.heapList[i*2]<self.heapList[i*2+1]:
                return i*2
            else:
                return i*2+1        

    def delMin(self):
        retval = self.heapList[1]
        self.heapList[1] = self.heapList[self.currentSize]
        self.currentSize = self.currentSize - 1
        self.heapList.pop()
        self.percDown(1)
        return retval

    
    def buildHeap(self,alist):
        i = len(alist) // 2
        self.heapList=[0] + alist[:]
        self.currentSize=len(alist)
        while (i > 0):
          self.percDown(i)
          i = i - 1

bh = BinHeap()
bh.buildHeap([9,5,1,2,3])

print(bh.delMin())