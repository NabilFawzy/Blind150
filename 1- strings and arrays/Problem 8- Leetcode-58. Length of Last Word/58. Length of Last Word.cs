public class Solution {
    public int LengthOfLastWord(string s) {
      var res =  s.Trim().Split(" ").ToList();
      return (res[res.Count()-1]).Count();
    }
}
//Problem 8- Leetcode-58. Length of Last Word