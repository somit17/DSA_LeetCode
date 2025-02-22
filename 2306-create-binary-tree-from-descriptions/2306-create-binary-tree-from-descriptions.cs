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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        Dictionary<int,TreeNode> map = new();
        HashSet<int> childSet=new();

        foreach(var data in descriptions){
            int parent = data[0];
            int child = data[1];
            int isLeft = data[2];

            if(!map.ContainsKey(parent)){
                map[parent]=new TreeNode(parent);
            }
            if(!map.ContainsKey(child)){
                map[child]=new TreeNode(child);
            }

            if(isLeft==1){
                map[parent].left = map[child];
            }else{
                map[parent].right = map[child];
            }
            if(!childSet.Contains(child)){
                childSet.Add(child);
            }
        }
        //Find root parent;
        foreach(var data in descriptions){
            int parent = data[0];
            if(!childSet.Contains(parent))
                return map[parent];
        }
        return null;
    }
}