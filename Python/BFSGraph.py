from collections import defaultdict
class BFSGraph:
    def __init__(self):
        self.graph=defaultdict(list)
    
    def addEdge(self,u,v):
        self.graph[u].append(v)
    
    def BFS(self,s):
        visited = [False] * (len(self.graph))
        queue=[]
        queue.append(s)
        visited[s] = True
        while queue:                 
            # Dequeue a vertex from queue and print it
            s = queue.pop(0)
            print(s)
            # Get all adjacent vertices of the dequeued
            # vertex s. If a adjacent has not been visited,
            # then mark it visited and enqueue it
            for i in self.graph[s]:
                if visited[i] == False:
                    queue.append(i)
                    visited[i] = True
    def dfs_iterative(self, start):
        stack, path = [start], []
        while stack:
            vertex = stack.pop()
            if vertex in path:
                continue
            path.append(vertex)
            print(vertex)
            for neighbor in self.graph[vertex]:
                stack.append(neighbor)
        return   path
    # A function used by DFS
    def DFSUtil(self,v,visited):
 
        # Mark the current node as visited and print it
        visited[v]= True
        print(v)
 
        # Recur for all the vertices adjacent to this vertex
        for i in self.graph[v]:
            if visited[i] == False:
                self.DFSUtil(i, visited)  

    def DFS(self):
        
        V = len(self.graph)  #total vertices
 
        # Mark all the vertices as not visited
        visited =[False]*(V)
 
        # Call the recursive helper function to print
        # DFS traversal starting from all vertices one
        # by one
        for i in range(V):
            if visited[i] == False:
                self.DFSUtil(i, visited)  
# Driver code
# Create a graph given in the above diagram
g = BFSGraph()
g.addEdge(0, 1)
g.addEdge(0, 2)
g.addEdge(1, 2)
g.addEdge(2, 0)
g.addEdge(2, 3)
g.addEdge(3, 3)

 
#print "Following is Breadth First Traversal (starting from vertex 2)"
#g.BFS(2)
#g.dfs_iterative(0)
g.DFS()