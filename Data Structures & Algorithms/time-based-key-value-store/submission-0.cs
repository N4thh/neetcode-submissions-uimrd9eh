public class TimeMap {
    private Dictionary <string, List<(int, string)>>map; 

    public TimeMap() {
        map = new Dictionary <string, List<(int,string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)){ 
            map[key] = new List<(int, string)>();
        }
        map[key].Add((timestamp, value)); 
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)){
            return "";
        }

        int left = 0, right = map[key].Count -1; 
        string value = "";

        while(left <= right){ 
            int mid = left + (right - left) / 2;
            if(map[key][mid].Item1 <= timestamp){ 
                value = map[key][mid].Item2;
                left = mid +1; 
            }
            else right = mid -1; 
        }
        return value;
    }
}
