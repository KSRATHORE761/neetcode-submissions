public class Solution {
    public bool IsValid(string s) {
       Stack<char> stk = new Stack<char>();
        
        foreach(char ch in s) { // Fixed: Iterate over the string s
            if(ch == '(' || ch == '[' || ch == '{') {
                stk.Push(ch);
            } else {
                // Fixed: Check if stack is empty before popping or peeking
                if (stk.Count == 0) return false; 
                
                char topElement = stk.Peek();
                if ((ch == ']' && topElement == '[') || 
                    (ch == ')' && topElement == '(') || 
                    (ch == '}' && topElement == '{')) {
                    stk.Pop();
                } else {
                    return false; // Fixed: Early return if brackets mismatch
                }
            }
        }
        return stk.Count == 0;
    }
}
