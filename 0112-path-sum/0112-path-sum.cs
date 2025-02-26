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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root==null) return false;
        return Fill(root,targetSum,new List<int>());
    }

    bool Fill(TreeNode root,int targetSum,List<int> temp){
        temp.Add(root.val);
        //Check if it is leaf node
        if(root.left == null && root.right == null){
            if(temp.Sum()==targetSum){
                return true;
            }
        }
        if(root.left != null && 
            Fill(root.left,targetSum,new List<int>(temp))){
                return true;
            }
        if(root.right != null && 
            Fill(root.right,targetSum,new List<int>(temp))){
                return true;
            }
        return false;
    }
}