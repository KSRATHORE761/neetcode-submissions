public class MinStack {
    Stack<int> stack;
    public MinStack() {
        stack = new Stack<int>();
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
        Stack<int> tempStack  = new Stack<int>();
        int minValue = stack.Peek();
        while(stack.Count>0){
            minValue = Math.Min(minValue, stack.Peek());
            tempStack.Push(stack.Pop());
        }
        while(tempStack.Count>0){
            stack.Push(tempStack.Pop());
        }
        return minValue;
    }
}
