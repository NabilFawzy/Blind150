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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> res =new ();
        if(root == null)  return res;
        DFS_PostOrderTraversal(root,res);
        return res;
    }
    public void DFS_PostOrderTraversal(TreeNode node,List<int> res){
        if(node.left!= null)  DFS_PostOrderTraversal(node.left, res);
        if(node.right!= null)  DFS_PostOrderTraversal(node.right, res);
        res.Add(node.val);
    }
}