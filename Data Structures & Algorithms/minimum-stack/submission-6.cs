public class MinStack {
    Stack<int> stack;
    Stack<int> minStack;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        int mini = Math.Min(val, minStack.Count==0 ? val : minStack.Peek());
        stack.Push(val);
        minStack.Push(mini);
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
