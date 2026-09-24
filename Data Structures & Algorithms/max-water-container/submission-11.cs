public class Solution {
    public int MaxArea(int[] heights) {
        int largestArea = 0;
        int left = 0, right = heights.Length-1;
        while(left<right){
            int currentArea = (right-left) * Math.Min(heights[left], heights[right]);
            largestArea = Math.Max(largestArea, currentArea);
            if(heights[left] < heights[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return largestArea;
    }
}
