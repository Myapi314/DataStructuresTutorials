namespace tree_example;

public class Node {
    public Book Book {get; set;} 
    public int Year {get; set;}
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(Book book) {
        this.Book = book;
        this.Year = this.Book.PubYear;
    }

    /// <summary>
    /// Insert a value into the sorted tree. Not allowing duplicates.
    /// </summary>
    /// <param name="value">The value to insert</param>
    public void Insert(Book value) {
        // Check if the book is already in tree
        if (value.PubYear == Book.PubYear)
        {
            // We don't want to add the same book twice
            Console.WriteLine("Cannot Add Duplicate Years.");
            return;
        }
        if (value.PubYear < Year) {
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
    public bool Contains(int value)
    {
        if (value == Year)
        {
            return true;
        }

        // Traverse the tree.
        if (value < Year) {
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