public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1, r= piles.Max();
        int res = r;

        while(l <= r){
            int k = (l+r)/2;

            if(h<TimeTakenToEatBanana(piles,k)){
                l = k+1;
            }
            else{
                r = k-1;
            }
        }
        return l;
    }

    public int TimeTakenToEatBanana(int[] piles, int k){
        int hours = 0;
        foreach(int p in piles){
            hours += (int)Math.Ceiling((double)p/k);
        }
        return hours;
    }
}
