public class Solution {
    public int HIndex(int[] citations) {
        int len = citations.Length;
        Array.Sort(citations,0,len);
        for(int i=0;i<len;i++){
            if(len - i <= citations[i]){
                return len-i;
            }
        }
        return 0;
    }
    // [3,0,6,1,5]
    // [0,1,3,5,6] => 3,5,6 three papers with 3 citations
}