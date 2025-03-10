public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        //Create adj List
        Dictionary<int,List<int>> adj = new();
        for(int i=0;i<n;i++){
            adj[i]=new();
        }
        foreach(var data in edges){
            int u = data[0],v=data[1];
            adj[u].Add(v);
            adj[v].Add(u);
        }
        bool[] visited = new bool[n];
        Array.Fill(visited,false);
        return BFS(adj,source,visited,destination);

    }

    public bool DFS(Dictionary<int,List<int>> adj,int source ,bool[] visited,int destination){
        if(source==destination) return true;
        if(visited[source]) return false;
        visited[source]=true;

        foreach(var v in adj[source]){
            if(DFS(adj,v,visited,destination))
                return true;
        }
        return false;
    }

    public bool BFS(Dictionary<int,List<int>> adj,int source ,bool[] visited,int destination){
        Queue<int> queue = new();
        queue.Enqueue(source);
        visited[source]=true;
        while(queue.Count > 0){
            var current = queue.Dequeue();
            if(current==destination) return true;
            foreach(var v in adj[current]){
                if(!visited[v]){
                    queue.Enqueue(v);
                    visited[v]=true;
                }
            }
        }
        return false;
    }
}