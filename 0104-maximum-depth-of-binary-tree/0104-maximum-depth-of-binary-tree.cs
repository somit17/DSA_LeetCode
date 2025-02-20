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
    public int MaxDepth(TreeNode root) {
        if(root == null)
        return 0;

    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    int depth = 0;

    while(queue.Count > 0){
        int queueCount = queue.Count;
        for(int i = 0; i < queueCount; i++){
            var currentNode = queue.Dequeue();
            if(currentNode.left != null)
                queue.Enqueue(currentNode.left);
            if(currentNode.right != null)
                queue.Enqueue(currentNode.right);
        }
        depth++;
    }
    return depth;
    }
}