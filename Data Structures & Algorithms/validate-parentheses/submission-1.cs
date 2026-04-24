public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            Console.WriteLine(c);
            if (c == ']') {
                if (stack.Count() != 0 && stack.Peek() == '[') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else if (stack.Count() != 0 && c == '}') {
                if (stack.Peek() == '{') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else if (stack.Count() != 0 && c == ')') {
                if (stack.Peek() == '(') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        if (stack.Count > 0) {
            return false;
        }
        return true;
    }
}
