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
    public int MaxDepth(TreeNode root) {
        
        int depthLeft = 0;
        int depthRight = 0;
        int max = 1;
        if (root == null) {
            return 0;

        }

        if (root.left == null && root.right == null) {
            return max;
        }

        if (root.left != null) {
            depthLeft += MaxDepth(root.left);
        }

        if (root.right != null) {
            depthRight += MaxDepth(root.right);
             
        }
        
        if (depthLeft > depthRight) {
            max = depthLeft;
        } else {
            max = depthRight;
        }
        max++;
    
        return max;
    }
}
