public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int,List<int>> adjList = new();
        for(int i=0;i<numCourses;i++){
            adjList[i]=new();
        }
        int[] indegree= new int[numCourses];
        //Build the graph
        foreach(var data in prerequisites){
            int u=data[1],v=data[0];
            adjList[u].Add(v);
            indegree[v]++;
        }

        
        bool[] visited = new bool[numCourses];
        bool[] inRecursion = new bool[numCourses];

        Array.Fill(visited,false);
        Array.Fill(inRecursion ,false);

        return BFSCycleDetection(adjList,indegree,numCourses);
        for(int i=0;i<numCourses;i++){
            if(!visited[i] && DFSCycleDetection(adjList,visited,inRecursion,i)){
                return false;
            }
        }
        return true;
    }

    public bool DFSCycleDetection(Dictionary<int,List<int>> adjList,bool[] visited,bool[] inRecursion,int u)    {
        visited[u]=true;
        inRecursion[u]=true;
        foreach(var v in adjList[u]){
            if(!visited[v]){
                if(DFSCycleDetection(adjList,visited,inRecursion,v))
                    return true;
            }else if(inRecursion[v]){
                return true; 
            }
        }
        inRecursion[u]=false;
        return false;
    }
    public bool BFSCycleDetection(Dictionary<int,List<int>> adjList,int[] indegree,int numCourses){
        Queue<int> queue = new();
        for(int i=0;i<indegree.Length;i++){
            if(indegree[i]==0)
                queue.Enqueue(i);
        }
        int processedNodes = 0;
        while(queue.Count > 0){
            int node = queue.Dequeue();
            processedNodes++;

            foreach(var v in adjList[node]){
                indegree[v]--;
                if(indegree[v]==0)
                    queue.Enqueue(v);
            }

        }
        // Step 4: Check if all nodes were processed
        return processedNodes == numCourses;
    }
}