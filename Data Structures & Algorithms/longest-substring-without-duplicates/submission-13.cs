public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int l = 0, r=0;
        int longestSubstring = 0;
        while(r < s.Length){
            while(set.Contains(s[r])){
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            longestSubstring = Math.Max(longestSubstring, r-l +1);
            r++;
        }
        return longestSubstring;
    }
}
