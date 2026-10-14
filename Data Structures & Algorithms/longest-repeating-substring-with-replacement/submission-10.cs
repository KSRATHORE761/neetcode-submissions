public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        int l=0, maxFreqeuncy = 0;
        int res=0;
        for(int r=0;r<s.Length;r++){
            map[s[r]] = map.GetValueOrDefault(s[r],0)+1;
            maxFreqeuncy = Math.Max(maxFreqeuncy, map[s[r]]);
            while((r-l+1) - maxFreqeuncy > k){
                map[s[l]]--;
                l++;
            }
            res = Math.Max(res, r-l+1);
        }
        return res;
    }
}
