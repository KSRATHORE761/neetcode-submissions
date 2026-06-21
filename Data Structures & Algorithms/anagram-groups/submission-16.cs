public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       Dictionary<string,List<string>> freq = new Dictionary<string,List<string>>();
       foreach(string str in strs){
        int[] count = new int[26];
        foreach(char ch in str.ToCharArray()){
            count[ch -'a']++;
        }
        string sortedWord = string.Join(",",count);
        if(!freq.ContainsKey(sortedWord)){
            freq[sortedWord] = new List<string>();
        }
        freq[sortedWord].Add(str);
       }
       return freq.Values.ToList<List<string>>();
    }
}
