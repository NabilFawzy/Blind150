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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> res = new();
        if(root == null) return res;
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        int rowNum=0;
        while(q.Count()>0){
            int qLen= q.Count();
            List<int> level = new();
            for(int i=0;i<qLen;i++){
                var node = q.Dequeue();
                level.Add(node.val);
                
                if(node.left!=null) q.Enqueue(node.left);
                if(node.right!=null) q.Enqueue(node.right);
                
                
            }
              if(rowNum % 2 == 1)
                 level.Reverse();
            res.Add(level);
            rowNum++;
        }
        return res;
    }
}