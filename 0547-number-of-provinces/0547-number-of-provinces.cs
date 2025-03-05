public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int V = isConnected.Length;
        bool[] visited = new bool[V];
        int count =0;

        for(int i=0;i<V;i++){
            if(!visited[i]){
                DFS(isConnected,visited,i);
                count++;
            }
        }
        return count;
    }
    public void DFS(int[][] isConnected,bool[] visited,int u){
        visited[u]=true;
        for(int v=0;v<isConnected.Length;v++){
            if(!visited[v] && isConnected[u][v]==1)
                DFS(isConnected,visited,v);
        }
    }
}