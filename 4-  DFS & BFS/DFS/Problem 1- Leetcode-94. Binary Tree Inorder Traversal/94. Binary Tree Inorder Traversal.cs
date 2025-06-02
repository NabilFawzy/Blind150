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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> res = new();
        if(root == null) return res;
       
        DFS_InOrder(root,res);
        return res;
    }
     public void DFS_InOrder(TreeNode node,List<int> res){
        if(node.left != null) DFS_InOrder(node.left,res);
        res.Add(node.val);
        if(node.right != null) DFS_InOrder(node.right,res);
    }
}