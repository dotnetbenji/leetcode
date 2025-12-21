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
    public bool HasPathSum(TreeNode root, int targetSum) {
        
        Stack<(TreeNode, int)> nodes = new();
        nodes.Push((root, 0));
        do
        {
            (TreeNode, int) next = nodes.Pop();
            TreeNode nextNode = next.Item1;

            if(nextNode == null)
                continue;

            int total = next.Item2 + nextNode.val;

            if(nextNode.left == null && nextNode.right == null && total == targetSum)
                return true;

            nodes.Push((nextNode.left, total));
            nodes.Push((nextNode.right, total));
        } while (nodes.Count > 0);

        return false;
    }
}