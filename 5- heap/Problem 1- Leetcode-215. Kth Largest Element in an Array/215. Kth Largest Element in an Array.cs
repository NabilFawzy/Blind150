public class Solution {
    PriorityQueue<int,int> q = new();
    int count=0;
    public int FindKthLargest(int[] nums, int k) {
        foreach(var num in nums){
            q.Enqueue(num,num);
            count++;
        }
        while(count>k){
            q.Dequeue();
            count--;
        }
        return q.Peek();
    }
}