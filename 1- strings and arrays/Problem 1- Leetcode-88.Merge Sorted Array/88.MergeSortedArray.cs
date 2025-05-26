public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int last = m+n -1;
        int l1= m-1;
        int l2= n-1;

        while(l2>=0){
            if(l1>=0  && nums1[l1]> nums2[l2]){
                nums1[last--] = nums1[l1--];
            }
            else{
                nums1[last--] = nums2[l2--];
            }
        }
    }
}