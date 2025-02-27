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
    List<IList<int>> result;
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        result = new();
        if(root==null) return result;
        BFSTraversal(root);
        return result;
    }
    public void BFSTraversal(TreeNode root){
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level=1;
        while(queue.Count > 0){
            int lc = queue.Count;
            List<int> temp = new();
            for(int i=0;i<lc;i++){
                var currentNode = queue.Dequeue();
                temp.Add(currentNode.val);
                if(currentNode.left != null){
                    queue.Enqueue(currentNode.left);
                }
                if(currentNode.right != null){
                    queue.Enqueue(currentNode.right);
                }
            }
            if (level % 2 == 0) {
                // Reverse the list for even levels
                temp.Reverse();
            }
            result.Add(new List<int>(temp));

            level++; // Move to the next level            
        }
    }
}