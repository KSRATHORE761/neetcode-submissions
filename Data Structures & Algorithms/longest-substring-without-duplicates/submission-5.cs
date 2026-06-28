public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==null || s.Length==0) return 0;

        HashSet<char> set = new HashSet<char>();
        int longestSubstring = 0;
        int left=0;
        for(int right =0;right<s.Length;right++){
            while(set.Contains(s[right])){
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            longestSubstring = Math.Max(longestSubstring, right-left+1);
        }
        return longestSubstring;
    }
}
