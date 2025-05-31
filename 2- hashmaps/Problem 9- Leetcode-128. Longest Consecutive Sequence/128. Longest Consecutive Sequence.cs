public class Solution {
    public int LongestConsecutive(int[] nums) {
             if(nums == null || nums.Length == 0){
            return 0;
        }
        int len = nums.Length;
        HashSet<int> numSet = new HashSet<int>(nums);

        int max=0;
        foreach(var x in numSet){
            if(!numSet.Contains(x-1)){
                int sequence=1;
                while(numSet.Contains(x+sequence)){
                    sequence++;
                }
               max=Math.Max(max,sequence);
            }
        }

        return max;

    }
}