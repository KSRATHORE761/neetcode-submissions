public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int longestSequence = 0;
        foreach(int num in nums){
            int currentSequence = 1;
            if(!set.Contains(num-1)){
                while(set.Contains(num+currentSequence)){
                 currentSequence++;   
                }
                longestSequence = Math.Max(longestSequence,currentSequence);
            }
        }
        return longestSequence;
    }
}
