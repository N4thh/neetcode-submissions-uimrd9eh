public class MinStack {
    private Stack <int> stack;
    public MinStack() {
        stack = new Stack <int> (); 
    }
    
    public void Push(int val) {
        stack.Push(val); 
    }
    
    public void Pop() {
        stack.Pop(); 
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        Stack <int> secondStack = new Stack <int> ();
        int min = stack.Peek();

        while (stack.Count > 0 )
         { 
            min = Math.Min(min, stack.Peek()); 
            secondStack.Push(stack.Pop());
         }    
         while (secondStack.Count > 0 )
         { 
            stack.Push(secondStack.Pop());
         }  
         return min ;
    }
}
