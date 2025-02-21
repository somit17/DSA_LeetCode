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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int n = preorder.Length;
        int idx = 0;
        return Solve(preorder,inorder,0,n-1,ref idx);
    }

    public TreeNode Solve(int[] preorder, int[] inorder,int start,int end,ref int idx){
        if(start>end){
            return null;
        }
        int rootVal = preorder[idx];
        int i=start;
        for(;i<=end;i++){
            if(rootVal==inorder[i])
                break;
        }
        idx++;
        TreeNode root = new TreeNode(rootVal);
        root.left = Solve(preorder,inorder,start,i-1,ref idx);
        root.right = Solve(preorder,inorder,i+1,end,ref idx);
        return root;
    }
}