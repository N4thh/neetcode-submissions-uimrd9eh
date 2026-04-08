public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>(); 

        void dfs(string sub, int n, int open, int close) { 
            if(open == n && close == n) { 
                res.Add(sub); 
                return; 
            }

            if(open > close) { 
                dfs(sub + ")", n, open, close +1);
            }

            if(open < n) { 
                dfs(sub + "(", n, open+1, close);
            }
        }
        dfs("", n, 0,0);
        return res;
    }
}
