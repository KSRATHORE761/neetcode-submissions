public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int longestSubstring = 0;
        int l = 0;
        for(int r = 0; r<s.Length; r++){
            while(set.Contains(s[r])){
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            longestSubstring = Math.Max(longestSubstring, r-l +1);
        }
        return longestSubstring;
    }
}
