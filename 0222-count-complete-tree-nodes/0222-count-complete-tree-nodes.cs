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
    int totalNodes = 0;
    public int CountNodes(TreeNode root) {
        if(root==null) return 0;
        DFSTraversal(root);
        return totalNodes;
    }
    public void DFSTraversal(TreeNode root){
        if(root==null) return;
        totalNodes++;
        if(root.left!=null){
            DFSTraversal(root.left);
        }
        if(root.right!=null){
            DFSTraversal(root.right);
        }
    }
}