public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] sufix = new int[nums.Length];
        int[] res = new int[nums.Length];
        prefix[0]=1;
        sufix[nums.Length-1]=1;
        for(int i = 1;i<nums.Length;i++){
            prefix[i] = nums[i-1] * prefix[i-1];
        }
        for(int j = nums.Length-2; j>=0;j--){
            sufix[j] = nums[j+1] * sufix[j+1];
        }
        for(int k=0;k<nums.Length;k++){
            res[k] = prefix[k] * sufix[k];
        }
        return res;
    }
}
