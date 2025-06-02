public class RecentCounter {
   Queue<int> q;
    public RecentCounter() {
         q = new ();
    }
    
    public int Ping(int t) {
        int val = t- 3000;
        q.Enqueue(t);
        while(q.Peek() < val){
               q.Dequeue();
        }
        return q.Count();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */