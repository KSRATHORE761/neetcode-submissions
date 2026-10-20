public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();
        while(left<=right){
            int k = (left+right)/2;
            if(h< TimeTakenToEatBananas(piles,k)){
                left = k+1;
            }
            else{
                right = k-1;
            }
        }
        return left;
    }
    public int TimeTakenToEatBananas(int[] piles, int k){
        int hours = 0;
        foreach(int p in piles){
            hours += (int)Math.Ceiling((double)p/k);
        }
        return hours;
    }
}
