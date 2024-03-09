public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) { // receive a string line
        var stack = new Stack<char>(); // create stack of characters
        foreach (var item in line) { // iterate through the line
            if (item is '(' or '[' or '{') { // check if it's an opening sign
                stack.Push(item);
            }
            else if (item is ')') { // if the stack is not empty
                if (stack.Count == 0 || stack.Pop() != '(')  // and the closing sign does not correspond, return false
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}