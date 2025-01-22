public class Solution {
    public string MakeGood(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (var data in s) {
            if (stack.Count > 0) {
                var element = stack.Peek();
                // Check if the current character and the top of the stack form a "bad" pair
                if (Char.ToLower(element) == Char.ToLower(data) && element != data) {
                    stack.Pop(); // Remove the top element
                } else {
                    stack.Push(data); // Push the current character
                }
            } else {
                stack.Push(data); // Push the first character
            }
        }
        return string.Join("", stack.Reverse());
    }
}