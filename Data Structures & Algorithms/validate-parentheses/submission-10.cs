public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();
        foreach(char ch in s){
            if(ch=='(' || ch=='{' || ch=='['){
                stk.Push(ch);
            }
            else if(stk.Count > 0 && ((ch == ')' && stk.Peek()=='(') ||
            (ch == '}' && stk.Peek()=='{') ||
            (ch == ']' && stk.Peek()=='['))){
                stk.Pop();
            }
            else{
                return false;
            }
        }
        return stk.Count==0;
    }
}
