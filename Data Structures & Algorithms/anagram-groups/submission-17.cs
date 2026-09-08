public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        foreach(string word in strs){
            int[] charArray = new int[26];
            foreach(char ch in word){
                charArray[ch -'a']++;
            }
            string sortedKey = string.Join(",",charArray);
            if(!map.ContainsKey(sortedKey)){
                map[sortedKey] = new List<string>();
            }
            map[sortedKey].Add(word);
        }
        return map.Values.ToList<List<string>>();
    }
}
 