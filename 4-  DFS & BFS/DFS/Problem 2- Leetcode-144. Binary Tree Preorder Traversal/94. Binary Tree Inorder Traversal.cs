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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> res = new();
        if(root == null) return res;
        DFS_PreOrder(root,res);
        return res;
    }
    public void DFS_PreOrder(TreeNode node, List<int> res){
         res.Add(node.val);
         if( node.left != null) DFS_PreOrder(node.left,res);
         if( node.right != null) DFS_PreOrder(node.right,res);
    }
}