public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int LenA = ransomNote.Length;
        int LenB = magazine.Length;

        if(LenA>LenB)return false;
        int[] arr = new int[26];
        for(int i=0;i<ransomNote.Length;i++){
            arr[ransomNote[i] - 'a']++;
        }
        for(int i=0;i<magazine.Length;i++){
            arr[magazine[i] - 'a']--;
        }
         foreach(var c in ransomNote){
            if(arr[(int)(c-'a')] >0) return false;
        }

        return true;
    }
}