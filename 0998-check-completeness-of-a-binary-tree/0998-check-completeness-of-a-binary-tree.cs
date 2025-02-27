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
    public bool IsCompleteTree(TreeNode root) {
        if(root==null) return true;
        return BFSTraversal(root);
    }

    public bool BFSTraversal(TreeNode root){
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        bool hasNullChild=false;
        while(queue.Count>0){
            int lc = queue.Count;
            for(int i=0;i<lc;i++){
                var currentNode = queue.Dequeue();
                if(currentNode.left!=null){
                    if(hasNullChild) return false;
                    queue.Enqueue(currentNode.left);
                }else{
                    hasNullChild=true;
                }
                if(currentNode.right!=null){
                    if(hasNullChild) return false;
                    queue.Enqueue(currentNode.right);
                }else{
                    hasNullChild=true;
                }
            }
        }
        return true;
    }
}