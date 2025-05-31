public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();
        foreach(var str in strs){
            char[] charArr= str.ToCharArray();
            Array.Sort(charArr);
            string sortedStr = new string (charArr);
            if(map.ContainsKey(sortedStr)){
                map[sortedStr].Add(str);
            }
            else{
                map[sortedStr] = new List<string>{str};
            }

            
        }
         var res=new List<IList<string>>();
        foreach(var item in map){
            res.Add(item.Value);
        }
        return res;
    }
}