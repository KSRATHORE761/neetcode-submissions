public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        Dictionary<char,int> countS1 = new Dictionary<char,int>();
        Dictionary<char,int> countS2 = new Dictionary<char,int>();

        foreach(char ch in s1){
            countS1[ch] = countS1.GetValueOrDefault(ch,0)+1;
        }
        int l=0, r=0;
        while(r<s2.Length){
            countS2[s2[r]] = countS2.GetValueOrDefault(s2[r],0)+1;
            if(r-l+1 == s1.Length){
                if(countS1.Count == countS2.Count && !countS1.Except(countS2).Any()){
                    return true;
                }
                // Prepare to shrink the window from the left
                char leftChar = s2[l];
                countS2[leftChar]--;

                // CRITICAL FIX: Remove the key completely if its count hits 0
                if (countS2[leftChar] == 0) {
                    countS2.Remove(leftChar);
                }
                l++;
            }
            r++;
        }
        return false;
    }
    // CRITICAL FIX: Safe and precise O(1) dictionary comparison (max 26 keys)
    private bool AreDictionariesEqual(Dictionary<char, int> d1, Dictionary<char, int> d2) {
        if (d1.Count != d2.Count) {
            return false;
        }
        foreach (var kvp in d1) {
            if (!d2.TryGetValue(kvp.Key, out int val) || val != kvp.Value) {
                return false;
            }
        }
        return true;
    }
}
