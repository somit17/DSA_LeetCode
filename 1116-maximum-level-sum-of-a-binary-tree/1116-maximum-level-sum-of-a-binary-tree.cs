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
    public int MaxLevelSum(TreeNode root) {
        if(root==null) return 0;
        return BFSTraversal(root);
    }
    public int BFSTraversal(TreeNode root){
        Dictionary<int,int> hash = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int level=1;
        while(queue.Count>0){
            int lc = queue.Count;
            int sum=0;
            for(int i=0;i<lc;i++){
                var currentNode = queue.Dequeue();
                sum+=currentNode.val;
                if(currentNode.left!=null)
                    queue.Enqueue(currentNode.left);
                if(currentNode.right!=null)
                    queue.Enqueue(currentNode.right);
            }
            hash[level]=sum;level++;
            Console.WriteLine(level+"->"+sum);
        }
        return hash.OrderByDescending(x=>x.Value).FirstOrDefault().Key;
    }


}
