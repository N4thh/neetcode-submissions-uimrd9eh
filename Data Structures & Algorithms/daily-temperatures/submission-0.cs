public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
      int n = temperatures.Length; 
      Stack <int> stack = new Stack <int>(); 
      for(int i = 0 ; i < n ;i++)
      {
        int j =i +1; 
        while (j < n && temperatures[j] <= temperatures [i])
        { 
            j++;
        }
        if(j < n) stack.Push(j-i); 
        else {stack.Push(0);}
        
      }
      return stack.Reverse().ToArray();
    }
}
