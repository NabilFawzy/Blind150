public class OrderedStream {
    string [] arr;
    int ptr;
    public OrderedStream(int n) {
        arr= new string[n+1];
        ptr=1;
    }
    
    public IList<string> Insert(int idKey, string value) {
        List<string> mList = new();
        arr[idKey] =value;
        for(int i=ptr;i<arr.Length;i++){
            if(arr[i] != null){
                mList.Add(arr[i]);
                ptr++;
            }
            else{
                break;
            }
        }
        return mList;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */