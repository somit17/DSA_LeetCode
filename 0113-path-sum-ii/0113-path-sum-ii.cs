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
    IList<IList<int>> result;
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        result = new List<IList<int>>();
        if(root==null) return result;
        PathSumHelper(root,targetSum,new List<int>());
        return result;
    }
    void PathSumHelper(TreeNode root,int targetSum,List<int> temp){
        temp.Add(root.val);
        //check if node is leaf node;
        if(root.left == null && root.right == null){
            if(temp.Sum()==targetSum)
                result.Add(new List<int>(temp));
        }
        if(root.left != null) PathSumHelper(root.left,targetSum,new List<int>(temp));
        if(root.right != null) PathSumHelper(root.right,targetSum,new List<int>(temp));
    }
}