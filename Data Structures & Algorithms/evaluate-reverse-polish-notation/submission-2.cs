public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens.Length == 0 ) return 0; 
     Stack <int> stack = new Stack <int>(); 
        
     foreach(string s in tokens)
     {       
         if (int.TryParse(s, out int num)) 
            {
                stack.Push(num);
            }     
        else
        { 
            int num1 = stack.Pop();
            int num2  = stack.Pop(); 
            switch (s)
            { 
                case "+": stack.Push(num2 + num1); break;
                case "-": stack.Push(num2 - num1); break;
                case "*": stack.Push(num2 * num1); break;
                case "/": stack.Push(num2 / num1); break;
            }
        }
     }
     return stack.Peek();
    }
}
