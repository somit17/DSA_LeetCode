public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> myStack = new Stack<int>();
        foreach (var data in operations) {
            if (data.Equals("+")) {
                if (myStack.Count >= 2) { // Ensure there are at least 2 elements
                    int element1 = myStack.Pop();
                    int element2 = myStack.Peek();
                    myStack.Push(element1);
                    myStack.Push(element1 + element2);
                }
            }
            else if (Char.IsLetter(data[0])) {
                if (data.Equals("C")) {
                    if (myStack.Count > 0) {
                        myStack.Pop();
                    }
                }
                else if (data.Equals("D")) {
                    if (myStack.Count > 0) {
                        var element = myStack.Peek();
                        myStack.Push(2 * element);
                    }
                }
            }
            else {
                myStack.Push(Convert.ToInt32(data));
            }
        }
        int result = 0;
        while (myStack.Count > 0) {
            result += myStack.Pop();
        }
        return result;
    }
}