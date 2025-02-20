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
    IList<int> result;
    public IList<int> InorderTraversal(TreeNode root) {
        result=new List<int>();
        InorderTraversalIteratively(root);
        return result;
    }
    public void InorderRecursively(TreeNode root){
        if(root!=null){
            InorderRecursively(root.left);
            result.Add(root.val);
            InorderRecursively(root.right);
        }
    }

    public void InorderTraversalIteratively(TreeNode root){
        if (root == null) return;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        while(current!=null || stack.Count != 0){
            while(current!=null){
                stack.Push(current);
                current=current.left;
            }
            current= stack.Pop();
            result.Add(current.val);
            current=current.right;
        }
    }


}