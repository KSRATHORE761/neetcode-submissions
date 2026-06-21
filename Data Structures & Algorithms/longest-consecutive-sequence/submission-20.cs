public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length==0) return 0;
        HashSet<int> set = new HashSet<int>(nums);
        int longestSequence = 1;
        foreach(int num in nums){
            if(!set.Contains(num-1)){
                int currentSequence = 1;
                while(set.Contains(num+currentSequence)) currentSequence++;
                longestSequence=Math.Max(currentSequence,longestSequence);
            }
        }
        return longestSequence;
    }
}
