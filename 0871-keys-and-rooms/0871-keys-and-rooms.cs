public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        //Build adjList 
        int n = rooms.Count;
        Dictionary<int,List<int>> adj = new();
        for(int i=0;i<n;i++){
            adj[i]=new List<int>(rooms[i]);
        }
        bool[] visited = new bool[n];
        DFS(adj,visited,0);
        foreach(var status in visited){
            if(!status)
                return false;
        }
        return true;
    }

    public void DFS(Dictionary<int,List<int>> adj,bool[] visited,int u){
        visited[u]=true;
        foreach(var v in adj[u]){
            if(!visited[v])
                DFS(adj,visited,v);
        }
    }
}