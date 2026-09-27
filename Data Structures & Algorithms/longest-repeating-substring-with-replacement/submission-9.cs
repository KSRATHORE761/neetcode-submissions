public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        int res=0, l=0, maxFreq = 0;
        for(int r=0;r<s.Length;r++){
            map[s[r]] = map.GetValueOrDefault(s[r],0)+1;
            maxFreq = Math.Max(maxFreq, map[s[r]]);
            while((r-l+1) - maxFreq > k){
                map[s[l]]--;
                l++;
            }
            res = Math.Max(res, (r-l+1));
        }
        return res;
    }
}
