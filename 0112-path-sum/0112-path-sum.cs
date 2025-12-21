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
        
        int? sum = SumRec(root, 0, targetSum);

        return sum != null;
    }

    public int? SumRec(TreeNode node, int curTotal, int target)
    {
        if(node == null)
            return null;

        int newTotal = curTotal + node.val;

        if(node.left == null && node.right == null && newTotal == target)
            return newTotal;
        
        int? right = SumRec(node.right, newTotal, target) == target ? target : null;
        int? left = SumRec(node.left, newTotal, target) == target ? target : null;

        if(right == null)
            return left;

        if(left == null)
            return right;

        return right > left ? right : left;
    }
}