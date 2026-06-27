public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left=0;
        int right=numbers.Length-1;
        while(left<right){
            int curSum = numbers[left] + numbers[right];
            if(curSum<target){
                left++;
            }
            else if(curSum>target){
                right--;
            }
            else{
                left++;
                right++;
                return new int[]{left,right};
            }
        }
        return new int[]{-1,-1};
    }
}
