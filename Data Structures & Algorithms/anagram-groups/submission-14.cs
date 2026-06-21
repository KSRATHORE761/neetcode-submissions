public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       Dictionary<string,List<string>> freq = new Dictionary<string,List<string>>();
       foreach(string str in strs){
        char[] word = str.ToCharArray();
        Array.Sort(word);
        string sortedWord = new string(word);
        if(!freq.ContainsKey(sortedWord)){
            freq[sortedWord] = new List<string>();
        }
        freq[sortedWord].Add(str);
       }
       return freq.Values.ToList<List<string>>();
    }
}
