public class Solution {
    // Solution using sorting and get element in half of array
    public int MajorityElement-SortSolution(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        return nums[n/2] ;
    }

    //Using Boyer Moore Algorithm
       public int MajorityElement-BoyerMoreeSolution(int[] nums) {
                int candidate = nums[0];
        int count =0;
        for(int i=0;i<nums.Length;i++){
            if(count == 0 ){
               candidate = nums[i];
            }
            if(nums[i] == candidate ){
                count++;
            }
            else{
                count --;
            }
        }
        return candidate;
    }
}