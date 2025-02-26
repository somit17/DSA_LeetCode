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
        int lH = getLeftHeight(root);
        int rH = getRightHeight(root);
        if(lH==rH){ //perfect binary Tree
            return Convert.ToInt32(Math.Pow(2,lH)-1);
        }

        //DFSTraversal(root);
        return CountNodes(root.left)+CountNodes(root.right)+1;
    }

    public int getLeftHeight(TreeNode root){
        TreeNode temp = root;
        int lH = 0;
        while(temp!=null){
            temp= temp.left;
            lH++;
        }
        return lH;
    }

    public int getRightHeight(TreeNode root){
        TreeNode temp = root;
        int rH = 0;
        while(temp!=null){
            temp= temp.right;
            rH++;
        }
        return rH;
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