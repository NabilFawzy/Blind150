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
    public IList<IList<int>> LevelOrder(TreeNode root) {
    
        List<IList<int>> res = new();
        Queue<TreeNode> q = new();
       
        if (root == null) return res;
        
        q.Enqueue(root);
        while(q.Count()>0){
            int qLen = q.Count();
            List<int> levels = new ();
            for(int i=0;i< qLen;i++){
                var node = q.Dequeue();
                levels.Add(node.val);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            if(levels.Count != 0)
            res.Add(levels);
        }

        return res;
    }
}