
public class MinStack {
    private Stack<int> stack;

    public MinStack() {
        stack =new Stack<int>();
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
        Stack<int> tempStack = new Stack<int>();
        int mini = stack.Peek();

        while(stack.Count>0){
            mini = System.Math.Min(mini, stack.Peek());
            tempStack.Push(stack.Pop());
        }
        while(tempStack.Count>0){
            stack.Push(tempStack.Pop());
        }
        return mini;
    }
}
