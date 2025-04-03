public class Solution {
    public void Rotate(int[] nums, int k) {
         k=k%(nums.Length);
         if(k==0)return;

         Array.Reverse(nums,nums.Length-k,k);
         Array.Reverse(nums,0,nums.Length-k);
         Array.Reverse(nums,0,nums.Length);
         
    }
}