public class MedianFinder {
    public List<int> arr = new List<int>();

    public MedianFinder() {
        arr = new List<int>();    
    }
    
    public void AddNum(int num) {
        arr.Add(num); 
        arr.Sort(); 
    }
    
    public double FindMedian() {
        int left = 0, right = arr.Count - 1; 
        int mid = left + (right - left) / 2; 

        double rs = arr[mid];
        double final = 0.0; 
        if(arr.Count % 2 == 0) { 
            double rs1 = arr[mid + 1];
            final = (rs + rs1) / 2.0;
        } else final = rs; 

        return final;
    }
  
}
