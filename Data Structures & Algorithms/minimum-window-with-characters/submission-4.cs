public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> countT = new Dictionary<char,int>();
        Dictionary<char,int> window = new Dictionary<char,int>();
        foreach(char ch in t){
            countT[ch] = countT.GetValueOrDefault(ch,0)+1;
        }
        int need = countT.Count, have = 0;
        int resLen = int.MaxValue;
        int[] res = {-1,-1};
        int l=0;

        for(int r = 0; r < s.Length; r++){
            char ch = s[r];
            window[ch] = window.GetValueOrDefault(ch,0)+1;
            if(countT.ContainsKey(ch) && countT[ch] == window[ch]){
                have++;
            }
            while(have == need){
                if((r-l+1) < resLen){
                    resLen = r-l+1;
                    res[0]=l;
                    res[1]=r;
                }
                char leftChar = s[l];
                window[leftChar]--;
                if(countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]){
                    have--;
                }
                l++;
            }
        }
        return resLen == int.MaxValue ? "" : s.Substring(res[0],resLen);
    }
}
