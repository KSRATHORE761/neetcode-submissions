public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> count = new Dictionary<char,int>();
        int res=0, maxFreq =0, l=0;
        for(int r=0;r<s.Length;r++){
            count[s[r]] = count.GetValueOrDefault(s[r],0)+1;
            maxFreq = Math. Max(maxFreq, count[s[r]]);

            while((r-l+1) - maxFreq >k){
                count[s[l]]--;
                l++;
            }
            res = Math.Max(res, r-l+1);
        }
        return res;
    }
}
