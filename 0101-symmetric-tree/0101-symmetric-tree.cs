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
    public bool IsSymmetric(TreeNode root) {
        return IsSymmetricHelper(root.left,root.right);
    }
    public bool IsSymmetricHelper(TreeNode left,TreeNode right){
        if(left==null && right==null)
            return true;
        if(left==null||right==null)
            return false;
        return left.val==right.val && IsSymmetricHelper(left.left,right.right) && IsSymmetricHelper(left.right,right.left);
    }
    
}