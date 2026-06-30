public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];

        foreach(char ch in s1){
           arr1[ch-'a']++;
        }
        int l=0, r=0;
        while(r<s2.Length){
            arr2[s2[r] -'a']++;
            if(r-l+1 == s1.Length){
                if(isArrayEqual(arr1,arr2)){
                    return true;
                }
            }
            if(r-l+1<s1.Length){
                r++;
            }
            else{
                arr2[s2[l] - 'a']--;
                l++;
                r++;
            }
        }
        return false;
    }
    private bool isArrayEqual(int[] arr1, int[] arr2) {
       for(int i=0;i<26;i++){
            if(arr1[i]!=arr2[i])return false;
       }
        return true;
    }
}
