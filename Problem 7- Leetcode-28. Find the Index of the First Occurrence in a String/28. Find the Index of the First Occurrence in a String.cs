public class Solution {
    public int StrStr(string haystack, string needle) {

        if(needle.Length > haystack.Length) return -1;
        if(needle.Length == haystack.Length) return needle==haystack? 0: -1;

        for(int i=0;i<haystack.Length;i++){
            if(i+needle.Length > haystack.Length) return -1;
            string currStr= haystack.Substring(i,needle.Length);
            if(currStr == needle) return i;
        }
        return -1;

    }
}