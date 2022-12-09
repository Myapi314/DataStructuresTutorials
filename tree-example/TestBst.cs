namespace tree_example;

public static class TestBst {

    public static void Run() {
        // Sample Test Cases 
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(new Book("Beyonders", "Brandon Mull", 2011));
        tree.Insert(new Book("Kingdom of the Wicked", "Keri Maniscalco", 2020));
        tree.Insert(new Book("Maze Runner", "James Dashner", 2009));
        tree.Insert(new Book("Fablehaven", "Brandon Mull", 2006));
        tree.Insert(new Book("Matched", "Ally Condie", 2010));

        tree.Insert(new Book("Beyonders", "Brandon Mull", 2011));   // Expected: No Duplicate Titles allowed

        Console.WriteLine(tree.ToString()); 
        //Expected: <Bst>{<Book>{Title: Beyonders, Author: Brandon Mull, Year: 2011}, 
        // <Book>{Title: Fablehaven, Author: Brandon Mull, Year: 2006},
        // <Book>{Title: Kingdom of the Wicked, Author: Keri Maniscalco, Year: 2020},
        // <Book>{Title: Matched, Author: Ally Condie, Year: 2010},
        // <Book>{Title: Maze Runner, Author: James Dashner, Year: 2009}}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        Console.WriteLine(tree.Contains(2009)); // True
        Console.WriteLine(tree.Contains(2000)); // False
        Console.WriteLine(tree.Contains(2020)); // True
        Console.WriteLine(tree.Contains(2011)); // True
        Console.WriteLine(tree.Contains(2022)); // False

        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        foreach (var value in tree.Reverse()) {
            Console.WriteLine(value); 
        }
        // Expected: <Book>{Title: Maze Runner, Author: James Dashner, Year: 2009}
        // <Book>{Title: Matched, Author: Ally Condie, Year: 2010}
        // <Book>{Title: Kingdom of the Wicked, Author: Keri Maniscalco, Year: 2020}
        // <Book>{Title: Fablehaven, Author: Brandon Mull, Year: 2006}
        // <Book>{Title: Beyonders, Author: Brandon Mull, Year: 2011}


        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        Console.WriteLine(tree.GetHeight()); // 3
        tree.Insert(new Book("Anne of Green Gables", "L. M. Montgomery", 1908));
        Console.WriteLine(tree.GetHeight()); // 4
        tree.Insert(new Book("Matilda", "Roald Dahl", 1988));
        Console.WriteLine(tree.GetHeight()); // 5

    }

}