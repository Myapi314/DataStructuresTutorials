using System.Collections;

namespace tree_example;

public class BinarySearchTree : IEnumerable<Book> {
    private Node? _root;

    /// <summary>
    /// Insert a new node at the front (i.e. the root) of the BST.
    /// </summary>
    public void Insert(Book value) {

        // Create new node
        Node newNode = new Node(value);

        // If the list is empty, then point root to the new node.
        if (_root is null)
            _root = newNode;

        // If the list is not empty, then only head will be affected.
        else
            _root.Insert(value);
    }

    /// <summary>
    /// Check to see if the tree contains a certain value
    /// </summary>
    /// <param name="value">The value to look for</param>
    /// <returns>true if found, otherwise false</returns>
    public bool Contains(int value) {
        return _root != null && _root.Contains(value);
    }

    /// <summary>
    /// Yields all values in the tree
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<Book> GetEnumerator() {
        var books = new List<Book>();
        TraverseForward(_root, books);
        foreach (var book in books) {
            yield return book;
        }
    }

    /// <summary>
    /// Traverse through the BST from least to greatest
    /// </summary>
    private void TraverseForward(Node? node, List<Book> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Book);
            TraverseForward(node.Right, values);
        }
    }

    /// <summary>
    /// Iterate backward through the BST.
    /// </summary>
    public IEnumerable Reverse() {
        var books = new List<Book>();
        TraverseBackward(_root, books);
        foreach (var book in books) {
            yield return book;
        }
    }

    /// <summary>
    /// Traverse through the BST from greatest to least
    /// </summary>
    private void TraverseBackward(Node? node, List<Book> values) {

        if (node is not null) {

            // Go all the way to the right most node
            TraverseBackward(node.Right, values);

            // Add it to values
            values.Add(node.Book);

            // Work through the left
            TraverseBackward(node.Left, values);
        }
        
    }

    /// <summary>
    /// Get the height of the tree
    /// </summary>
    public int GetHeight() {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    public override string ToString() {
        return "<Bst>{" + string.Join(", \n", this) + "}";
    }
}