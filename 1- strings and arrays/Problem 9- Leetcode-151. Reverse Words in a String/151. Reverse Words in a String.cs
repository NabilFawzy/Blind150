public class Solution {
    public string ReverseWords(string s) {
        return String.Join(" ", s.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}