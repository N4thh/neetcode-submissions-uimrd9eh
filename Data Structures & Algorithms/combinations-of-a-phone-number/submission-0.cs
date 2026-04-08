public class Solution {
    public List<string> LetterCombinations(string digits) {
        List<string> res= new List<string>();
        Dictionary<char, string> phone = new Dictionary<char, string>{
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"}, 
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}, 
        };

        if (string.IsNullOrEmpty(digits))
            return res;
   
        void dfs(string sub, int index) { 
            if(index == digits.Length) { 
                res.Add(sub); 
                return; 
            }

            string letter = phone[digits[index]];
            foreach(char c in letter) { 
                dfs(sub + c, index + 1);
            }
        }

        dfs("",0);
        return res;
    }
    
}
