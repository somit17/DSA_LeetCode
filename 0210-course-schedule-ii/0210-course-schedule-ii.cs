public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        //Build adjList
        Dictionary<int,List<int>> adjList = new();
        int n = prerequisites.Length;
        for(int i=0;i<numCourses;i++){
            adjList[i]=new();
        }
        //
        int[] indegree = new int[numCourses];
        foreach(var data in prerequisites){
            int s = data[1],d=data[0];
            adjList[s].Add(d);
            indegree[d]++;
        }
        return BFSCycleDetectionUsingKahnsAlgo(adjList,indegree,numCourses);
    }

    public int[] BFSCycleDetectionUsingKahnsAlgo(Dictionary<int,List<int>> adjList,int[] indegree,int numCourses){
        List<int> result = new();
        Queue<int> queue = new();
        for(int i=0;i<numCourses;i++)
        { 
            if(indegree[i]==0){
                queue.Enqueue(i);
                result.Add(i);
            }
        }   
            
        int processedNodes= 0 ;    
        while(queue.Count>0){
            int node = queue.Dequeue();
            processedNodes++;
            foreach(var v in adjList[node]){
                indegree[v]--;
                if(indegree[v]==0)
                {
                    queue.Enqueue(v);
                    result.Add(v);
                }    
            }
        }
        if(processedNodes==numCourses)
            return result.ToArray();
        return new int[0];
        }
}