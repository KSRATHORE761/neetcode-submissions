public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0 || nums == null){
            return 0;
        }
        HashSet<int> set = new HashSet<int>(nums);
        int longestSequence = 1;
        foreach(int num in set){
            if(!set.Contains(num-1)){
                int currentSeq = 1;
                while(set.Contains(num+currentSeq)){  
                    currentSeq++;                  
                }
                longestSequence = Math.Max(longestSequence, currentSeq);
            }
        }
        return longestSequence;
    }
}
