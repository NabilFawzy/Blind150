public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length ==1) return strs[0];
        int index=0;
        Array.Sort(strs);
        string str1=  strs[0];
        string str2= strs[strs.Length-1];
        for(int i=0;i<str1.Length;i++){
            if(str1[i] != str2[i]){
                break;
            }
            index++;
        }

        return str1.Substring(0,index);;
    }
}