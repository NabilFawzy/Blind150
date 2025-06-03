public class KthLargest {
   PriorityQueue<int,int> q;
   int kth;
   int count=0;
    public KthLargest(int k, int[] nums) {
        q = new();
        kth = k;
        foreach(var num in nums){
            q.Enqueue(num,num);
            count++;
        }
        while(count > kth){
            q.Dequeue();
            count--;
        }

    }
    
    public int Add(int val) {
        q.Enqueue(val,val);
        count++;
        while(count> kth){
            q.Dequeue();
            count--;
        }
        return q.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */