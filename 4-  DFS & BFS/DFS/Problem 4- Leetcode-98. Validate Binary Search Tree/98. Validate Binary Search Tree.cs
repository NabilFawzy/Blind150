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
    public bool IsValidBST(TreeNode root) {
        if(root == null) return true;
         return Valid(root,long.MinValue,long.MaxValue);
    }
    public bool Valid(TreeNode node, long leftVal, long rightVal){
        if(node == null) return true;
        if(!(node.val > leftVal && node.val < rightVal)) return false;

       return Valid(node.left, leftVal, node.val) && Valid(node.right ,  node.val, rightVal);
    }
    
   
}