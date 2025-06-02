public class Node{
    public int min{get; set;}
    public int val{get;set;}
    public Node next{get; set;}

    public Node(int _val,int _min,Node _next){
        min = _min;
        val = _val;
        next= _next;
    }
}

public class MinStack {
    Node curr;
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(curr == null){
            curr  = new Node(val,val , null);
        }
        else{
            curr = new Node(val,Math.Min(val,curr.min),curr);
        }
    }
    
    public void Pop() {
        curr = curr.next;
    }
    
    public int Top() {
        return curr.val;
    }
    
    public int GetMin() {
        return curr.min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */