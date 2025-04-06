public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k=1;
        for(int i=1;i<nums.Length;i++){
            if(nums[i] != nums[i-1]){
                nums[k++] = nums[i];
            }
            else if( k == 1){
                 nums[k++] = nums[i];
            }
             else if (k - 1 >= 1 && nums[k - 2] != nums[i]) {
                nums[k++] = nums[i];
            }
               
            }
     return k;
        
       
    }
}