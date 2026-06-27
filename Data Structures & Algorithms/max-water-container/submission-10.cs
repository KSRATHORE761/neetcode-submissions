public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;
        int l = 0;
        int r = heights.Length-1;
        while(l<r){
            maxWater = Math.Max(maxWater, (r-l)* Math.Min(heights[l],heights[r]));
            if(heights[l]< heights[r])l++;
            else r--;
        }
        return maxWater;
    }
}
