public class Solution {
    public bool IsBipartite(int[][] graph) {
        //Make adj Lisrt
        Dictionary<int,List<int>> adj = new();
        int n = graph.Length;
        for(int i=0;i<n;i++){
            adj[i]=new();
        }
        for (int i = 0; i < n; i++) {
            foreach (int neighbor in graph[i]) {
                adj[i].Add(neighbor);
            }
        }
        int[] color = new int[n];
        Array.Fill(color,-1);
        for(int i=0;i<n;i++){
            if(color[i]==-1)
                if(!BFSBipartitieGraph(adj,i,color)) //DFSBipartitieGraph
                    return false;
        }
        return true;
    }
    public bool DFSBipartitieGraph(Dictionary<int,List<int>> adj,int node,int[] color,int currentColor){
        color[node]=currentColor;
        foreach(var v in adj[node]){
            if(color[v]==color[node]){
                return false;
            }
            if(color[v]==-1)
                if(!DFSBipartitieGraph(adj,v,color,1-currentColor))
                    return false;
        }
        return true;
    }
    public bool BFSBipartitieGraph(Dictionary<int,List<int>> adj,int node,int[] color){
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(node);
        color[node]=1;
        while(queue.Count > 0){
            var u = queue.Dequeue();
            foreach(var v in adj[u]){
                if(color[v]==color[u])
                    return false;
                else if(color[v]==-1){
                    color[v]=1-color[u];
                    queue.Enqueue(v);
                }
            }
        }
        return true;
    }

}