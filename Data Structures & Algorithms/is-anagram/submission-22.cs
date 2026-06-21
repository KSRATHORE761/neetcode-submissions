public class Solution {
    public bool IsAnagram(string s, string t) {
       Dictionary<char,int> countS = new Dictionary<char,int>();
       Dictionary<char,int> countT = new Dictionary<char,int>();
       foreach(char ch in s.ToCharArray()){
        countS[ch] = countS.GetValueOrDefault(ch,0)+1;
       }
       foreach(char ch in t.ToCharArray()){
        countT[ch] = countT.GetValueOrDefault(ch,0)+1;
       }
       return countS.Count == countT.Count && !countS.Except(countT).Any();
    }
}
