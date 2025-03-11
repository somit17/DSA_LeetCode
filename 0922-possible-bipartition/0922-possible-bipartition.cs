public class Solution {
    public bool PossibleBipartition(int n, int[][] dislikes) {
        //Adj List 
        Dictionary<int,List<int>> adj = new();
        for(int i=1;i<=n;i++){
            adj[i]=new();
        }
        foreach(var data in dislikes){
            int src = data[0],dest =data[1];
            adj[src].Add(dest);
            adj[dest].Add(src);
        }
        int[] color = new int[n+1];
        Array.Fill(color,-1);
        for(int i=1;i<=n;i++){
            if(color[i]==-1){
                if(!BFSBipartite(adj,color,i))
                    return false;
            }
        }
        return true;
    }
    public bool BFSBipartite(Dictionary<int,List<int>> adj,int[] color,int startNode){
        Queue<int> q = new();
        q.Enqueue(startNode);
        color[startNode]=0;
        while(q.Count > 0){
            var node = q.Dequeue();
            foreach(var v in adj[node]){
                if(color[v]==color[node])
                    return false;
                else if(color[v]==-1){
                    color[v]=1-color[node];
                    q.Enqueue(v);
                }
            }
        }
        return true;
    }
}