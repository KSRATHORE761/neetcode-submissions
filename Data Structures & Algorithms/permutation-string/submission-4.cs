public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length) return false;
        int[] countS1 = new int[26];
        foreach(char ch in s1){
            countS1[ch - 'a']++;
        }
        int l=0;
        for(int r = s1.Length-1;r<s2.Length;r++){
            //1. Create an array to store the count of each character in the current window
            int[] countWindow = new int[26];
            for(int i=l;i<=r;i++){
                countWindow[s2[i] -'a']++;
            }
            // 2. Match this window with countS1 arr.
            bool matches= true;
            for(int i=0;i<26;i++){
                if(countS1[i]!=countWindow[i]){
                    matches = false;
                    break;
                }
            }
            if(matches) return true;

            l++;
        }
        return false;
    }
}
