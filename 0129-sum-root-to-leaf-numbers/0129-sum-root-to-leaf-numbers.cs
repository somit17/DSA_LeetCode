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
    public int SumNumbers(TreeNode root) {
        if(root==null) return 0;
        return DFSTraversal(root,"0");
    }
    public int DFSTraversal(TreeNode root,string currentPath){
        currentPath+=root.val.ToString();
        if (root.left == null && root.right == null) {
            return int.Parse(currentPath);
        }
        int sum = 0;
        if (root.left != null) {
            sum += DFSTraversal(root.left, currentPath);
        }
        if (root.right != null) {
            sum += DFSTraversal(root.right, currentPath);
        }
        return sum;
    }
}