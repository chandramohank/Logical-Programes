adj=[]
def CreatAdjacentTree(V,G):
    for i in range(0,v):
        for j in range(0,v):
            adj[i][j]=0    

    for g in range(0,len(G)):
        adj[G[g][0]][G[g][1]]=G[g][2]
        adj[G[g][1]][G[g][0]]=G[g][2]
    return adj;

def prims(V,G):
    adj=CreatAdjacentTree(V,G)

    Vertex=0;
    MST=[[]]
    minedge=[None,None,float(inf)]
    edges=[]
    visited=[]
    #form edges

    while len(MST)!=v-1:

        visited.append(Vertex)
        for r in range(0,V):
           if adj[Vertex,r]!=0:
               edges.append([Vertex,r,adj[Vertex][r]])
        
        for e in edges:
            if  edges[e][2]<minedge and edges[e][1] not in visited;
                minedge=e