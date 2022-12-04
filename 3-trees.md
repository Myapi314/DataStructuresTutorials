# Trees
## I.Introduction
Just as the name implies, this data structure uses the idea of tree graphs to build a new kind of relation between data. Trees in C# are built off of the array data structure. The first element or node in a tree is the root, and the nodes directly connected to it are its children. Each child node can have its own child nodes and so on. A child node with no children is called a leaf. \
The main benefit of trees that we will discuss is their ability to decrease the time it takes to search for a value.
## Binary Search Trees
The tree we will be practicing using today is called the **binary search tree** (BST). In a binary tree each node is only able to connect to up to two nodes. However, to be a binary search tree there are additional rules the data structure must follow in order for it to be effective. When adding data to a BST, the data must be compared to the parent node. Data that is less than the parent node will be put to the left and data larger will be put to the right. In this way, data in a BST is considered sorted which allows us to develop a more efficient search algorithm. Even when adding data this way, the BST must also be balanced. To balance a tree, the difference of height between any two subtrees must be 0 if not particularly small. To obtain the height of tree or subtree, we count the maximum number of nodes between the root and its leaves. 
## Common Operations
In C# the built-in data structure for a tree is called ```SortedSet<T>```, however for the purposes of this tutorial we will provide a binary search tree class that will utilize the common operations of a search tree. 
## Efficiency of Common Operations
## Example: Sorting Numbers
## Problem to Solve