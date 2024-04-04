using System.Security.Cryptography.X509Certificates;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        // Insert only if the value doesn't exist in the tree
        if (value == Data) {
            return;
        }
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == Data) {
            return true;
        } else if (value < Data) {
            if (Left is null){
                return false;
                }
            else {
                return Left.Contains(value);
            }
        } else if (value > Data) {
            if (Right is null) {
                return false;
            }
            else {
                return Right.Contains(value);
            }
        } else {
            return false;
        }
    }

    public int GetHeight() {
        int GetHeight(Node node) {
            if (node is null) {
                return 0;
            } else {
                int left = GetHeight(node.Left);
                int right = GetHeight(node.Right);
                return 1 + Math.Max(left, right);
            }
        } 
        return GetHeight(this);
    }
}