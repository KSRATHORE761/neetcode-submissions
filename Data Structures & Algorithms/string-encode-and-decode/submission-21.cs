public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string word in strs){
            int wordLength = word.Length;
            string newWord = wordLength.ToString()+"#"+word;
            sb.Append(newWord);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> lst = new List<string>();
        int i=0;
        for(int j=0;j<s.Length && i<s.Length;j++){
            if(s[j]=='#'){
                int wordLength = int.Parse(s.Substring(i,j-i));
                string word = s.Substring(j+1,wordLength);
                lst.Add(word);
                j = j+wordLength;
                i = j+1;
            }
        }
        return lst;
   }
}
