public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
     int count = 0;
        Dictionary<int, List<int>> adjList = new();
        int[] indegree = new int[numCourses];
        System.Array.Fill(indegree, 0);

        // Initialize adjacency list and indegree array
        for (int i = 0; i < numCourses; i++)
        {
            adjList[i] = new List<int>();
        }

        // Build the graph
        foreach (var prereq in prerequisites)
        {
            int src = prereq[1], dest = prereq[0];
            adjList[src].Add(dest);
            indegree[dest]++;
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < indegree.Length; i++)
            if (indegree[i] == 0)
            {
                queue.Enqueue(i);
                count++;
            }

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            foreach (var v in adjList[currentNode])
            {
                indegree[v]--;
                if (indegree[v] == 0)
                {
                    count++;
                    queue.Enqueue(v);
                }
            }
        }

        if (count == numCourses) return true;
        return false;
    }

    public bool IsCycle(Dictionary<int, List<int>> adjList, bool[] visited, bool[] inRecurrsion, int u)
    {
        visited[u] = true;
        inRecurrsion[u] = true;
        foreach (var v in adjList[u])
        {
            if (!visited[v] && IsCycle(adjList, visited, inRecurrsion, v))
                return true;
            else if (inRecurrsion[v])
                return true;
        }

        inRecurrsion[u] = false;
        return false;   
    }
}