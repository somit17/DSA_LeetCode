/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        IList<int> result = new List<int>();
        if(root==null) return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level=0;
        Dictionary<int,int> dic = new();
        while(queue.Count>0){
            int queueC = queue.Count;
            for(int i=0;i<queueC;i++){
                var currentNode=queue.Dequeue();
                dic[level]=currentNode.val;
                if(currentNode.left!=null){
                    queue.Enqueue(currentNode.left);
                }
                if(currentNode.right!=null){
                    queue.Enqueue(currentNode.right);
                }
            }
            level++;
        }
        foreach(var data in dic){
            result.Add(data.Value);
        }
        return result;
    }

}