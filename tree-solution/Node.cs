namespace tree_example;

public class Node {
    public Book Book {get; set;} 
    public string Title {get; set;}
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(Book book) {
        this.Book = book;
        this.Title = this.Book.Title;
    }

    /// <summary>
    /// Insert a value into the sorted tree. Not allowing duplicates.
    /// </summary>
    /// <param name="value">The value to insert</param>
    public void Insert(Book value) {
        if (value.Title == Title)
        {
            // Do not add duplicate data
            Console.WriteLine("Cannot Add Duplicate Titles.");
            return;
        }
        if (value.Title.CompareTo(Title) < 0) {
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

    /// <summary>
    /// Check to see if the node data matches a certain value
    /// </summary>
    /// <param name="value">The value to look for</param>
    /// <returns>true if found, otherwise false</returns>
    public bool Contains(string value)
    {
        if (value == Title)
        {
            return true;
        }

        // Traverse the tree.
        if (value.CompareTo(Title) < 0) {
            // Check to the left
            if (Left is null)
                return false;
            return Left.Contains(value);
        }
        
        // Check to the right
        if (Right is null)
            return false;
        return Right.Contains(value);
    }

    /// <summary>
    /// Find the height of the node.
    /// </summary>
    /// <returns>default is 1 if there is only the root node</returns>
    public int GetHeight()
    {
        
        // Traverse the tree and add one for each node
        // Compare Left Subtree height to Right Subtree height
        // Add to overall height

        return 1 + Math.Max(Left?.GetHeight() ?? 0, Right?.GetHeight() ?? 0);
    }
}