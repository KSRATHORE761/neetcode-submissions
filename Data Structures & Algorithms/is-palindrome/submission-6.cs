public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach(char str in s){
            if(char.IsLetterOrDigit(str)){
                sb.Append(char.ToLower(str));
            }
        }
        int l=0;
        int r=sb.Length-1;
        while(l<r){
            if(sb[l]!=sb[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
