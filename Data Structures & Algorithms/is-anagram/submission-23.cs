public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        int[] countCharOccurance = new int[26];
        foreach(char ch in s){
            countCharOccurance[ch - 'a']++;
        }
        foreach(char ch in t){
            countCharOccurance[ch - 'a']--;
        }
        foreach(int value in countCharOccurance){
            if(value!=0){
                return false;
            }
        }
        return true;
    }
}
