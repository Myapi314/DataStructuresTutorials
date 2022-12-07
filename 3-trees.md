# Trees
## I.Introduction
Just as the name implies, this data structure uses the idea of tree graphs to build a new kind of relation between data. Trees in C# are built off of the array data structure. The first element or node in a tree is the root, and the nodes directly connected to it are its children. Each child node can have its own child nodes and so on. A child node with no children is called a leaf. \
The main benefit of trees that we will discuss is their ability to decrease the time it takes to search for a value.
## Binary Search Trees
The tree we will be practicing using today is called the **binary search tree** (BST). In a binary tree each node is only able to connect up to two nodes. However, to be a binary search tree there are additional rules the data structure must follow in order for it to be effective. When adding data to a BST, the data must be compared to the parent node. Data that is less than the parent node will be put to the left and data larger will be put to the right. In this way, data in a BST is considered sorted which allows us to develop a more efficient search algorithm. Even when adding data this way, the BST must also be balanced in order to be more efficient. To balance a tree, the difference of height between any two subtrees must be 0 if not a relatively small difference. To obtain the height of tree or subtree, we count the maximum number of nodes between the root and its leaves. 
## Recursion
When working with trees we often traverse them using recursion. In programming recursion happens when a function calls itself within itself. This is tricky territory, as you can easily get stuck in an infinite loop with no way out. For good practice there are two basic steps when using recursion-
1. What is the base case? Or what should the default behavior be?
2. What is the overall process being done?\
With trees often our base case will be when the function has reached the leaf. In other words, when we no longer have anywhere to go in the tree we have reached a node with no children and should no longer continue down the tree. 
## Common Operations
In C# the built-in data structure for a tree is called ```SortedSet<T>```, however for the purposes of this tutorial we will provide a binary search tree class that will utilize the common operations of a search tree. 
| Common BST  Operation  | Description                               |
|------------------------|-------------------------------------------|
| ```insert(value)```    | Insert a value into the tree.             |
| ```remove(value)```    | Remove value from the tree.               |
| ```contains(value)```  | Determine if value is in tree.            |
| ```traverse_forward``` | Visit all nodes from smallest to largest. |
| ```traverse_reverse``` | Visit all nodes from largest to smallest. |
| ```height(node)```     | Determine height of a node.               |
| ```size()```           | Return size of the BST.                   |
| ```empty()```          | Returns true if root node is empty.       |
## Efficiency of Common Operations
The common operation *insert*, *remove*, and *contains* all have an algorithmic efficiency of O(log n). We can see this in the way these methods are implemened. For example, in order to insert something in the sorted order we need to find where the value fits. We start at the root node, compare if the value is less than or greater than the value in that current node. Based on that distinction we move to the corresponding subtree and continue until we find a leaf and insert after that node. Each time we make this distinction of greater than or less than, we remove half the data we need to inspect (as long as our tree is balanced). Remove and contains work similarly.\
The traverse methods along with the height are all O(n). This is because in these three methods each node is visited at least once. This takes place with the heigh function as it must determine and compare heights of subtrees in order to find the maximum length of a root to a leaf.\
Finally size and empty are O(1) similar to our other data structures we have discussed.
## Example: Sorting Books
In the example below we will create a program that sorts books by year. 

Sorting Books Requirements:
* Add Books with title, author, and year published in sorted order.
* Able to search for book by year.
* Able to get the height of the tree.
* Able to display the books in order and reversed by year.

With this project we will have three distinct classes- BinarySearchTree, Node, and Book. Our BST is made up of nodes, and the data stored in our nodes is made up of a book. The book will keep track of the title, author and year published. 
## Problem to Solve: Sorting Books II
For this problem, we will build off of our example with books and try sorting on a different attribute such as title. 

Sorting Books Requirements:
* Add Books with title, author, and year published in sorted order.
* Able to search for book by title.
* Able to get the height of the tree.
* Able to display the books in alphabetical order and reversed by title.

See [solution](tree-solution)
Return to [overview](0-overview.md)
