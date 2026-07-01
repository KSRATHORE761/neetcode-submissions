public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==null || s.Length==0) return 0;
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int right=0;
        int n = s.Length;
        int len=0;
        while(right<n){
            while(set.Contains(s[right])){
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            len = Math.Max(len,right-left+1);
            right++;
        }
        return len;
    }
}
