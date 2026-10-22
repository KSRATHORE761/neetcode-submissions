public class TimeMap {
    Dictionary<string, List<Pair>> hashmap;
    public TimeMap() {
        hashmap = new Dictionary<string, List<Pair>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!hashmap.ContainsKey(key)) {
            hashmap[key] = new List<Pair>();
        }
        hashmap[key].Add(new Pair(timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        string resVal = "";
        if(hashmap.ContainsKey(key)){
            List<Pair> arr = hashmap[key];
            int low = 0, high = arr.Count-1;
            while(low<=high){
                int mid = low + (high - low)/2;
                int timeVal = arr[mid].timestamp;
                if(timeVal == timestamp){
                    return arr[mid].val;
                }
                else if(timeVal < timestamp){
                    resVal = arr[mid].val;
                    low = mid+1;
                }
                else{
                    high = mid-1;
                }
            }
        }
        return resVal;
    }
}

public class Pair{
   public int timestamp;
    public string val;

    public Pair(int timestamp, string val){
        this.timestamp = timestamp;
        this.val = val;
    }
}