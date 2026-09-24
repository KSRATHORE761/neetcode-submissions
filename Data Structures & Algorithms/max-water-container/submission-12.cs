public class Solution {
    public int MaxArea(int[] heights) {
        int largestArea = 0;
        int left = 0, right = heights.Length-1;
        while(left<right){
            int currentArea = (right-left) * Math.Min(heights[left], heights[right]);
            largestArea = Math.Max(largestArea, currentArea);
            // Always move the pointer with the smaller height.
            // Moving the taller pointer would decrease width while height remains capped 
            // by the shorter line, guaranteeing a smaller or equal area.
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
