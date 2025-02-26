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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if (depth == 1) {
            TreeNode newRoot = new TreeNode(val);
            newRoot.left = root;
            return newRoot;
        }
        return BFSTraversal(root,val,depth);
    }
    public TreeNode BFSTraversal(TreeNode root,int val,int depth){
        if (root == null) return root;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 1;

        while (queue.Count > 0) {
            int levelCount = queue.Count;

            // Process all nodes at the current level
            for (int i = 0; i < levelCount; i++) {
                TreeNode currentNode = queue.Dequeue();

                // Check if we are at the level just before the target depth
                if (level == depth - 1) {
                    // Save the current left and right children
                    TreeNode prevLeft = currentNode.left;
                    TreeNode prevRight = currentNode.right;

                    // Insert new nodes with the given value
                    currentNode.left = new TreeNode(val);
                    currentNode.right = new TreeNode(val);

                    // Attach the previous children to the new nodes
                    currentNode.left.left = prevLeft;
                    currentNode.right.right = prevRight;
                } else {
                    // Add children to the queue for the next level
                    if (currentNode.left != null) queue.Enqueue(currentNode.left);
                    if (currentNode.right != null) queue.Enqueue(currentNode.right);
                }
            }

            // Increment the level after processing all nodes at the current level
            level++;

            // If we have processed the level just before the target depth, exit the loop
            if (level == depth) break;
        }

        return root;
     }
}