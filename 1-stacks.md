# Stacks
## I. Introduction
Stacks are a useful tool for figuring out where you've been. They are often used in the background of many programs to track where the program has to return to when it completes a function call.
### Last in First Out
"Last in First Out" commonly shortened to LIFO is the fundamental idea behind a stack. It means that the last thing put on our stack will be the first thing we get if we take something off.
### Gallery of Photos
One way to think about how a stack works would be like the gallery on your phone or camera. When you take a picture on your phone it is *pushed* to your gallery or camera roll. If we open our camera roll, it takes us to the last photo we took, and we can scroll or *pop* our photos off our "stack" to go to the next photo and the next photo. Our camera roll not only keeps track of the last photo we took, but it keeps the whole gallery in order. Now we can go back through our memories to see where we've been.

<img src="images/Camera.gif" alt="camera" height="200"/>

## II. Common Operations
### Push
The operation to add something to the top of our stack is called "*push*". To push in C# we use ```myStack.Push(value)```
### Pop
When we want to take what is on the top of our stack off we "*pop*" it off the stack. To pop in C# we use ```myStack.Pop()```. Pop also returns the value taken off the stack.
### Other useful operations
When working with a stack it is important to have methods to check both the size of the stack and when the stack is empty. We can accomplish both of these using the C# code ```myStack.Count()``` which will return the size of the stack.
## III. Efficiency of common operations
As we work with different data structures, one of the most important things to consider when deciding which to use is the efficiency of its most commonly used operations. For the stack its primary purpose is to keep order using our LIFO principle. The main operations we covered above are each O(1). This means that stacks are very efficient at their job.
## IV. Example: Simple Search History
In the example below we will create a simple search history.

Let's begin with our program's requirements to help outline our process for this example:

Simple Search History Requirements:
* Allow the user to create a new search.
* Add the search to the search history.
* Allow the user to remove the most recent search from the search history.
* Display the search history.
```c#
var searchHistory = new Stack<string>();
var choice = 0;
Console.WriteLine("Time to make a new search!");

do {
    Console.WriteLine("Would you like to ");
    Console.WriteLine("1. Start a new search");
    Console.WriteLine("2. See the search history");
    Console.WriteLine("3. Delete the most recent search");
    Console.WriteLine("4. Quit");

    choice = int.Parse(Console.ReadLine()!);

    if (choice == 1) {
        Console.Write("Enter search: ");
        var newSearch = Console.ReadLine()!;
        searchHistory.Push(newSearch);
    }
    else if (choice == 2) {
        Console.WriteLine("\n Search History: ");
        foreach (var search in searchHistory)
        {
            Console.WriteLine(search);
        }
    }
    else if (choice == 3) {
        Console.WriteLine($"Deleted \"{searchHistory.Pop()}\" \n");
    }
    else if (choice == 4) {
        Console.WriteLine("Thanks for searching here!");
    }
    else {
        Console.WriteLine("Invalid choice");
    }

} while (choice != 4);
```
## V. Problem to Solve: Interrupting Conversations
Write a program that tracks a conversation so everyone gets to finish their stories!

Oftentimes friends get talking and as one person tells a story another remembers a story and begins to tell it, but they don't always remember to come back to the person who was telling their story last. This program will take in the name of who is talking and when someone interrupts or side tracks the story it will store the previous person's name and when the current person is done it will take the person who was last talking and put them back as the one telling a story.

Program Requirements:
* There will be three options- add a name, remove a name, see current name.
* The maximum number of side-tracks 5
* When the maximum number of side-tracks is reached display some message to remind the user the conversation is going off the rails.
* When there are no more stories to finish display some message to let the user know they can start a new conversation.

Test the program with the following scenarios:
* Test 1: Use "See current name" option when stack is empty and current name is null.\
    Expected Output: Some error message about starting new conversation.
* Test 2: Add six names to the conversation.\
    Expected Output: Some error message about the conversation getting too full.
* Test 3: Add "Nelly", use "See current name".\
    Expected Output: "Nelly"
* Test 4: Add "Kyle", Add "Ethan", Remove "Ethan", See current name.\
    Expected Output: "Kyle"

Check out the sample solution [here](stack-solution)!\
Return to [overview](0-overview.md).
