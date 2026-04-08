public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> res = new List<List<string>>(); 
        List<string> sub = new List<string>(); 

        void dfs(int index) { 
            if(index == s.Length) { 
              res.Add(new List<string>(sub)); 
              return; 
            }

            for(int i = index; i < s.Length; i++) { 
                string cur = s.Substring(index, i-index +1);
                
                if(IsPalindrome(cur)) { 
                    sub.Add(cur); 
                    dfs(i + 1); 
                    sub.RemoveAt(sub.Count -1);
                }
            }
        }
        dfs(0);
        return res;

    }
    private bool IsPalindrome(string s) { 
        int left = 0, right = s.Length - 1; 
        while(left < right) { 
            if(s[left] != s[right])
                return false; 
            left ++; 
            right --;
        } 
        return true;
    }
}