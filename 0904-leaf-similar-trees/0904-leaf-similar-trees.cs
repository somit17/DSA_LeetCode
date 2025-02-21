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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var ls1 = DFSTraversal(root1);
        var ls2 = DFSTraversal(root2);
        Console.WriteLine(string.Join(",", ls1));
        Console.WriteLine(string.Join(",", ls2));
        return ls1.SequenceEqual(ls2);
    }
    public List<int> BFSTraversal(TreeNode root){
        if(root==null)
            return new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<int> result = new List<int>();
        while(queue.Count > 0){
            int qc = queue.Count;
            for(int i=0;i<qc;i++){
                var currentNode = queue.Dequeue();
                if(currentNode.left==null && currentNode.right==null){
                    result.Add(currentNode.val);
                }
                if(currentNode.left!=null)queue.Enqueue(currentNode.left);
                if(currentNode.right!=null)queue.Enqueue(currentNode.right);
                
            }
        }
        return result;
    }

    public List<int> DFSTraversal(TreeNode root){
        List<int> result = new List<int>();
            void DFS(TreeNode node) {
                if (node == null) return;

                // If the current node is a leaf, add its value to the result
                if (node.left == null && node.right == null) {
                    result.Add(node.val);
                }

                // Recursively traverse the left and right subtrees
                DFS(node.left);
                DFS(node.right);
            }
            // Start DFS from the root
            DFS(root);
            return result;
        }
    }