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
    public IList<double> AverageOfLevels(TreeNode root) {
        List<double> res = new();
        Queue<TreeNode> q = new();

        if(root == null) return res;

        q.Enqueue(root);
        while(q.Count()>0){
            int qLen = q.Count();
            double avgLevel = 0;
            for(int i=0;i<qLen;i++){
                var node = q.Dequeue();
                avgLevel+=node.val;
                if(node.left !=null) q.Enqueue(node.left);
                if(node.right !=null) q.Enqueue(node.right);
            }
            res.Add(avgLevel/qLen);
        }

        return res;
    }

    
}