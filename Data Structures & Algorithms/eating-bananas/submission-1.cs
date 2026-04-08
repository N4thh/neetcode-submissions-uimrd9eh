public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1 , right = piles.Max();
        int result = 0; 

        while (left <= right)
        { 
            int mid = left +(right -left)/2; 
            if(CanEat(piles,mid,h))
            { 
                result = mid; 
                right  = mid - 1;
            }
            else left = mid +1;
        }
        return result;
    }
     public bool CanEat(int[] piles, int mid, int h)
    { 
        int hours = 0; 
        foreach(int i in piles)
        { 
            hours += (i+mid-1)/mid;
            if(hours > h) return false;
        }
        return hours <= h;
    }
}
