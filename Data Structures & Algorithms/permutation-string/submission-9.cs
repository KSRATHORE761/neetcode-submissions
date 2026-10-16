public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        
        foreach(char ch in s1){
            arr1[ch -'a']++;
        }

        int l=0;
        for(int r=0;r<s2.Length;r++){
            arr2[s2[r] - 'a']++;
            while((r-l+1) == s1.Length){
                if(IsArrayEqual(arr1, arr2)) return true;
                arr2[s2[l] - 'a']--;
                l++;
            }
        }
        return false;
    }
    bool IsArrayEqual(int[] arr1, int[] arr2){
        for(int i=0; i<arr1.Length;i++){
            if(arr1[i] !=arr2[i]){
                return false;
            }
        }
        return true;
    }
}
