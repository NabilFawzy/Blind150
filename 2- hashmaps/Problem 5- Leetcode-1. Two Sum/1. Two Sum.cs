public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] arr = new int[2];
        Dictionary<int,int> map = new();
        for(int i=0;i< nums.Length;i++){
            if(map.ContainsKey(target - nums[i])){
                arr= new int[] {map[target - nums[i]] , i};
            }
            else{
                map[nums[i]] = i;
            }
        }

        return arr ;
    }
}