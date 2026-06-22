public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach(char ch in s){
            if(char.IsLetterOrDigit(ch)){
                sb.Append(ch);
            }
        }
        string newWord= sb.ToString().ToLower();
        Console.WriteLine(newWord);
        int i=0;
        int j= newWord.Length-1;
        while(i<j){
            if(newWord[i] != newWord[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
