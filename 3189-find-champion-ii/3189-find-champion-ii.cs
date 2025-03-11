public class Solution {
    public int FindChampion(int n, int[][] edges) {
        //Build adjList
        Dictionary<int,List<int>> adj = new();
        int[] indegree = new int[n];
        Array.Fill(indegree,0);
        for(int i=0;i<n;i++){
            adj[i]=new();
        }
        foreach(var data in edges){
            int src = data[0],dest = data[1];
            adj[src].Add(dest);
            indegree[dest]++;
        }
        int count=0,index=0;
        for(int i=0;i<n;i++){
            if(indegree[i]==0){
                count++;
                index=i;
            }
        }
        return count>1?-1:index;
    }
}