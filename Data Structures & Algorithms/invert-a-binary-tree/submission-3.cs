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

// Find the structure of a tree
// < 16 would be 4 layers, < 8 would be 3 layers, etc
// given in the correct order
//      1
//    /   \
//   2     3
//  / \   / \
// 4   5 6   7


public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) {
            return root;
        }
        if (root.left != null && root.right != null) 
        {
            Swap(ref root.left, ref root.right);
            root.left = this.InvertTree(root.left); 
            root.right = this.InvertTree(root.right);
        }

        if (root.left != null && root.right == null) {
            root.right = root.left;
            root.left = null;

            root.right = this.InvertTree(root.right);
        } else if (root.left == null && root.right != null) {
            root.left = root.right;
            root.right = null;

            root.left = this.InvertTree(root.left);
        }

        return root;
    }

    void Swap(ref TreeNode foo, ref TreeNode bar) {
        TreeNode tmp = foo;
        foo = bar;
        bar = tmp;
    }

}
