/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null) return null;
        if(root==p || root==q){
            return root;
        }

        //Left Side
        TreeNode leftSide = LowestCommonAncestor(root.left,p,q);
        TreeNode rightSide = LowestCommonAncestor(root.right,p,q);

        if(leftSide!=null && rightSide!=null)
            return root;
        if(leftSide!=null)
            return leftSide;
        return rightSide;
    }
}