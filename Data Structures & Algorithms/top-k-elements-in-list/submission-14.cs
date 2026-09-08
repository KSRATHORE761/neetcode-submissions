public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        foreach(int number in nums){
            frequency[number] = frequency.GetValueOrDefault(number,0)+1;
        }
        Dictionary<int,int> sorrtedFrequency  = frequency.OrderByDescending(x => x.Value).ToDictionary(
            x => x.Key, x=>x.Value
        );
        int[] res = new int[k];
        int counter = 0;
        foreach(KeyValuePair<int,int> entry in sorrtedFrequency){
            if(counter>=k){
                break;
            }
            res[counter++] = entry.Key;
        }
        return res;
    }
}
