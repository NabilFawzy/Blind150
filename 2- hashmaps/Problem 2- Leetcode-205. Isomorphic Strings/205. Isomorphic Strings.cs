public class Solution {
    public bool IsIsomorphic(string s, string t) {

       Dictionary<char,char> map = new ();
       for(int i=0;i<s.Length;i++){
          if(map.ContainsKey(s[i])){
             if(map[s[i]] != t[i]){
                return false;
             }
          }
          else{
             if(map.ContainsValue(t[i])){
                return false;
             }
              map[s[i]] = t[i];
          }
     

         
       }
        return true;
    }
}