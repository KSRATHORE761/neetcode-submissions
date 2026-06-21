public class Solution {
    public string Encode(IList<string> strs) { 
        StringBuilder sb  = new StringBuilder();
        foreach(string str  in strs){
            sb.Append(str.Length+ "#"+ str);
        }
        return sb.ToString();
    }
    public List<string> Decode(string strs){
        List<string> lst = new List<string>();
        int i=0;
        for(int j=0;j<strs.Length;j++){
            if(strs[j]=='#'){
                int wordLength = Convert.ToInt32(strs.Substring(i,j-i));
                string word = strs.Substring(j+1,wordLength);
                lst.Add(word);
                i = j+ wordLength+1;
                j=i;
            }
        }
        return lst;
    }
}
